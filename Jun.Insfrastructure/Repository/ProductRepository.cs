using Jun.Domain.Models;
using Jun.Insfrastructure.Context;
using Jun.Insfrastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jun.Insfrastructure.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IsDbContext context):base(context)
        {

        }

        public Product GetProduct(int id)
        {
            return GetAll().FirstOrDefault(p => p.Id == id);
        }

        public async Task<Product> GetSingleAsyn(int id)
        {
            return await _context.Set<Product>().FindAsync(id);
        }

        public override Product Update(Product entity, int key)
        {
            Product exist = _context.Set<Product>().Find(key);
            if (exist != null)
            {
                entity.CreateDateTime = DateTime.Now;
            }
            return base.Update(entity, key);
        }

        public async override Task<Product> UpdateAsyn(Product entity, int key)
        {
            Product exist = await _context.Set<Product>().FindAsync(key);
            if (exist != null)
            {
                entity.CreateDateTime = DateTime.Now;
            }
            return await base.UpdateAsyn(entity, key);
        }
    }
}
