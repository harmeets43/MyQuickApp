using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    internal class OrdersRepository : BaseRepository<Order>, IOrdersRepository 
    {
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
        public OrdersRepository(DbContext context) : base(context)
        { }
    }
}