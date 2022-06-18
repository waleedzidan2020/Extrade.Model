using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class ClientPhone
    {
       public int ID { get; set; }
        public int ClientID { get; set; }
        public int Number { get; set; }
     public  MarkterClient MarkterClient { get; set; }
    }
}
