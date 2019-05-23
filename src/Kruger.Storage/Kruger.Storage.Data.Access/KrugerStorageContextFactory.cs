using Kruger.Storage.Data.Access.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kruger.Storage.Data.Access
{
    class KrugerStorageContextFactory
    {
        public KrugerStorageContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            return new KrugerStorageContext(new DbContextOptionsBuilder<KrugerStorageContext>().Options, config);
        }
    }
}
