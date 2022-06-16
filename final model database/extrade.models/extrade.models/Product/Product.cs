using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class Product
    {
        public int ID{ get; set; }
        public string ProductnameEn{ get; set; }
        public string productnameAr { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string ProductDescription { get; set; }
        public int CategeroyID { get; set; }
        public int VendorID{ get; set; }
        public bool IsDeleted { get; set; }

        public Category Category { get; set; }
        public   Vendor Vendor { get; set; }
        public DateTime ModifiedDate { get; set; }

        public List<MarketDetails> MarketDetails { get; set; }
        public List<order_details> order_Details { get; set; }
       public List<Rating> Rating { get; set; }
       public List<Favourite> Favourite { get; set; }
        public List<Cart> Cart { get; set; }





    }
}
