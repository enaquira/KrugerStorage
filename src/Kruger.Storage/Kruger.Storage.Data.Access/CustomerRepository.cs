using Kruger.Storage.Data.Access.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruger.Storage.Data.Access
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly KrugerStorageContext _context;
        private readonly ILogger<CustomerRepository> _logger;

        public CustomerRepository(KrugerStorageContext context, ILogger<CustomerRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add<T>(T entity) where T : class
        {
            _logger.LogInformation($"Adding an object of type {entity.GetType()} to the context.");
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _logger.LogInformation($"Removing an object of type {entity.GetType()} to the context.");
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            _logger.LogInformation($"Attempitng to save the changes in the context");

            // Only return success if at least one row was changed
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Customer[]> GetAllCustomers()
        {
            IQueryable<Customer> query = _context.Customer.AsQueryable();
            query = query.OrderBy(c => c.CustomerId);

            return await query.ToArrayAsync();
        }

        public async Task<StorageOrder[]> GetAllStorageOrderByExpirationDateAsync(int customerId, DateTime? dateTime = null)
        {
            _logger.LogInformation($"Getting all Camps");

            if (!dateTime.HasValue)
                dateTime = DateTime.Now.AddDays(30);

            var productsComingToExpire = await _context.StorageOrder.Where(x => x.Product.CustomerId == customerId
                                                && x.DiscontinuedDate <= dateTime.Value)
                                                .Include(s => s.Product)
                                                .Include(s => s.Rack).ToArrayAsync();

            return productsComingToExpire;
        }
    }
}
