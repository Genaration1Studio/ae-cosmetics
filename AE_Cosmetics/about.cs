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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e) //ปุ่มปิดฟอร์ม
        {
            this.Close(); //ปิดฟอร์ม
        }

        private void pic_next_Click(object sender, EventArgs e) //ปุ่มถัดไป
        {
            lbl_name.Text = "นางสาวสุพรรณี สะอาดดี";                 /***** แสดงข้อมูลผู้จัดืทำคนที่ 2 ******/
            lbl_id.Text = "รหัสประจำตัวนักศึกษา 6132040074 กลุ่ม E.5"; 
            pic_profile.Image = Properties.Resources.profile_2; /******************************/
            pic_next.Image = Properties.Resources.more_than_soft_512px; //กำหนดให้ปุ่มถัดไปจาง
            pic_prev.Image = Properties.Resources.last_than_512px; //กำหนดให้ปุ่มก่อนหน้าเข้ม
            pic_prev.Enabled = true; //กำหนดให้ปุ่มก่อนหน้าทำงานได้
            pic_next.Enabled = false; //กำหนดให้ปุ่มถัดไปทำงานไม่ได้
        }

        private void pic_prev_Click(object sender, EventArgs e) //ปุ่มก่อนหน้า
        {
            lbl_name.Text = "นางสาวอัมพร สุขประเสริฐ";                /***** แสดงข้อมูลผู้จัดืทำคนที่ 1 ******/
            lbl_id.Text = "รหัสประจำตัวนักศึกษา 6132040073 กลุ่ม E.5";
            pic_profile.Image = Properties.Resources.profile_1; /******************************/
            pic_next.Image = Properties.Resources.more_than_512px; //กำหนดให้ปุ่มถัดไปเข้ม
            pic_prev.Image = Properties.Resources.last_than_soft_512px; //กำหนดให้ปุ่มก่อนหน้าจาง
            pic_prev.Enabled = false; //กำหนดให้ปุ่มก่อนหน้าทำงานไม่ได้
            pic_next.Enabled = true; //กำหนดให้ปุ่มถัดไปทำงานได้
        }
    }
}
