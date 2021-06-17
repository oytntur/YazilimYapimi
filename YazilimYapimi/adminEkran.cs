using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClosedXML.Excel;
using MetroFramework;

namespace YazilimYapimi
{
    
    public partial class adminEkran : MetroFramework.Forms.MetroForm
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-7M06I3FK\\SQLEXPRESS;Initial Catalog=BorsaApp;Integrated Security=True");
        decimal USD=0, EUR=0, GBP=0;
        public adminEkran()
        {
            InitializeComponent();
            satis();
            satisOnay();
            trans();
            logGoster();
            MuhasebeGoster();
            paraGetir();
            dovizGetir();
        }
        int id = 0;
        private void transLView_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(transLView.SelectedItems[0].SubItems[0].Text);
            decimal carpan = 0;
            if (transLView.SelectedItems[0].SubItems[4].Text == "TRY")
            {
                carpan = 1;
            }
            else if (transLView.SelectedItems[0].SubItems[4].Text == "USD")
            {
                carpan = USD;
             
            }
            else if (transLView.SelectedItems[0].SubItems[4].Text == "EUR")
            {
                carpan = EUR;
                
            }
            else if (transLView.SelectedItems[0].SubItems[4].Text == "GBP")
            {
                carpan = GBP;
                
            }
            cmd = new SqlCommand("EXEC paraOnay '" + id + "',@p1", con);
            cmd.Parameters.Add("@p1", SqlDbType.Decimal).Value = carpan;
            con.Open();
            DialogResult dialogResult = MessageBox.Show("Onay Vermek İstiyormusunuz"
                , "Onay", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            trans();
        }

