﻿using Newtonsoft.Json;
using Stripe.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Stripe
{
    internal static class ParameterBuilder
    {
        public static string ApplyAllParameters(this StripeService service, object obj, string url, bool isListMethod = false)
        {
            string newUrl = url;

            if (obj != null)
            {
                foreach (var property in obj.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
                {
                    var value = property.GetValue(obj, null);
                    if (value == null) continue;

                    foreach (var attribute in property.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Cast<JsonPropertyAttribute>())
                    {
                        if (attribute.PropertyName.ToLower().Contains("metadata"))
                            newUrl = ApplyMetadataParameters(newUrl, value);
                        else if (attribute.PropertyName.ToLower().Contains("fraud_details"))
                        {
                            var fraudDetails = (Dictionary<string, string>)value;

                            foreach (string key in fraudDetails.Keys)
                            {
                                newUrl = ApplyParameterToUrl(newUrl, $"fraud_details[{key}]", fraudDetails[key]);
                            }
                        }
                        else if (property.PropertyType == typeof(StripeDateFilter))
                        {
                            var filter = (StripeDateFilter)value;

                            if (filter.EqualTo.HasValue)
                                newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName, filter.EqualTo.Value.ConvertDateTimeToEpoch().ToString());

                            if (filter.LessThan.HasValue)
                                newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName + "[lt]", filter.LessThan.Value.ConvertDateTimeToEpoch().ToString());

                            if (filter.LessThanOrEqual.HasValue)
                                newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName + "[lte]", filter.LessThanOrEqual.Value.ConvertDateTimeToEpoch().ToString());

                            if (filter.GreaterThan.HasValue)
                                newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName + "[gt]", filter.GreaterThan.Value.ConvertDateTimeToEpoch().ToString());

                            if (filter.GreaterThanOrEqual.HasValue)
                                newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName + "[gte]", filter.GreaterThanOrEqual.Value.ConvertDateTimeToEpoch().ToString());
                        }
                        else if (value as INestedOptions != null)
                        {
                            newUrl = ApplyNestedObjectProperties(newUrl, value);
                        }
                        else
                        {
                            newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName, value.ToString());
                        }
                    }
                }
            }

            if (service != null)
            {
                var propertiesToExpand = service.GetType()
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.Name.StartsWith("Expand") && p.PropertyType == typeof(bool))
                    .Where(p => (bool)p.GetValue(service, null))
                    .Select(p => p.Name);

                foreach (var propertyName in propertiesToExpand)
                {
                    string expandPropertyName = propertyName.Substring("Expand".Length);
                    expandPropertyName = Regex.Replace(expandPropertyName, "([a-z])([A-Z])", "$1_$2").ToLower();

                    if (isListMethod)
                    {
                        expandPropertyName = "data." + expandPropertyName;
                    }

                    newUrl = ApplyParameterToUrl(newUrl, "expand[]", expandPropertyName);
                }
            }

            return newUrl;
        }

        public static string ApplyParameterToUrl(string url, string argument, string value)
        {
            var token = "&";

            if (!url.Contains("?"))
                token = "?";

            return string.Format("{0}{1}{2}={3}", url, token, argument, WebUtility.UrlEncode(value));
        }

        private static string ApplyNestedObjectProperties(string newUrl, object nestedObject)
        {
            foreach (var property in nestedObject.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
                var value = property.GetValue(nestedObject, null);
                if (value == null) continue;

                foreach (var attribute in property.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Cast<JsonPropertyAttribute>())
                {
                    if (attribute.PropertyName.ToLower().Contains("metadata"))
                        newUrl = ApplyMetadataParameters(newUrl, value);
                    else
                        newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName, value.ToString());
                }
            }

            return newUrl;
        }

        private static string ApplyMetadataParameters(string newUrl, object value)
        {
            var metadata = (Dictionary<string, string>)value;

            foreach (string key in metadata.Keys)
            {
                newUrl = ApplyParameterToUrl(newUrl, $"metadata[{key}]", metadata[key]);
            }

            return newUrl;
        }
    }
}
