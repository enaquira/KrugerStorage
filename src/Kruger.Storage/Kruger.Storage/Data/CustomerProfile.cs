using AutoMapper;
using Kruger.Storage.Data.Access.Entities;
using Kruger.Storage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kruger.Storage.Data
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            this.CreateMap<Customer, CustomerIndexViewModel>();
        }
    }
}
