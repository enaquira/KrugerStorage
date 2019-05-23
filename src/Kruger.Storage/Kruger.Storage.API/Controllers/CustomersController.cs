using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Kruger.Storage.Data.Access;
using Kruger.Storage.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kruger.Storage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomersController(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/customers
        [HttpGet]
        public async Task<ActionResult<CustomerModel[]>> GetCustomers()
        {
            try
            {
                var results = await _repository.GetAllCustomers();

                if (!results.Any())
                {
                    return NotFound();
                }

                CustomerModel[] models = _mapper.Map<CustomerModel[]>(results);

                return Ok(models);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Database failure");
            }
        }

        // GET api/customers
        [HttpGet("{customerId}/productsExpired/{dateTime}")]
        public async Task<ActionResult<StorageOrderModel[]>> GetStorageOrdersByExpirationDate(int customerId, DateTime? datetime = null)
        {
            try
            {
                var results = await _repository.GetAllStorageOrderByExpirationDateAsync(customerId, datetime);

                if (!results.Any())
                {
                    return NotFound();
                }

                StorageOrderModel[] models = _mapper.Map<StorageOrderModel[]>(results);

                return Ok(models);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Database failure");
            }
        }
    }
}
