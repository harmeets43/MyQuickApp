using DataAccessLayer.Repositories.Interfaces;

namespace DataAccessLayer
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers {get;}
        IProductRepository Products { get; }
        IOrdersRepository Orders { get;}

        int SaveChanges();
    }
}