        private void transListView_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(transListView.SelectedItems[0].SubItems[0].Text);
            con.Open();
            cmd = new SqlCommand("EXEC urunOnay '" + id + "'", con);
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    satisOnay();
                    satis();

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


        }
        private void satisOnay()
        {
            transListView.Items.Clear();
            cmd = new SqlCommand("SELECT * FROM satisOnayView", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["ID"].ToString();
                add.SubItems.Add(dr["UrunAd"].ToString());
                add.SubItems.Add(dr["Fiyat"].ToString() + " TL");
                add.SubItems.Add(dr["Miktar"].ToString() + " Birim");
                add.SubItems.Add(dr["Ad"].ToString() + " " + dr["Soyad"].ToString());
                transListView.Items.Add(add);

            }
            dr.Close();
            con.Close();
        }
        private void satis()
        {
            urunListView.Items.Clear();
            cmd = new SqlCommand("SELECT * from satisView", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["UrunAd"].ToString();
                add.SubItems.Add(dr["Fiyat"].ToString() + " TL");
                add.SubItems.Add(dr["Miktar"].ToString() + " Birim");
                add.SubItems.Add(dr["Ad"].ToString() + " " + dr["Soyad"].ToString());
                urunListView.Items.Add(add);

            }
            dr.Close();
            con.Close();
        }
        private void trans()
        {
            transLView.Items.Clear();
            cmd = new SqlCommand("SELECT * from transView", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["ID"].ToString();
                add.SubItems.Add(dr["Ad"].ToString() + " " + dr["Soyad"].ToString());
                add.SubItems.Add(dr["miktar"].ToString() + " " +dr["paraBirim"].ToString());
                if (!Convert.ToBoolean(dr["transOnay"]))
                {
                    add.SubItems.Add("Onaylanmamış");
                }
                else
                {
                    add.SubItems.Add("Onaylanmış");
                }
                add.SubItems.Add(dr["paraBirim"].ToString());

                transLView.Items.Add(add);

            }
            dr.Close();
            con.Close();
        }
        private void logGoster()
        {
            logView.Items.Clear();
            cmd = new SqlCommand("SELECT * FROM LogView", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["Tarih"].ToString();
                add.SubItems.Add(dr["AlanAd"].ToString() + " Birim Fiyatı " + dr["BirimFiyat"].ToString() +
                    " TL Olan " + dr["UrunAd"].ToString() + "'dan " + dr["Miktar"].ToString() + " Birim Satın Aldı");
                add.SubItems.Add(dr["AlanAd"].ToString() + " " + dr["SatanAd"] + "'nın hesabına " +
                    dr["Fiyat"].ToString() + " TL Gönderdi");
                add.SubItems.Add(dr["AlanAd"].ToString() + " " + dr["LeftMoney"].ToString() + " TLsi Kaldı");
                add.SubItems.Add(dr["BirimFiyat"].ToString() + " TL");
                logView.Items.Add(add);
            }
            dr.Close();
            con.Close();
        }


        private void adminEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void MuhasebeGoster()
        {
            muhasebe.Items.Clear();
            cmd = new SqlCommand("SELECT * FROM LogView", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["AlanAd"].ToString() + " " + dr["AlanSoyad"].ToString();
                add.SubItems.Add(dr["UrunAd"].ToString());
                add.SubItems.Add(dr["Miktar"].ToString() + " Birim");
                add.SubItems.Add(dr["Fiyat"].ToString() + " Tl");
                muhasebe.Items.Add(add);
            }
            dr.Close();
            con.Close();
        }

        private void Don_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Devam etmek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                girisEkran girisEkran = new girisEkran();
                girisEkran.Show();
                this.Hide();
            }
            if (cikis == DialogResult.No)
            {
                MessageBox.Show("Sistemde Çalışmaya devam edebilirsiniz.");
            }
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Devam etmek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (cikis == DialogResult.No)
            {
                MessageBox.Show("Program kapatılmadı.");
            }

        }



        private void paraGetir()
        {
            cmd = new SqlCommand("SELECT * FROM tblUser WHERE userID='" + 3 + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            lblmevcut.Text = dr["userMoney"].ToString();
            
            dr.Close();
            con.Close();


        }
        private void dovizGetir()
        {
            
            const string URL = @"https://www.tcmb.gov.tr/kurlar/today.xml";
            XDocument xdoc = XDocument.Load(URL);

            foreach (XElement elem in xdoc.Descendants("Currency"))
            {
                if (elem.Attribute("Kod").Value == "USD")
                {
                    string temp = elem.Element("ForexBuying").Value;
                    temp.Replace('.', ',');
                    USD = Convert.ToDecimal(temp, new CultureInfo("en-US"));
                }
                else if(elem.Attribute("Kod").Value == "EUR")
                {
                    string temp = elem.Element("ForexBuying").Value;
                    temp.Replace('.', ',');
                    EUR = Convert.ToDecimal(temp, new CultureInfo("en-US"));
                }
                else if (elem.Attribute("Kod").Value == "GBP")
                {
                    string temp = elem.Element("ForexBuying").Value;
                    temp.Replace('.', ',');
                    GBP = Convert.ToDecimal(temp, new CultureInfo("en-US"));
                }
                

            }
        }
        
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            //Adding the Columns.
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            string folderPath = "C:\\Users\\SERDAR SAVAŞ\\Desktop\\Excel\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Customers");

                //Set the color of Header Row.
                //A resembles First Column while C resembles Third column.
                wb.Worksheet(1).Cells("A1:C1").Style.Fill.BackgroundColor = XLColor.DarkGreen;
                for (int i = 1; i <= dt.Rows.Count; i++)
                {
                    //A resembles First Column while C resembles Third column.
                    //Header row is at Position 1 and hence First row starts from Index 2.
                    string cellRange = string.Format("A{0}:C{0}", i + 1);
                    if (i % 2 != 0)
                    {
                        wb.Worksheet(1).Cells(cellRange).Style.Fill.BackgroundColor = XLColor.GreenYellow;
                    }
                    else
                    {
                        wb.Worksheet(1).Cells(cellRange).Style.Fill.BackgroundColor = XLColor.Yellow;
                    }

                }
                //Adjust widths of Columns.
                wb.Worksheet(1).Columns().AdjustToContents();

                //Save the Excel file.
                wb.SaveAs(folderPath + "DataGridViewExport.xlsx");
                MessageBox.Show("Yazdırma işlemi başarıyla gerçekleştirilmiştir.", "Excel'e Yazdir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void griddoldur()
        {

            con = new SqlConnection("Data Source=LAPTOP-7M06I3FK\\SQLEXPRESS;Initial Catalog=BorsaApp;Integrated Security=True");
            da = new SqlDataAdapter("exec excelProc @p1,@p2", con);
            da.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
            da.SelectCommand.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Personel");
            dataGridView1.DataSource = ds.Tables["Personel"];
            con.Close();
        }
        private void Goster_Click_1(object sender, EventArgs e)
        {
            griddoldur();

        }

    }
}
