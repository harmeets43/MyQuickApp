using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    internal class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;

        public ProductRepository(DbContext context) : base(context)
        {

        }
    }
}