namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreditNoteService : Service<CreditNote>,
        ICreatable<CreditNote, CreditNoteCreateOptions>,
        IListable<CreditNote, CreditNoteListOptions>,
        IRetrievable<CreditNote, CreditNoteGetOptions>,
        IUpdatable<CreditNote, CreditNoteUpdateOptions>
    {
        public CreditNoteService()
            : base(null)
        {
        }

        public CreditNoteService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/credit_notes";

        public virtual CreditNote Create(CreditNoteCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<CreditNote> CreateAsync(CreditNoteCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual CreditNote Get(string creditNoteId, CreditNoteGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(creditNoteId, options, requestOptions);
        }

        public virtual Task<CreditNote> GetAsync(string creditNoteId, CreditNoteGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(creditNoteId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CreditNote> List(CreditNoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<CreditNote>> ListAsync(CreditNoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditNote> ListAutoPaging(CreditNoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual StripeList<CreditNoteLineItem> ListLineItems(string creditnoteId, CreditNoteListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditNoteLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(creditnoteId)}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<CreditNoteLineItem>> ListLineItemsAsync(string creditnoteId, CreditNoteListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditNoteLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(creditnoteId)}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditNoteLineItem> ListLineItemsAutoPaging(string creditnoteId, CreditNoteListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditNoteLineItem>($"{this.InstanceUrl(creditnoteId)}/lines", options, requestOptions);
        }

        public virtual StripeList<CreditNoteLineItem> ListPreviewLineItems(CreditNoteListPreviewLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditNoteLineItem>>(HttpMethod.Get, $"{this.InstanceUrl("preview")}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<CreditNoteLineItem>> ListPreviewLineItemsAsync(CreditNoteListPreviewLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditNoteLineItem>>(HttpMethod.Get, $"{this.InstanceUrl("preview")}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CreditNoteLineItem> ListPreviewLineItemsAutoPaging(CreditNoteListPreviewLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditNoteLineItem>($"{this.InstanceUrl("preview")}/lines", options, requestOptions);
        }

        public virtual CreditNote Preview(CreditNotePreviewOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Get, $"{this.ClassUrl()}/preview", options, requestOptions);
        }

        public virtual Task<CreditNote> PreviewAsync(CreditNotePreviewOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Get, $"{this.ClassUrl()}/preview", options, requestOptions, cancellationToken);
        }

        public virtual CreditNote Update(string creditNoteId, CreditNoteUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(creditNoteId, options, requestOptions);
        }

        public virtual Task<CreditNote> UpdateAsync(string creditNoteId, CreditNoteUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(creditNoteId, options, requestOptions, cancellationToken);
        }

        public virtual CreditNote VoidCreditNote(string creditNoteId, CreditNoteVoidOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(creditNoteId)}/void", options, requestOptions);
        }

        public virtual Task<CreditNote> VoidCreditNoteAsync(string creditNoteId, CreditNoteVoidOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(creditNoteId)}/void", options, requestOptions, cancellationToken);
        }
    }
}
