namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CapabilityService : ServiceNested<Capability>,
        INestedListable<Capability, CapabilityListOptions>,
        INestedRetrievable<Capability>,
        INestedUpdatable<Capability, CapabilityUpdateOptions>
    {
        public CapabilityService()
            : base(null)
        {
        }

        public CapabilityService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/accounts/{PARENT_ID}/capabilities";

        public bool ExpandAccount { get; set; }

        public virtual Capability Get(string accountId, string capabilityId, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(accountId, capabilityId, null, requestOptions);
        }

        public virtual Task<Capability> GetAsync(string accountId, string capabilityId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetNestedEntityAsync(accountId, capabilityId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Capability> List(string accountId, CapabilityListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(accountId, options, requestOptions);
        }

        public virtual Task<StripeList<Capability>> ListAsync(string accountId, CapabilityListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListNestedEntitiesAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Capability> ListAutoPaging(string accountId, CapabilityListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(accountId, options, requestOptions);
        }

        public virtual Capability Update(string accountId,  string capabilityId, CapabilityUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(accountId, capabilityId, options, requestOptions);
        }

        public virtual Task<Capability> UpdateAsync(string accountId,  string capabilityId, CapabilityUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateNestedEntityAsync(accountId, capabilityId, options, requestOptions, cancellationToken);
        }
    }
}
