using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class User
    {
        public int ID { get; set; }

        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Img { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }
        public List<Phone> Phone { get; set; }
        public Vendor Vendor { get; set; }
        public Markter Markter { get; set; }
        public MarkterClient MarkterClient { get; set;}
       public List<Order> Order { get; set; }
       public List<Rating> Rating { get; set; }
       public List<Favourite> Favourite { get; set; }
        public List<Cart> Cart { get; set; }









    }
}
