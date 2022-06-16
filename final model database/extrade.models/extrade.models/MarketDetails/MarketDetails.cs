using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class MarketDetails
    {
     public int ProductID { get; set; }
        public int MarketID { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Market market { get; set; }

        public Product Product { get; set; }

    }
}
