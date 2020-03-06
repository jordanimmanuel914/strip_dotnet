namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class InvoiceItemService : Service<InvoiceItem>,
        ICreatable<InvoiceItem, InvoiceItemCreateOptions>,
        IDeletable<InvoiceItem, InvoiceItemDeleteOptions>,
        IListable<InvoiceItem, InvoiceItemListOptions>,
        IRetrievable<InvoiceItem, InvoiceItemGetOptions>,
        IUpdatable<InvoiceItem, InvoiceItemUpdateOptions>
    {
        public InvoiceItemService()
            : base(null)
        {
        }

        public InvoiceItemService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/invoiceitems";

        public virtual InvoiceItem Create(InvoiceItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<InvoiceItem> CreateAsync(InvoiceItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual InvoiceItem Delete(string invoiceitemId, InvoiceItemDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(invoiceitemId, options, requestOptions);
        }

        public virtual Task<InvoiceItem> DeleteAsync(string invoiceitemId, InvoiceItemDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(invoiceitemId, options, requestOptions, cancellationToken);
        }

        public virtual InvoiceItem Get(string invoiceitemId, InvoiceItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(invoiceitemId, options, requestOptions);
        }

        public virtual Task<InvoiceItem> GetAsync(string invoiceitemId, InvoiceItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(invoiceitemId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<InvoiceItem> List(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceItem>> ListAsync(InvoiceItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceItem> ListAutoPaging(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual InvoiceItem Update(string invoiceitemId, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(invoiceitemId, options, requestOptions);
        }

        public virtual Task<InvoiceItem> UpdateAsync(string invoiceitemId, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(invoiceitemId, options, requestOptions, cancellationToken);
        }
    }
}
