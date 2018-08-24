using System.Collections.Generic;

namespace DataApp.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
    }

    public class EFCustomerRepository : ICustomerRepository
    {
        private EFCustomerContext context;

        public EFCustomerRepository(EFCustomerContext context)
        {
            this.context = context;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return context.Customers;
        }
    }
}
