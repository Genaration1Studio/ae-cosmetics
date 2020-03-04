using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AE_Cosmetics
{
    public partial class MSG_SaveOrder : Form
    {
        public MSG_SaveOrder()
        {
            InitializeComponent();
        }

        private void Btn_ok_Click(object sender, EventArgs e) //ปุ่มตกลง
        {
            Variable.createOrder = "two"; //กำหนดสถานะรายการสินค้าเป็นครั้งที่2
            Variable.saveStatus = "saved"; //กำหนดสถานะการบันทึกเป็นบันทึกแล้ว
            this.Close();  //ปิดฟอร์ม
        }
    }
}
