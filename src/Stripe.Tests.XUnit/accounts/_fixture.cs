﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace Stripe.Tests.Xunit
{
    public class account_fixture : IDisposable
    {
        public StripeAccountCreateOptions AccountCreateOptions { get; }
        public StripeAccountUpdateOptions AccountUpdateOptions { get; }

        public StripeAccount Account { get; }
        public StripeAccount AccountUpdated { get; }
        public StripeAccount AccountRetrieved { get; }
        public StripeList<StripeAccount> AccountList { get; }
        public StripeAccount AccountRejected { get; }

        public account_fixture()
        {
            // create a file to attach to the additional owner as a verification document
            var fileService = new StripeFileUploadService(Cache.ApiKey);
            var additionalOwnerFileStream = GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.Tests.XUnit._resources.bumble.jpg");
            var additionalOwnerFileStreamBack = GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.Tests.XUnit._resources.bumble.jpg");
            var verificationFileStream = GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.Tests.XUnit._resources.bumble.jpg");
            var verificationFileStreamBack = GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.Tests.XUnit._resources.bumble.jpg");

            var additionalOwnerFile = fileService.Create("bumble.jpg", additionalOwnerFileStream, StripeFilePurpose.IdentityDocument);
            var additionalOwnerFileBack = fileService.Create("bumble_back.jpg", additionalOwnerFileStreamBack, StripeFilePurpose.IdentityDocument);
            var verificationOwnerFile = fileService.Create("bumble.jpg", verificationFileStream, StripeFilePurpose.IdentityDocument);
            var verificationOwnerFileBack = fileService.Create("bumble_back.jpg", verificationFileStreamBack, StripeFilePurpose.IdentityDocument);

            AccountCreateOptions = new StripeAccountCreateOptions
            {
                BusinessName = "Subtracts",
                BusinessPrimaryColor = "#" + new Random().Next(0, 6).ToString("D6"),
                BusinessUrl = "http://subtracts.io",
                DebitNegativeBalances = true,
                DeclineChargeOnAvsFailure = false,
                DeclineChargeOnCvcFailure = true,
                DefaultCurrency = "usd",
                Email = "caesar@turing.dpn",
                Type = StripeAccountType.Custom,
                ExternalCardAccount = new StripeAccountCardOptions()
                {
                    TokenId = "tok_visa_debit"
                },
                LegalEntity = new StripeAccountLegalEntityOptions
                {
                    AdditionalOwners = new List<StripeAccountAdditionalOwner>
                    {
                        new StripeAccountAdditionalOwner
                        {
                            FirstName = "Bumble", LastName = "B",
                            // Ensure the owner is older than 18 to avoid API issues.
                            BirthDay = 29, BirthMonth = 8, BirthYear = 1980,
                            VerificationDocument = additionalOwnerFile.Id,
                            VerificationDocumentBack = additionalOwnerFileBack.Id
                        },
                        new StripeAccountAdditionalOwner
                        {
                            FirstName = "Trouble", LastName = "China",
                            State = "CA", CityOrTown = "RockAndWheat",
                            Line1 ="B", Line2 = "C", PostalCode = "27635",
                            Country = "US"
                        }
                    },
                    VerificationDocumentFileId = verificationOwnerFile.Id,
                    VerificationDocumentFileBackId = verificationOwnerFileBack.Id
                }
            };

            AccountUpdateOptions = new StripeAccountUpdateOptions
            {
                BusinessUrl = "https://subtracts.io"
            };

            var _rejectOptions = new StripeAccountRejectOptions
            {
                Reason = "terms_of_service"
            };

            var service = new StripeAccountService(Cache.ApiKey);
            Account = service.Create(AccountCreateOptions);
            AccountUpdated = service.Update(Account.Id, AccountUpdateOptions);
            AccountRetrieved = service.Get(Account.Id);
            AccountList = service.List();
            AccountRejected = service.Reject(Account.Id, _rejectOptions);
        }

        public void Dispose()
        {
            new StripeAccountService(Cache.ApiKey).Delete(Account.Id);
        }
    }
}
