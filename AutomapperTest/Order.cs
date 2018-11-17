using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperTest
{
    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal Cost { get; set; }

        public OrderStatus Status { get; set; }

        [EnumDescription(typeof(OrderStatusResources))]
        public enum OrderStatus
        {
            Created,
            Processed
        }
       
    }
}
