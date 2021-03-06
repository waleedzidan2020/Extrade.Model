using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class Vendor
    {
     public   int VendorID { get; set; }
     public int UserID { get; set; }
     public string BrandNameAr{ get; set; }
     public string BrandNameEr { get; set; }
     public string IsDeleted { get; set; }
    public List<VendorImage> VendorImage{ get; set; }
    public User User { get; set; }
    public List<Product> Product { get; set; }
    }
}
