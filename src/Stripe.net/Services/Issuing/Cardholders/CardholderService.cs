namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CardholderService : Service<Cardholder>,
        ICreatable<Cardholder, CardholderCreateOptions>,
        IListable<Cardholder, CardholderListOptions>,
        IRetrievable<Cardholder, CardholderGetOptions>,
        IUpdatable<Cardholder, CardholderUpdateOptions>
    {
        public CardholderService()
            : base(null)
        {
        }

        public CardholderService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/issuing/cardholders";

        public virtual Cardholder Create(CardholderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Cardholder> CreateAsync(CardholderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Cardholder Get(string cardholderId, CardholderGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(cardholderId, options, requestOptions);
        }

        public virtual Task<Cardholder> GetAsync(string cardholderId, CardholderGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(cardholderId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Cardholder> List(CardholderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Cardholder>> ListAsync(CardholderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Cardholder> ListAutoPaging(CardholderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Cardholder Update(string cardholderId, CardholderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(cardholderId, options, requestOptions);
        }

        public virtual Task<Cardholder> UpdateAsync(string cardholderId, CardholderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(cardholderId, options, requestOptions, cancellationToken);
        }
    }
}
