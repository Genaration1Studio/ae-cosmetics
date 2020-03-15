using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            txb_passsWord.PasswordChar = '●';
            lbl_notFound.Visible = false;
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.aeCosmeticsDataSet.user);
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

        private void btn_report_Click(object sender, EventArgs e)
        {
            Report report = new Report();  //สร้างออปเจค
            report.ShowDialog(); //เปิดหน้าฟอร์ม
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (Variable.userType.Equals("admin"))
            {
                btn_update.Visible = false;
                btn_search.Visible = false;
                btn_report.Visible = false;
                btn_aboutMe.Visible = false;
                btn_logout.Visible = false;
            }
            else
            {
                btn_purchase.Visible = false;
                btn_aboutMe.Visible = false;
                btn_logout.Visible = false;
            }

            Variable.userType = "";
            Variable.firstName = "";
            Variable.lastName = "";
            lbl_username.Visible = true;
            lbl_password.Visible = true;
            lbl_notFound.Visible = false;
            txb_username.Visible = true;
            txb_password.Visible = true;
            txb_passsWord.Visible = true;
            txb_passsWord.Text = "";
            txb_username.Text = "";
            txb_password.Text = "";
            txb_username.Focus();
            btn_login.Visible = true;
            card_logo.Size = new System.Drawing.Size(1151, 440);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                var query = from result in this.aeCosmeticsDataSet.user                          /*****  *******/
                            where result.username.ToString().Equals(txb_username.Text.Trim()) &&
                                  result.password.Equals(txb_passsWord.Text.Trim())
                            select result;                                                         /***********************************/
                if (query.ToList().Count() > 0) //
                {
                    Variable.userType = query.ToList().ElementAt(0).userType;
                    Variable.firstName = query.ToList().ElementAt(0).firstName;
                    Variable.lastName = query.ToList().ElementAt(0).lastName;
                    lbl_username.Visible = false;
                    lbl_password.Visible = false;
                    lbl_notFound.Visible = false;
                    txb_username.Visible = false;
                    txb_password.Visible = false;
                    txb_passsWord.Visible = false;
                    btn_login.Visible = false;
                    card_logo.Size = new System.Drawing.Size(627, 440);

                    if (Variable.userType.Equals("admin"))
                    {
                        btn_update.Location = new System.Drawing.Point(897, 217);
                        btn_search.Location = new System.Drawing.Point(897, 303);
                        btn_report.Location = new System.Drawing.Point(897, 394);
                        btn_aboutMe.Location = new System.Drawing.Point(897, 485);
                        btn_logout.Location = new System.Drawing.Point(897, 573);

                        btn_update.Visible = true;
                        btn_search.Visible = true;
                        btn_report.Visible = true;
                        btn_aboutMe.Visible = true;
                        btn_logout.Visible = true;
                    }
                    else
                    {
                        btn_purchase.Location = new System.Drawing.Point(897, 217);
                        btn_aboutMe.Location = new System.Drawing.Point(897, 325);
                        btn_logout.Location = new System.Drawing.Point(897, 431);

                        btn_purchase.Visible = true;
                        btn_aboutMe.Visible = true;
                        btn_logout.Visible = true;
                    }
                }
                else
                {
                    lbl_notFound.Visible = true;
                    txb_passsWord.Text = "";
                    txb_username.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }
        }

        private void txb_passsWord_Click(object sender, EventArgs e)
        {
            lbl_notFound.Visible = false;
        }
    }
}
