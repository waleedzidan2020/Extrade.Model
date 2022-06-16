using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class Market
    {
        public int ID { get; set; }
        public int MarkterID { get; set; }
        public string ? NameAr  { get; set; }
        public string ? NameEN { get; set; }
        public int Code { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Markter Markter { get; set; }

        public List<MarketDetails> MarketDetails { get; set; }

}
}
