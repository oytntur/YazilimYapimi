using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
    }
}
