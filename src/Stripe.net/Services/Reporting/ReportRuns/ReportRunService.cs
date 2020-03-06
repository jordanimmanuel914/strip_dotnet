namespace Stripe.Reporting
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReportRunService : Service<ReportRun>,
        ICreatable<ReportRun, ReportRunCreateOptions>,
        IListable<ReportRun, ReportRunListOptions>,
        IRetrievable<ReportRun, ReportRunGetOptions>
    {
        public ReportRunService()
            : base(null)
        {
        }

        public ReportRunService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/reporting/report_runs";

        public virtual ReportRun Create(ReportRunCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ReportRun> CreateAsync(ReportRunCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual ReportRun Get(string reportRunId, ReportRunGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(reportRunId, options, requestOptions);
        }

        public virtual Task<ReportRun> GetAsync(string reportRunId, ReportRunGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(reportRunId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ReportRun> List(ReportRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ReportRun>> ListAsync(ReportRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ReportRun> ListAutoPaging(ReportRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
