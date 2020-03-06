namespace Stripe.Radar
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class EarlyFraudWarningService : Service<EarlyFraudWarning>,
        IListable<EarlyFraudWarning, EarlyFraudWarningListOptions>,
        IRetrievable<EarlyFraudWarning, EarlyFraudWarningGetOptions>
    {
        public EarlyFraudWarningService()
            : base(null)
        {
        }

        public EarlyFraudWarningService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/radar/early_fraud_warnings";

        public virtual EarlyFraudWarning Get(string earlyFraudWarningId, EarlyFraudWarningGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(earlyFraudWarningId, options, requestOptions);
        }

        public virtual Task<EarlyFraudWarning> GetAsync(string earlyFraudWarningId, EarlyFraudWarningGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(earlyFraudWarningId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<EarlyFraudWarning> List(EarlyFraudWarningListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<EarlyFraudWarning>> ListAsync(EarlyFraudWarningListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<EarlyFraudWarning> ListAutoPaging(EarlyFraudWarningListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
