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
    public partial class MSG_CCDelete : Form
    {
        public MSG_CCDelete()
        {
            InitializeComponent();
        }

        private void Btn_ok_Click(object sender, EventArgs e) //ปุ่มตกลง
        {
            Variable.ccDelectStatus = "Yes"; //กำหนดสถานะการยืนยันการลบสินค้าเป็น Yes
            this.Close(); //ปิดฟอร์ม
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e) //ปุ่มยกเลิก
        {
            Variable.ccDelectStatus = "No";  //กำหนดสถานะการยืนยันการลบสินค้าเป็น No
            this.Close();  //ปิดฟอร์ม
        }
    }
}
