using AutoMapper;
using Kruger.Storage.Data.Access.Entities;
using Kruger.Storage.Data.Model;
using Kruger.Storage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kruger.Storage.Data
{
    public class StorageOrderProfile : Profile
    {
        public StorageOrderProfile()
        {
            this.CreateMap<StorageOrder, StorageOrderCreateViewModel>().ForMember(x => x.StorageId, opt => opt.Ignore());

            this.CreateMap<StorageOrderCreateViewModel, StorageOrder>()
                .ForMember(x => x.Rack, opt => opt.Ignore())
                .ForMember(x => x.Product, opt => opt.Ignore())
                .ForMember(x => x.StorageOrderId, opt => opt.Ignore());

            this.CreateMap<StorageOrderModel, ProductsComingToExpireViewModel>();
        }
    }
}
