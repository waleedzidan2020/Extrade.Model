using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace extrade.models
{
    public class Driver
    {
        public int ID { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }
        public List<PhoneDriver> PhoneDriver { get; set; }
        public List<Order> Order { get; set; }

    }
}
