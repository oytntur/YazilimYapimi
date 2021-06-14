using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimYapimi
{
    public partial class test : MetroFramework.Forms.MetroForm
    {
        public test()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'appData.excelLog' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.excelLogTableAdapter.Fill(this.appData.excelLog);
            MessageBox.Show(dateTimePicker1.Value.Date.ToString("yyyyMMdd"));

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.appData.excelLog.CopyToDataTable(), "Log");
                            workbook.SaveAs(sfd.FileName);
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        void griddoldur()
        {
            con = new SqlConnection("Data Source=DESKTOP-S1IT89F\\SQLEXPRESS;Initial Catalog=BorsaApp;Integrated Security=True");
            da = new SqlDataAdapter("exec excelProc @p1,@p2", con);
            da.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
            da.SelectCommand.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Personel");
            dataGridView1.DataSource = ds.Tables["Personel"];
            con.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            griddoldur();
        }
    }
}
