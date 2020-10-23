using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public ActionResult<List<Product>> Get() => _repository.GetAll().ToList();

        [HttpGet("{id}")]

        public ActionResult<Product> Get(int id) => _repository.GetById(id);

        [HttpGet("validProducts")]

        public ActionResult<List<Product>> GetValid()
        {
            return _repository.GetAll().Where(p=> p.ValidTo > DateTime.Now).ToList();
        }

        [HttpGet("totalPrice")]

        public ActionResult<double> GetPrice()
        {
            return _repository.GetAll().ToList().Sum(p => p.Price);
        }

        [HttpGet("totalPrice")]

        public ActionResult<double> GetPriceOfValid()
        {
            return _repository.GetAll().ToList().Where(p=> p.ValidTo > DateTime.Now).Sum(p => p.Price);
        }
    }
}
