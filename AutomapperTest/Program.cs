using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomapperTest.Order;

namespace AutomapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<decimal, string>()
                    .ConvertUsing<DecimalToStringConverter>();
                cfg.CreateMap<Order, OrderViewModel>()
                    //.ForMember(dest => dest.Cost, opt => opt.MapFrom(src => $"{src.Cost} zł"))
                    .ReverseMap();

                cfg.CreateMap<Enum, string>()
                    .ConvertUsing<EnumToStringConverter>();
            });

            

            var mapper = config.CreateMapper();

            var order = new Order()
            {
                Id = 10,
                Number = "2324",
                Cost = 21.20M,
                Status = OrderStatus.Processed
            };

            var viewModel = mapper.Map<OrderViewModel>(order);

        }
    }
}
