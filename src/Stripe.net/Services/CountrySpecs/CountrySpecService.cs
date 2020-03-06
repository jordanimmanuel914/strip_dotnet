namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CountrySpecService : Service<CountrySpec>,
        IListable<CountrySpec, CountrySpecListOptions>,
        IRetrievable<CountrySpec, CountrySpecGetOptions>
    {
        public CountrySpecService()
            : base(null)
        {
        }

        public CountrySpecService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/country_specs";

        public virtual CountrySpec Get(string country, CountrySpecGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(country, options, requestOptions);
        }

        public virtual Task<CountrySpec> GetAsync(string country, CountrySpecGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(country, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CountrySpec> List(CountrySpecListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<CountrySpec>> ListAsync(CountrySpecListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CountrySpec> ListAutoPaging(CountrySpecListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
