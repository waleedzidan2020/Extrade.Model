using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class Order
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int DriverID { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = "Pending";
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; } 
        public User User { get; set; }
        public Driver Driver { get; set; }
        public List<order_details> order_Details { get; set;  }

        



    }
}
