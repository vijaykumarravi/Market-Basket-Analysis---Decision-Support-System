using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class variables
    {
        public string product_1, product_2, product_3;
        public float price_1, price_2, price_3;
        public float total, discount;
        public string premise, conclusion;
        public TimeSpan time_stamp;
        public Int64 counter;
        public Int64 id;
        public string tablename;
        public float nett;
        public variables()
            
        {
            price_1 = price_2 = price_3 = 0;
            product_1 = product_2 = product_3 = null;
            premise = conclusion = null;
            counter = 0;
            total = discount = 0;
            nett = 0;
        }
    }
}
