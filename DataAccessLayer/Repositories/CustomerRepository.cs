using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    internal class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {

        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Customer> GetAllCustomersData()
        {
            return _appContext.Customers
                .Include(c => c.Orders).ThenInclude(o => o.OrderDetails).ThenInclude(d => d.Product)
                .Include(c => c.Orders).ThenInclude(o => o.Cashier)
                .OrderBy(c => c.Name)
                .ToList();
        }

        public IEnumerable<Customer> GetTopActiveCustomers(int count)
        {
            throw new System.NotImplementedException();
        }
    }
}