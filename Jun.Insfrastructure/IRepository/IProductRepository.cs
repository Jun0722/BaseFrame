using Jun.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jun.Insfrastructure.IRepository
{
    public interface IProductRepository:IBaseRepository<Product>
    {
        Product GetProduct(int Id);

    }
}
