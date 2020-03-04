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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e) //ปุ่มปิดฟอร์ม
        {
            this.Close(); //ปิดฟอร์มหน้านี้
        }

        private void Btn_mini_Click(object sender, EventArgs e) //ปุ่มย่อขนาดฟอร์ม
        {
            this.WindowState = FormWindowState.Minimized; //ย่อขนาดฟอร์มลง
        }
        
        private void Btn_purchase_Click(object sender, EventArgs e) //ปุ่มจัดซื้อ
        {
            Variable.createOrder = "first";  //กำหนดให้ตัวแปร createOeder เท่ากับ first 
            Purchase_Oder purchase = new Purchase_Oder(); //สร้างออปเจค purchase
            purchase.ShowDialog(); //เปิดหน้าฟอร์มจัดซื้อ
        }

        private void Btn_update_Click(object sender, EventArgs e) //ปุ่มจัดการคลังสินค้า
        {
            Update update = new Update();  //สร้างออปเจค update
            update.ShowDialog(); //เปิดหน้าฟอร์มคลังสินค้า
        }

        private void Btn_search_Click(object sender, EventArgs e) //ปุ่มค้นหาสินค้า
        {
            Search search = new Search();   //สร้างออปเจค search
            search.ShowDialog(); //เปิดหน้าฟอร์มค้นหาสินค้า
        }

        private void btn_aboutMe_Click(object sender, EventArgs e) //ปุ่มข้อมูลผู้จัดทำ
        {
            about about = new about();  //สร้างออปเจค about
            about.ShowDialog(); //เปิดหน้าฟอร์มผู้จัดทำ
        }
    }
}
