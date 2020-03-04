using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE_Cosmetics
{
    class orderList
    {
        public string productID { get; set; }             /********* ประกาศตัวแปรที่ใช้เก็บข้อมูลสินค้า **********/
        public string productName { get; set; }
        public string size { get; set; }
        public int unitPrice { get; set; }
        public int quantity { get; set; }
        public Double amount { get; set; }               /*******************************************/
    }
}
