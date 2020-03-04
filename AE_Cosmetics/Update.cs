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
    public partial class Update : Form
    {
      
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.aeCosmeticsDataSet.product); //โหลดข้อมูลของตาราง product จากฐานข้อมูล
        }

        private void Btn_exit_Click(object sender, EventArgs e) //ปุ่มปิดฟอร์ม
        {
            this.Close(); //ปิดฟอร์ม
        }

        private void Btn_mini_Click(object sender, EventArgs e) //ปุ่มย่อขนาดฟอร์ม
        {
            this.WindowState = FormWindowState.Minimized; //ย่อขนาดฟอร์มลง
        }

        private void btn_add_Click(object sender, EventArgs e)//ปุ่มเพิ่มสินค้า
        {
            try
            {
                panel_productDetail.Enabled = true; //เปิด panel สินค้า
                btn_add.Enabled = false; //กำหนดให้ปุ่มเพิ่มสินค้าทำงานไม่ได้
                btn_update.Enabled = false; //กำหนดให้ปุ่มแก้ไขสินค้าทำงานไม่ได้
                btn_delete.Enabled = false; //กำหนดให้ปุ่มลบสินค้าทำงานไม่ได้
                btn_save.Enabled = true; //กำหนดให้ปุ่มบันทึกสินค้าทำงานไม่ได้
                btn_cancel.Enabled = true; //กำหนดให้ปุ่มยกเลิกทำงานไม่ได้
                txb_productName.Focus(); //ให้ cuursor ไปอยู่ที่ช่อง product Name

                this.aeCosmeticsDataSet.product.AddproductRow(this.aeCosmeticsDataSet.product.NewproductRow()); //สร้างสินค้าขึ้นมาใหม่ 
                productBindingSource.MoveLast();  //เลือกสินค้าที่สร้างขึ้นมาใหม่
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }
        }

        private void btn_update_Click(object sender, EventArgs e)//ปุ่มแก้ไขสินค้า
        {
            panel_productDetail.Enabled = true; //เปิด panel สินค้า
            btn_add.Enabled = false; //กำหนดให้ปุ่มเพิ่มสินค้าทำงานไม่ได้
            btn_update.Enabled = false; //กำหนดให้ปุ่มแก้ไขสินค้าทำงานไม่ได้
            btn_delete.Enabled = false; //กำหนดให้ปุ่มลบสินค้าทำงานไม่ได้
            btn_save.Enabled = true; //กำหนดให้ปุ่มบันทึกสินค้าทำงานไม่ได้
            btn_cancel.Enabled = true; //กำหนดให้ปุ่มยกเลิกทำงานไม่ได้
            txb_productName.Focus(); //ให้ cuursor ไปอยู่ที่ช่อง product Name
        }

        private void btn_delete_Click(object sender, EventArgs e) //ปุ่มลบสินค้า
        {
            MSG_CCDelete mSG_CCDelete = new MSG_CCDelete(); //สร้างออปเจค mSG_CCDelete
            mSG_CCDelete.ShowDialog(); //แสดงฟอร์มแจ้งเตือนยืนยันการลบสินค้า

            if (Variable.ccDelectStatus.Equals("Yes")) //ถ้าตกลงทีี่จะลบสินค้า
            {
                deleteProduct(); //ลบสินค้า
                this.productBindingSource.RemoveCurrent(); //ลบสินค้าจากตารางสินค้า
            }
            else //ถ้าไม่ต้องการลบสินค้า
            {
                this.productBindingSource.ResetBindings(false); //รีโหลดตารางสินค้าใหม่
            }
        }

        private void Btn_ok_Click(object sender, EventArgs e) //ปุ่มบันทึกสินค้า
        {
            try
            {
                this.Validate(); //ตรวจสอบข้อมูลที่จะบันทึก
                this.productBindingSource.EndEdit(); //ตรวจสอบว่ามีการแก้ไขข้อมูลหรือไม่
                this.productTableAdapter.Update(this.aeCosmeticsDataSet.product); //บันทึกข้อมูลของสินค้าที่ทำการแก้ไขหรือเพิ่ม

                panel_productDetail.Enabled = false; //ปิด panel สินค้า
                btn_add.Enabled = true; //กำหนดให้ปุ่มเพิ่มสินค้าทำงานได้
                btn_update.Enabled = true;  //กำหนดให้ปุ่มแก้ไขสินค้าทำงานได้
                btn_delete.Enabled = true; //กำหนดให้ปุ่มลบสินค้าทำงานได้
                btn_save.Enabled = false; //กำหนดให้ปุ่มบันทึกสินค้าทำงานไม่ได้
                btn_cancel.Enabled = false; //กำหนดให้ปุ่มยกเลิกทำงานไม่ได้

                MSG_SaveOrder mSG = new MSG_SaveOrder(); //สร้างออปเจค mSG
                mSG.ShowDialog(); //แสดงฟอร์มแจ้งเตือนการบันทึกสินค้า
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e) //ปุ่มยกเลิก
        {
            panel_productDetail.Enabled = false;  //ปิด panel สินค้า
            btn_add.Enabled = true; //กำหนดให้ปุ่มเพิ่มสินค้าทำงานได้
            btn_update.Enabled = true; //กำหนดให้ปุ่มแก้ไขสินค้าทำงานได้
            btn_delete.Enabled = true;  //กำหนดให้ปุ่มลบสินค้าทำงานได้
            btn_save.Enabled = false; //กำหนดให้ปุ่มบันทึกสินค้าทำงานไม่ได้
            btn_cancel.Enabled = false; //กำหนดให้ปุ่มยกเลิกทำงานไม่ได้
            productBindingSource.ResetBindings(false); //รีโหลดตารางสินค้าใหม่
            Update_Load(this,null); //โหลดหน้าฟอร์มใหม่
        }

        private void pic_addProduct_Click(object sender, EventArgs e) //ปุ่มเพิ่มภาพสินค้า
        {
            try
            {
                using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png"}) //กำหนดนามสกุลไฟล์ภาพ
                {
                    if (openFile.ShowDialog() == DialogResult.OK) //ถ้ากดเปิดไฟล์
                    {
                        pic_product.Image = Image.FromFile(openFile.FileName); //เพิ่มไฟล์ภาพสินค้า
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }
        }

        private void deleteProduct() //ลบสินค้า
        {
            try
            {
                string mdfFile = @"C:\Program Files (x86)\AE Company\AE_Cosmetics\Database\AE_Cosmetics.mdb"; //path file ฐานข้อมูล

                using (OleDbConnection connection = new OleDbConnection(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Persist Security Info=True", mdfFile))) //เชื่อมต่อกับฐานข้อมูล
                {
                    using (OleDbCommand deleteCommand = new OleDbCommand("DELETE FROM product WHERE [productID] = ?", connection)) //กำหนดคำสั่งในการลบข้อมูลสินค้า
                    {
                        connection.Open(); //เปิดฐานข้อมูล

                        deleteCommand.Parameters.AddWithValue("@productID", txb_productID2.Text); //เพิ่มคำสั่งลบข้อมูล

                        deleteCommand.ExecuteNonQuery(); //ลบข้อมูลสินค้า
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }
        }
    }
}
