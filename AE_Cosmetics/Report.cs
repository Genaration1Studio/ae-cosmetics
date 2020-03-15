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
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace AE_Cosmetics
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();  //ปิดฟอร์ม
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //ย่อขนาดฟอร์มลง
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.product_orderTableAdapter.Fill(this.aeCosmeticsDataSet.product_order);
            this.productTableAdapter.Fill(this.aeCosmeticsDataSet.product);
            this.orderTableAdapter.Fill(this.aeCosmeticsDataSet.order);

            try
            {
                var query = from result in this.aeCosmeticsDataSet.order                          /*****  *******/
                            where result.orderDate.ToString().Equals(cb_orderDate.Text)
                            select result;                                                         /***********************************/
                if (query.ToList().Count() > 0) //ถ้าเจอ
                {
                    getRecipt(query.ToList().ElementAt(0).orderNo.ToString(), query.ToList().ElementAt(0).orderDate, query.ToList().ElementAt(0).saleName, query.ToList().ElementAt(0).total.ToString(), query.ToList().ElementAt(0).cash.ToString(), query.ToList().ElementAt(0).change.ToString());
                }
                else
                {
                    this.reportViewer.Clear();
                }                           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }
        }

        private void getRecipt(string orderID, string oderDate, string salseName,string total, string cash, string change)
        {
            Variable.sumQuantity = 0;

            List<orderListReport> orderListReport = new List<orderListReport>();

            var query = from result in this.aeCosmeticsDataSet.product_order
                        where result.orderNo.ToString().Equals(orderID)
                        select result;

            if (query.ToList().Count() > 0)
            {
                for (int i = 0; i < query.ToList().Count(); i++)
                {
                    var queryName = from result in this.aeCosmeticsDataSet.product
                                    where result.productID.ToString().Equals(query.ToList().ElementAt(i).productID.ToString())
                                    select result;
                    if (queryName.ToList().Count() > 0)
                    {
                        orderListReport product = new orderListReport(queryName.ToList().ElementAt(0).productName, query.ToList().ElementAt(i).quantity.ToString(), query.ToList().ElementAt(i).amount.ToString() + ".00");
                        orderListReport.Add(product);
                    }
                    else
                    {
                        orderListReport product = new orderListReport("", query.ToList().ElementAt(i).quantity.ToString(), query.ToList().ElementAt(i).amount.ToString() + ".00");
                        orderListReport.Add(product);
                    }              
                    Variable.sumQuantity += query.ToList().ElementAt(i).quantity;               
                }
            }

            orderListReportBindingSource.DataSource = orderListReport;

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("orderID", orderID));
            reportParameters.Add(new ReportParameter("orderDate", oderDate));
            reportParameters.Add(new ReportParameter("salseName", salseName));
            reportParameters.Add(new ReportParameter("sumQuantity", Variable.sumQuantity.ToString()));
            reportParameters.Add(new ReportParameter("total", total + ".00"));
            reportParameters.Add(new ReportParameter("Cash", cash + ".00"));
            reportParameters.Add(new ReportParameter("change", change + ".00"));

            ReportDataSource rds = new ReportDataSource("orderListDataset", orderListReportBindingSource.DataSource);
            this.reportViewer.LocalReport.SetParameters(reportParameters);
            this.reportViewer.LocalReport.DataSources.Clear();
            this.reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }

        private void cb_orderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = from result in this.aeCosmeticsDataSet.order                          /***** ค้นหาสินค้าตามที่กรอกในช่องค้นหา *******/
                            where result.orderDate.ToString().Equals(cb_orderDate.Text)
                            select result;                                                         /***********************************/
                if (query.ToList().Count() > 0) //ถ้าเจอ
                {
                    getRecipt(query.ToList().ElementAt(0).orderNo.ToString(), query.ToList().ElementAt(0).orderDate, query.ToList().ElementAt(0).saleName, query.ToList().ElementAt(0).total.ToString(), query.ToList().ElementAt(0).cash.ToString(), query.ToList().ElementAt(0).change.ToString());
                }
                else
                {
                    this.reportViewer.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //แจ้งเตือนเมื่อโปรแกรมทำงานผิดพลาด
            }
        }
    }
}
