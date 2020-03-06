namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerService : Service<Customer>,
        ICreatable<Customer, CustomerCreateOptions>,
        IDeletable<Customer, CustomerDeleteOptions>,
        IListable<Customer, CustomerListOptions>,
        IRetrievable<Customer, CustomerGetOptions>,
        IUpdatable<Customer, CustomerUpdateOptions>
    {
        public CustomerService()
            : base(null)
        {
        }

        public CustomerService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/customers";

        public virtual Customer Create(CustomerCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Customer> CreateAsync(CustomerCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Customer Delete(string customerId, CustomerDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(customerId, options, requestOptions);
        }

        public virtual Task<Customer> DeleteAsync(string customerId, CustomerDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual Customer Get(string customerId, CustomerGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(customerId, options, requestOptions);
        }

        public virtual Task<Customer> GetAsync(string customerId, CustomerGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Customer> List(CustomerListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Customer>> ListAsync(CustomerListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Customer> ListAutoPaging(CustomerListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Customer Update(string customerId, CustomerUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(customerId, options, requestOptions);
        }

        public virtual Task<Customer> UpdateAsync(string customerId, CustomerUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(customerId, options, requestOptions, cancellationToken);
        }
    }
}
