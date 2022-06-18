using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class VendorImage
    {
        public int ID { get; set; }
        public int VendorID { get; set; }
        public string Image { get; set; }
         public Vendor Vendor { get; set; }

    }
}
