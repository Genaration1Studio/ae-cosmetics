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
    public partial class Search : Form
    {
        private int count = 1; //ประกาศตัวแปรที่ใช้นับ % การค้นหา
        public Search()
        {
            InitializeComponent();
            txb_search2.Focus();  //ให้ cuursor ไปอยู่ที่ช่องค้นหา
        }

        private void Btn_exit_Click(object sender, EventArgs e) //ปุ่มปิดฟอร์ม
        {
            this.Close();  //ปิดฟอร์ม
        }

        private void Btn_mini_Click(object sender, EventArgs e) //ปุ่มย่อขนาดฟอร์ม
        {
            this.WindowState = FormWindowState.Minimized; //ย่อขนาดฟอร์มลง
        }


        private void Search_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.aeCosmeticsDataSet.product); //โหลดข้อมูลของตาราง product จากฐานข้อมูล
        }

        private void txb_search2_KeyUp(object sender, KeyEventArgs e) //ช่องค้นหาสินค้า
        {
            try
            {
                timer.Start(); //ตัวนับเวลาทำงาน
                if (string.IsNullOrEmpty(txb_search2.Text)) //ถ้าไม่ได้ค้นหาข้อมูล
                {
                    dtg_productList.DataSource = productBindingSource;                                                                        /******** แสดงข้อมูลสินค้าทั้งหมด **********/
                    pic_product.DataBindings.Clear();
                    pic_product.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "productImage", true)); /***********************************/
                }
                else //ถ้าค้นหาข้อมูล
                {
                    var query = from result in this.aeCosmeticsDataSet.product                          /***** ค้นหาสินค้าตามที่กรอกในช่องค้นหา *******/
                                where result.productID.ToString().Contains(txb_search2.Text) ||
                                      result.productName.Contains(txb_search2.Text) ||
                                      result.description.Contains(txb_search2.Text) ||
                                      result.size.Contains(txb_search2.Text) ||
                                      result.unitPrice.ToString().Contains(txb_search2.Text) ||
                                      result.inStock.ToString().Contains(txb_search2.Text)
                                select result;                                                         /***********************************/
                    dtg_productList.DataSource = query.ToList(); //แสดงสินค้าที่ค้นหา
                    pic_product.Image = null; //ล้างภาพสินค้า
                    pic_product.DataBindings.Clear(); 
                    if (query.ToList().Count() > 0) //ถ้าเจอสินค้า
                    {
                        pic_product.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dtg_productList.DataSource, "productImage", true)); //แสดงภาพสินค้าที่เจอ
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }   
        }

        private void timer_Tick(object sender, EventArgs e) //ตัวนับเวลา
        {
            if (count <= 100) //ถ้า count ยังไม่ครบ 100
            {
                progessSearch.Value = count; //กำหนด % การค้นหาเท่ากับ count
                count += 9; //เพิ่มค่า count ครั้งละ 9
            }
            else //ถ้า count ครบ 100
            {
                progessSearch.Value = 0; //กำหนด % การค้นหาเท่ากับ 0
                count = 1; //กำหนดค่า count เท่ากับ 1
                timer.Stop(); //หยุดนับการทำงานของตัวนับเวลา
            }
        }
    }
}
