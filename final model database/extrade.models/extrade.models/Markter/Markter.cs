using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class Markter
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string TaxCard { get; set; }
        public float Salary { get; set; }
        public bool IsDeleted { get; set; }
        public User User { get; set; }
        public List<Market> Market { get; set; }
        public MarketDetails MarketDetails { get; set; }

    }
}
