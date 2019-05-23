using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kruger.Storage.Data.Access.Entities;
using AutoMapper;
using Kruger.Storage.Models;
using System.Net.Http;
using Kruger.Storage.Data.Model;

namespace Kruger.Storage.Controllers
{
    public class CustomersController : Controller
    {
        private readonly KrugerStorageContext _context;
        private readonly IMapper _mapper;

        public CustomersController(KrugerStorageContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Customers
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var customers = _context.Customer.Include(c => c.CustomerType);
            var results = await customers.ToListAsync();
            var viewModel = _mapper.Map<CustomerIndexViewModel[]>(results);
            return View(viewModel);
        }

        // GET: ProductsComingToExpireReport
        [HttpGet]
        public async Task<IActionResult> ProductsComingToExpireReport(int customerId, DateTime? date = null)
        {
            IEnumerable<ProductsComingToExpireViewModel> productsComingToExpireViewModel = null;

            if (!date.HasValue)
                date = DateTime.Now.AddDays(30);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:6600/api/");
                var responseTask = client.GetAsync($"customers/{customerId}/productsExpired/{date.Value.Date.ToString("MM-dd-yyyy")}");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var storageOrders = await result.Content.ReadAsAsync<IList<StorageOrderModel>>();
                    productsComingToExpireViewModel = _mapper.Map<ProductsComingToExpireViewModel[]>(storageOrders);
                }
                else
                {
                    //log response status here..
                    productsComingToExpireViewModel = Enumerable.Empty<ProductsComingToExpireViewModel>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(productsComingToExpireViewModel);
        }
    }
}
