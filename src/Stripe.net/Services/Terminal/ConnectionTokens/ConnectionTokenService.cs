namespace Stripe.Terminal
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ConnectionTokenService : Service<ConnectionToken>,
        ICreatable<ConnectionToken, ConnectionTokenCreateOptions>
    {
        public ConnectionTokenService()
            : base(null)
        {
        }

        public ConnectionTokenService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/terminal/connection_tokens";

        public virtual ConnectionToken Create(ConnectionTokenCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ConnectionToken> CreateAsync(ConnectionTokenCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
    }
}
