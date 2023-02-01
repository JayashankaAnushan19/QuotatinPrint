using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuotatinPrint
{
    public  class Receipt
    {
        public string ID { get; set; }
        public char ItemName { get; set;}
        public char Model { get; set; }
        public double  UnitPrice { get; set; }
        public int Qty { get; set; }
        public string  Amount { get { return string.Format("Rs{0}", UnitPrice * Qty); } }
    
    }
}
