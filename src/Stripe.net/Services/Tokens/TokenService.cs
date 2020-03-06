namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TokenService : Service<Token>,
        ICreatable<Token, TokenCreateOptions>,
        IRetrievable<Token, TokenGetOptions>
    {
        public TokenService()
            : base(null)
        {
        }

        public TokenService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/tokens";

        public virtual Token Create(TokenCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Token> CreateAsync(TokenCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Token Get(string tokenId, TokenGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(tokenId, options, requestOptions);
        }

        public virtual Task<Token> GetAsync(string tokenId, TokenGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(tokenId, options, requestOptions, cancellationToken);
        }
    }
}
