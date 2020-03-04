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
    public partial class MSG_SaveProduct : Form
    {
        public MSG_SaveProduct()
        {
            InitializeComponent();
        }

        private void Btn_ok_Click(object sender, EventArgs e) //ปุ่มตกลง
        {
            this.Close();  //ปิดฟอร์ม
        }
    }
}
