using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class order_details
    {
        public int ID { get; set; }
        public int  OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }


    }
}
