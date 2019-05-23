using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kruger.Storage.Data.Access.Entities;
using Kruger.Storage.Models;
using AutoMapper;

namespace Kruger.Storage.Controllers
{
    public class StorageOrdersController : Controller
    {
        private readonly KrugerStorageContext _context;
        private readonly IMapper _mapper;

        public StorageOrdersController(KrugerStorageContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: StorageOrders
        public async Task<IActionResult> Index(int customerId)
        {
            var krugerStorageContext = _context.StorageOrder.Include(s => s.Product).Include(s => s.Rack);
            return View(await krugerStorageContext.ToListAsync());
        }

        // GET: StorageOrders/Create
        public IActionResult Create(int customerId)
        {
            ViewData["CustomerId"] = customerId;
            var productsByCustomer = new SelectList(_context.Product.Where(p => p.CustomerId == customerId), "ProductId", "Description").ToList();
            productsByCustomer.Insert(0, new SelectListItem { Text = "Seleccione", Value = "0" });
            ViewData["ProductId"] = productsByCustomer;

            return View();
        }

        // POST: StorageOrders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,ProductId,RackId,OrderQty,ColumnNumber,RowNumber,EntryDate,DiscontinuedDate")] StorageOrderCreateViewModel storageOrderViewModel)
        {
            if (ModelState.IsValid)
            {
                var storageOrder = _mapper.Map<StorageOrder>(storageOrderViewModel);
                _context.Add(storageOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), "Customers");
            }

            return RedirectToAction(nameof(Index), "Customers");
        }

        [HttpGet]
        public JsonResult GetStoragesByProductId(int productId)
        {
            var productCategoryId = _context.Product.SingleOrDefault(p => p.ProductId == productId).ProductCategoryId;
            var storages = new SelectList(_context.Storage.Where(c => c.ProductCategoryId == productCategoryId), "StorageId", "StorageId");
            return Json(storages);
        }

        [HttpGet]
        public JsonResult GetRacksByStorageId(int storageId)
        {
            var racks = new SelectList(_context.Rack.Where(c => c.StorageId == storageId), "RackId", "Description");
            return Json(racks);
        }
    }
}
