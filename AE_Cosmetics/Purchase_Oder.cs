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
using Twilio.TwiML.Voice;

namespace AE_Cosmetics
{
    public partial class Purchase_Oder : Form
    {

        private DataTable dtTablepProductOrder = new DataTable("PODERTB"); //สร้าง datatable
        private List<orderList> orderLists = new List<orderList>(); //สร้าง List ของสินค้า
        private int stock = 0; //กำหนดตัวแปร stock มีค่าเริ่มต้นเป็น 0

        public Purchase_Oder()
        {
            InitializeComponent();
            txb_productID2.Focus();  //ให้ cuursor ไปอยู่ที่ช่อง productID
            btn_add.Enabled = false; //กำหนดให้ปุ่ม add ทำงานไม่ได้
        }

        private void Purchase_Oder_Load(object sender, EventArgs e)
        {
            
            this.product_orderTableAdapter.Fill(this.aeCosmeticsDataSet.product_order);      //โหลดข้อมูลของตาราง product_order จากฐานข้อมูล
            this.orderTableAdapter.Fill(this.aeCosmeticsDataSet.order);  //โหลดข้อมูลของตาราง order จากฐานข้อมูล
            this.productTableAdapter.Fill(this.aeCosmeticsDataSet.product);  //โหลดข้อมูลของตาราง product จากฐานข้อมูล

            try
            {
                if (Variable.createOrder.Equals("first")) //ตรวจสอบว่าใช่ครั้งแรกที่ทำการโหลดฟอร์มหรือไม่
                {
                    this.aeCosmeticsDataSet.order.AddorderRow(this.aeCosmeticsDataSet.order.NeworderRow()); //สร้าง order ขึ้นมาใหม่ 
                    orderBindingSource.MoveLast(); //เลือก order ที่สร้างขึ้นมาใหม่
                    this.aeCosmeticsDataSet.product_order.Addproduct_orderRow(this.aeCosmeticsDataSet.product_order.Newproduct_orderRow()); //สร้าง product_order ขึ้นมาใหม่
                    productorderBindingSource.MoveLast(); //เลือก product_order ที่สร้างขึ้นมาใหม่
                    txb_createDate2.Text = DateTime.Now.ToString(); //กำหนดเวลาปัจจุบันให้กับ order
                    lbl_total.Text = "00.00"; //กำหนดจำนวนเงินที่ต้องจ่ายเริ่มต้นที่ 00.00 บาท

                    dtTablepProductOrder.Columns.Add(new DataColumn("col_ProducID", typeof(string)));    /*******สร้างคอลัมน์ที่จะแสดงรายการสิ้นค้าที่จะจัดซื้อ *******/
                    dtTablepProductOrder.Columns.Add(new DataColumn("col_ProducName", typeof(string)));
                    dtTablepProductOrder.Columns.Add(new DataColumn("col_Size", typeof(string)));
                    dtTablepProductOrder.Columns.Add(new DataColumn("col_UnitPrice", typeof(string)));
                    dtTablepProductOrder.Columns.Add(new DataColumn("col_Quantity", typeof(string)));
                    dtTablepProductOrder.Columns.Add(new DataColumn("col_Amount", typeof(string)));      /********************************************/

                    this.dtg_orderList.AutoGenerateColumns = false; //ไม่อนุญาติให้สร้างคอลัมน์รายการสินค้าเอง
                    this.dtg_orderList.AllowUserToAddRows = false; //ไม่อนุญาติให้เพิ่มรายการสินค้าเอง
                }
                else if (Variable.createOrder.Equals("two")) //ตรวจสอบว่าใช่ครั้งที่สองที่ทำการโหลดฟอร์มหรือไม่
                {
                    this.aeCosmeticsDataSet.order.AddorderRow(this.aeCosmeticsDataSet.order.NeworderRow()); //สร้าง order ขึ้นมาใหม่ 
                    orderBindingSource.MoveLast(); //เลือก order ที่สร้างขึ้นมาใหม่
                    this.aeCosmeticsDataSet.product_order.Addproduct_orderRow(this.aeCosmeticsDataSet.product_order.Newproduct_orderRow());  //สร้าง product_order ขึ้นมาใหม่
                    productorderBindingSource.MoveLast(); //เลือก product_order ที่สร้างขึ้นมาใหม่
                    txb_createDate2.Text = DateTime.Now.ToString(); //กำหนดเวลาปัจจุบันให้กับ order
                    lbl_total.Text = "00.00"; //กำหนดจำนวนเงินที่ต้องจ่ายเริ่มต้นที่ 00.00 บาท
                    Variable.saveStatus = ""; //กำหนดสาถานะของ order เป็นยังไม่บันทึก
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }

        }

        private void Btn_exit_Click(object sender, EventArgs e) //ปุ่มปิดฟอร์ม
        {
            if (Variable.saveStatus.Equals("")) //ถ้ายังไม่ได้บันทึก order
            {
                deleteOrder(); //ทำการลบรรายการสินค้าที่ทำการเพิ่มลงใน order
            }
            this.Close(); //ปิดฟอร์ม
        }

        private void Btn_mini_Click(object sender, EventArgs e) //ปุ่มย่อขนาดฟอร์ม
        {
            this.WindowState = FormWindowState.Minimized; //ย่อขนาดฟอร์มลง
        }

        private void Btn_ok_Click(object sender, EventArgs e) //ปุุ่มบันทึก order
        {
            try
            {
                this.Validate(); //ตรวจสอบข้อมูลที่จะบันทึก
                this.orderBindingSource.EndEdit(); //ตรวจสอบว่ามีการแก้ไขข้อมูลหรือไม่
                this.orderTableAdapter.Update(this.aeCosmeticsDataSet.order); //บันทึกข้อมูลของ order ที่ทำการแก้ไข

                MSG_SaveOrder mSG = new MSG_SaveOrder(); //สร้างออปเจค mSG
                mSG.ShowDialog(); //แสดงฟอร์มแจ้งเตือนการบันทึก

                clearAllData(); //ล้างข้อมูลในฟอร์มเพื่อรอจัดการ oder ใหม่
                Purchase_Oder_Load(this,null); //โหลดหน้าฟอร์มใหม่
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }

        }

        private void txb_quantity2_KeyUp(object sender, KeyEventArgs e) //ช่องจำนวนสินค้า
        {
            calAmount(); //คำนวนราคาสินค้า
        }

        private void txb_productID2_KeyUp(object sender, KeyEventArgs e) //ช่อง productID
        {
            var query = from result in this.aeCosmeticsDataSet.product                  /***** ค้นหาสินค้าที่มีรหัสสินค้าเหมือนกับที่กรอกในช่อง productID *******/
                        where result.productID.ToString().Equals(txb_productID2.Text)    
                        select result;                                                  /********************************************************/
            txb_productName2.DataBindings.Clear(); //ล้างข้อมูลชื่อสินค้า
            txb_description2.DataBindings.Clear(); //ล้างข้อมูลรายละเอียดสินค้า
            txb_unitPrice2.DataBindings.Clear();   //ล้างข้อมูลราคาสินค้า
            txb_inStock2.DataBindings.Clear();     //ล้างข้อมูลจำนวนสินค้าในคลัง
            txb_size2.DataBindings.Clear();        //ล้างข้อมูลขนาดสินค้า
            if (query.ToList().Count() > 0)  //ถ้าค้นหาสินค้าเจอ
            {
                this.txb_productName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", query.ToList(), "productName", true)); /******** กำหนดให้แสดงข้อมูลสินค้าที่ค้นเจอ ********/
                this.txb_description2.DataBindings.Add(new System.Windows.Forms.Binding("Text", query.ToList(), "description", true));
                this.txb_unitPrice2.DataBindings.Add(new System.Windows.Forms.Binding("Text", query.ToList(), "unitPrice", true));
                this.txb_inStock2.DataBindings.Add(new System.Windows.Forms.Binding("Text", query.ToList(), "inStock", true));
                this.txb_size2.DataBindings.Add(new System.Windows.Forms.Binding("Text", query.ToList(), "size", true));               /******************************************/

                if (txb_inStock2.Text.Equals("0")) //ถ้าสินค้าในคลังหมด
                {
                    btn_add.Enabled = false;  //กำหนดให้ปุ่ม add ทำงานไม่ได้
                }
                else //ถ้าสินค้าในคลังคงเหลือพอที่จะซื้อ
                {
                    btn_add.Enabled = true; //กำหนดให้ปุ่ม add ทำงานได้
                }

                calAmount(); //คำนวนราคาสินค้า

            }
            else //ถ้าไม่เจอสินค้า
            {
                txb_productName2.Text = "";   /******** กำหนดให้แสดงข้อมูลสินค้าเป็นค่าว่าง ********/
                txb_description2.Text = "";
                txb_unitPrice2.Text = "";
                txb_inStock2.Text = "";
                txb_size2.Text = "";        /******************************************/
                btn_add.Enabled = false; //กำหนดให้ปุ่ม add ทำงานไม่ได้
            }
        }

        private void btn_add_Click(object sender, EventArgs e) //ปุ่มเพิ่ม
        {
            try
            {
                stock = int.Parse(txb_inStock2.Text);  //กำหนดให้ตัวแปร stock มีค่าเท่ากับจำนวนสินค้าที่มีอยู่ในคลังสินค้า
                stock = stock - int.Parse(txb_quantity2.Text); //นำจำนวนสินค้าที่มีอยู่ในคลังสินค้ามาลบจำนวนที่ทำการสั่งซื้อ

                if (stock >= 0) //ถ้าสินค้าพอที่จะซื้อ
                {
                    calTotal();  //คำนวนราคาสินค้าทั้งหมด
                    setProductOrder(); //กำหนดค้าให้ product_order

                    updateStock(); //แก้ใขจำนวนสินค้าในคลังสินค้า 

                    this.Validate();   //ตรวจสอบข้อมูลที่จะบันทึก
                    this.productorderBindingSource.EndEdit(); //ตรวจสอบว่ามีการแก้ไขข้อมูลหรือไม่
                    this.product_orderTableAdapter.Update(this.aeCosmeticsDataSet.product_order); //บันทึกข้อมูลของ product_order ที่ทำการแก้ไข
                    this.aeCosmeticsDataSet.product_order.Addproduct_orderRow(this.aeCosmeticsDataSet.product_order.Newproduct_orderRow()); //สร้าง product_order ขึ้นมาใหม่
                    productorderBindingSource.MoveLast(); //เลือก product_order ที่สร้างขึ้นมาใหม่

                    btn_calculate.Enabled = true; //กำหนดให้ปุ่ม calculate ทำงานได้
                    btn_ok.Enabled = true;   //กำหนดให้ปุ่มบันทึก ทำงานได้
                    btn_clearAll.Enabled = true; //กำหนดให้ปุ่มล้างรายการสินค้าทำงานได้

                    setOrderLists(); //เพิ่มสินค้าลงใน order
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }
        }

        private void calAmount() //คำนวนราคาสินค้า
        {
            if (!string.IsNullOrEmpty(txb_quantity2.Text)) //ถ้ามีจำนวนสินค้าที่สั่งซื้อ
            {
                if (!string.IsNullOrEmpty(txb_unitPrice2.Text)) //ถ้ามีจำนวนราคาสินค้า
                {
                    txb_amount2.Text = (int.Parse(txb_unitPrice2.Text) * int.Parse(txb_quantity2.Text)).ToString(); //คำนวนราคาสินค้าโดยนำ ราคาสินค้า * กับจำนวนที่สั่งซื้อ
                }
                else
                {
                    txb_amount2.Text = ""; //กำหนดให้ราคาสินค้าเป็นค่าว่าง
                }

            }
            else
            {
                txb_amount2.Text = ""; //กำหนดให้ราคาสินค้าเป็นค่าว่าง
            }
        }


        private void calTotal() //คำนวนราคาสินค้าทั้งหมด
        {
            Double total = Double.Parse(lbl_total.Text); //กำหนดค่าให้ตัวแปร total มีค่าเท่ากับจำนวนราคาสินค้าทัั้งหมด
            if (!string.IsNullOrEmpty(txb_amount2.Text)) //ถ้ามีการสั่งซื้อสินค้า
            {
                total += Double.Parse(txb_amount2.Text); //+ เพิ่มราคาสินค้าทั้งหมดกับราคาสินค้าที่จะสั่งซื้อ
            }
            lbl_total.Text = total.ToString(); //แสดงราคาสินค้าทั้งหมด
        }

        private void setProductOrder() //กำหนดค้าให้ product_order
        {
            txb_productID3.Text = txb_productID2.Text; /********* กำหนดค่าที่จะทำการบันทึกลงใน product_order *********/
            txb_orderNo3.Text = txb_orderNo2.Text;
            txb_quantity3.Text = txb_quantity2.Text;
            txb_amount3.Text = txb_amount2.Text;      /*******************************************************/
        }

        private void btn_clearAll_Click(object sender, EventArgs e) //ปุ่มล้างรายการสินค้า
        {
            deleteOrder(); //ลบรายการสินค้า
            clearAllData(); //ล้างข้อมูลในฟอร์มเพื่อรอจัดการ oder ใหม่
        }

        private void btn_calculate_Click(object sender, EventArgs e) //ปุ่มคำนวนเงิน
        {
            if (!string.IsNullOrEmpty(txb_cash2.Text)) //ถ้ามีจำนวนเงินที่รับมา
            {
                Double total = Double.Parse(lbl_total.Text); //ราคาสินค้าทั้งหมด
                Double cash = Double.Parse(txb_cash2.Text); //จำนวนเงินที่รับมา

                txb_change2.Text = (cash - total).ToString(); //คำนวนหาเงินทอนโดยนำ จำนวนเงินที่รับมา - ราคาสินค้าทั้งหมด

                if (total > cash) //ถ้าราคาสินค้ามากกว่าเงินที่รับมา
                {
                    btn_ok.Enabled = false; //กำหนดให้ปุ่มบันทึก ทำงานไม่ได้
                }
                else
                {
                    btn_ok.Enabled = true; //กำหนดให้ปุ่มบันทึก ทำงานได้
                }
            }
        }


        private void deleteOrder() //ลบรายการสินค้า 
        {
            try
            {
                string mdfFile = @"C:\Program Files (x86)\AE Company\AE_Cosmetics\Database\AE_Cosmetics.mdb"; //path file ฐานข้อมูล

                using (OleDbConnection connection = new OleDbConnection(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Persist Security Info=True", mdfFile))) //เชื่อมต่อกับฐานข้อมูล
                {
                    using (OleDbCommand deleteCommand = new OleDbCommand("DELETE FROM product_order WHERE [orderNo] = ?", connection)) //กำหนดคำสั่งในการลบข้อมูลรายการสินค้า
                    {
                        connection.Open(); //เปิดฐานข้อมูล

                        deleteCommand.Parameters.AddWithValue("@orderNo", txb_orderNo2.Text); //เพิ่มคำสั่งลบข้อมูล

                        deleteCommand.ExecuteNonQuery(); //ลบข้อมูลรายการสินค้า

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }
        }

        private void updateStock() //อัพเดทคลังสินค้า
        {
            try
            {
                string mdfFile = @"C:\Program Files (x86)\AE Company\AE_Cosmetics\Database\AE_Cosmetics.mdb"; //path file ฐานข้อมูล

                using (OleDbConnection connection = new OleDbConnection(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Persist Security Info=True", mdfFile)))  //เชื่อมต่อกับฐานข้อมูล
                {
                    using (OleDbCommand updateCommand = new OleDbCommand("UPDATE product SET [instock] = ? WHERE [productID] = ?", connection)) //กำหนดคำสั่งในการอัพเดทข้อมูลรายการสินค้า
                    {
                        connection.Open(); //เปิดฐานข้อมูล

                        updateCommand.Parameters.AddWithValue("@instock", stock); //กำหนดตัวแปรจำนวนสินค้า
                        updateCommand.Parameters.AddWithValue("@productID", txb_productID2.Text); //กำหนดตัวแปรรหัสสินค้า

                        updateCommand.ExecuteNonQuery(); //อัพเดทคลังสินค้า

                        txb_inStock2.Text = stock.ToString(); //แสดงจำนวนสินค้าในคลังที่เหลืออยู่
                        this.productTableAdapter.Fill(this.aeCosmeticsDataSet.product);  //โหลดข้อมูลของตาราง product จากฐานข้อมูล
                        this.productBindingSource.EndEdit(); //ตรวจสอบว่ามีการแก้ไขข้อมูลหรือไม่
                        this.productTableAdapter.Update(this.aeCosmeticsDataSet.product);//บันทึกข้อมูลของ product ที่ทำการแก้ไข
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }
        }

        private void clearAllData() //ล้างข้อมูลในฟอร์ม
        {
            orderLists.Clear(); //ล้าง List ของสินค้า
            dtTablepProductOrder.Clear(); //ล้าง datatable รายการสินค้า
            btn_calculate.Enabled = false; //กำหนดให้ปุ่ม calulate ทำงานไม่ได้
            btn_ok.Enabled = false;  //กำหนดให้ปุ่มบันทึกทำงานไม่ได้
            btn_clearAll.Enabled = false; //กำหนดให้ปุ่มล้างรายการทำงานไม่ได้
            txb_productName2.Text = "";  /****** กำหนดให้ข้อมูลสินค้าเป็นค่าว่าง *******/
            txb_description2.Text = "";
            txb_cash2.Text = "";
            txb_change2.Text = "";
            txb_unitPrice2.Text = "";
            txb_inStock2.Text = "";
            txb_size2.Text = "";
            txb_amount2.Text = "";
            txb_quantity2.Text = "";
            txb_size2.Text = "";
            txb_productID2.Text = ""; /**************************************/
            lbl_total.Text = "00.00"; //กำหนดจำนวนเงินที่ต้องจ่ายเริ่มต้นที่ 00.00 บาท
            txb_productID2.Focus(); //ให้ cuursor ไปอยู่ที่ช่อง productID
        }

        private void setOrderLists()  //เพิ่มสินค้าลงใน order
        {
            try
            {
                int dup = 0; //กำหนดค่าของตัวแปรที่ใช้ตรวจสอบรหัสสินค้า
                orderList order = new orderList(); //สร้างออปเจค oder
                if (orderLists.Count > 0) //ถ้ามีสินค้าในรายการสินค้า
                {
                    for (int i = 0; i < orderLists.Count(); i++) //วนรอบตรวจสอบรายการสินค้า
                    {
                        if (orderLists[i].productID.Equals(txb_productID2.Text)) //ถ้ามีสินค้านั้นอยู่ในรายการสินค้าอยู่แล้ว
                        {
                            orderLists[i].quantity += int.Parse(txb_quantity2.Text.Trim()); //ให้เพิ่มจำนวนที่สั่งซื้อ
                            orderLists[i].amount += Double.Parse(txb_amount2.Text.Trim()); //เพิ่มราคาสินค้า
                            dup++; //เพิ่มค่าของตัวแปร dup
                            break; //ออกจากลูป
                        }
                    }

                    if (dup == 0) //ถ้าไม่มีสินค้าชิ้นนั้นในรายการ
                    {
                        order.productID = txb_productID2.Text; //เพิ่มรหัสสินค้า
                        order.productName = txb_productName2.Text; //เพิ่มชื่อสินค้า
                        order.size = txb_size2.Text; //เพิ่มขนาดสินค้า
                        order.unitPrice = int.Parse(txb_unitPrice2.Text.Trim()); //เพิ่มราคาสินค้าต่อชิ้น
                        order.quantity = int.Parse(txb_quantity2.Text.Trim()); //เพิ่มจำนวนสินค้าที่ทำการสั่งซื้อ
                        order.amount = Double.Parse(txb_amount2.Text.Trim()); //เพิ่มราคาสินค้า
                        orderLists.Add(order); //เพิ่มสินค้าชิ้นนั้นลงในรายการสินค้า
                    }
                }
                else //ถ้าไม่มีสิ้นค้าในรายการสินค้า
                {
                    order.productID = txb_productID2.Text; //เพิ่มรหัสสินค้า
                    order.productName = txb_productName2.Text; //เพิ่มชื่อสินค้า
                    order.size = txb_size2.Text; //เพิ่มขนาดสินค้า
                    order.unitPrice = int.Parse(txb_unitPrice2.Text.Trim()); //เพิ่มราคาสินค้าต่อชิ้น
                    order.quantity = int.Parse(txb_quantity2.Text.Trim()); //เพิ่มจำนวนสินค้าที่ทำการสั่งซื้อ
                    order.amount = Double.Parse(txb_amount2.Text.Trim()); //เพิ่มราคาสินค้า
                    orderLists.Add(order); //เพิ่มสินค้าชิ้นนั้นลงในรายการสินค้า
                }
                setDtgOrderList(); //แสดงรายการสินค้า
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }    
        }

        private void setDtgOrderList() //แสดงรายการสินค้า
        {
            try
            {
                dtTablepProductOrder.Clear(); //ล้างรายการสินค้าที่แสดง

                for (int i = 0; i < orderLists.Count; i++) //วนรอบรายการสินค้า
                {
                    dtTablepProductOrder.Rows.Add(orderLists[i].productID, orderLists[i].productName, orderLists[i].size, orderLists[i].unitPrice, orderLists[i].quantity, orderLists[i].amount); //เพิ่มสินค้าในรายการสินค้าลงในตาราง
                }

                this.dtg_orderList.DataSource = dtTablepProductOrder; //แสดงสินค้าในรายการสินค้า
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }
        }
    }
}
