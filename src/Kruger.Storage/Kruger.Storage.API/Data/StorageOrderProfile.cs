using AutoMapper;
using Kruger.Storage.Data.Access.Entities;
using Kruger.Storage.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kruger.Storage.API.Data
{
    public class StorageOrderProfile : Profile
    {
        public StorageOrderProfile()
        {
            this.CreateMap<StorageOrder, StorageOrderModel>()
                .ForMember(x => x.ProductName, opt => opt.MapFrom(x => x.Product.Description))
                .ForMember(x => x.StorageId, opt => opt.MapFrom(x => x.Rack.StorageId))
                .ForMember(x => x.RackName, opt => opt.MapFrom(x => x.Rack.Description))
                .ForMember(x => x.Row, opt => opt.MapFrom(x => x.RowNumber))
                .ForMember(x => x.Column, opt => opt.MapFrom(x => x.ColumnNumber))
                .ForMember(x => x.DiscontinuedDate, opt => opt.MapFrom(x => x.DiscontinuedDate));
        }
    }
}
