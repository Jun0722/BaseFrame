using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jun.Domain.Models;
using Jun.Insfrastructure.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jun.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productRepository.GetAllAsyn();
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Product> Get(int id)
        {
            return await _productRepository.GetAsync(id);
        }

        // POST: api/Product
        [HttpPost]
        public async Task<Product> Add([FromBody] Product entity)
        {
            await _productRepository.AddAsyn(entity);
            await _productRepository.SaveAsync();
            return entity;
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public async Task<Product> Update(int id, [FromBody] Product entity)
        {
            var updated = await _productRepository.UpdateAsyn(entity, id);
            return updated;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            _productRepository.Delete(_productRepository.Get(id));
            return "Sucessfully";
        }
        protected override void Dispose(bool disposing)
        {
            _productRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
