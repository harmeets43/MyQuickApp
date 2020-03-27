using System.Collections.Generic;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface ICustomerRepository: IBaseRepository<Customer>
    {
        IEnumerable<Customer> GetTopActiveCustomers(int count);
        IEnumerable<Customer> GetAllCustomersData();
    }
}