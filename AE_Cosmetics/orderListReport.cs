using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE_Cosmetics
{
    public class orderListReport
    {
        public string productName { get; set; }
        public string quantity { get; set; }
        public string amount { get; set; }

        public orderListReport(string productName, string quantity, string amount)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.amount = amount;
        }
    }
}
