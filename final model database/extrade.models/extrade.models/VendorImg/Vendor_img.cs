using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class VendorImg
    {
        public int ID { get; set; }
        public int IDVendorImg { get; set; }
        public string ImgWork { get; set; }
         public Vendor Vendor { get; set; }

    }
}
