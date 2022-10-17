using AutoMapper;
using kpz2.Models;
using kpz2.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz2.UI.Base
{
    public class Mapping
    {
        public void Create()
        {
            Mapper.CreateMap<DataModel, DataViewModel>();
            Mapper.CreateMap<DataViewModel, DataModel>();

            Mapper.CreateMap<Order, OrderViewModel>();
            Mapper.CreateMap<OrderViewModel, Order>();

            Mapper.CreateMap<Product,ProductViewModel>();
            Mapper.CreateMap<ProductViewModel, Product>();

        }
    }
}
