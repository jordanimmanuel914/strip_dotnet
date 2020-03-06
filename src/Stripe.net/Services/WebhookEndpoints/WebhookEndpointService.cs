namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class WebhookEndpointService : Service<WebhookEndpoint>,
        ICreatable<WebhookEndpoint, WebhookEndpointCreateOptions>,
        IDeletable<WebhookEndpoint, WebhookEndpointDeleteOptions>,
        IListable<WebhookEndpoint, WebhookEndpointListOptions>,
        IRetrievable<WebhookEndpoint, WebhookEndpointGetOptions>,
        IUpdatable<WebhookEndpoint, WebhookEndpointUpdateOptions>
    {
        public WebhookEndpointService()
            : base(null)
        {
        }

        public WebhookEndpointService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/webhook_endpoints";

        public virtual WebhookEndpoint Create(WebhookEndpointCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<WebhookEndpoint> CreateAsync(WebhookEndpointCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual WebhookEndpoint Delete(string endpointId, WebhookEndpointDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(endpointId, options, requestOptions);
        }

        public virtual Task<WebhookEndpoint> DeleteAsync(string endpointId, WebhookEndpointDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(endpointId, options, requestOptions, cancellationToken);
        }

        public virtual WebhookEndpoint Get(string endpointId, WebhookEndpointGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(endpointId, options, requestOptions);
        }

        public virtual Task<WebhookEndpoint> GetAsync(string endpointId, WebhookEndpointGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(endpointId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<WebhookEndpoint> List(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<WebhookEndpoint>> ListAsync(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<WebhookEndpoint> ListAutoPaging(WebhookEndpointListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual WebhookEndpoint Update(string endpointId, WebhookEndpointUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(endpointId, options, requestOptions);
        }

        public virtual Task<WebhookEndpoint> UpdateAsync(string endpointId, WebhookEndpointUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(endpointId, options, requestOptions, cancellationToken);
        }
    }
}
