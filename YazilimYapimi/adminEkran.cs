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
    public partial class adminEkran : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1IT89F\\SQLEXPRESS;Initial Catalog=BorsaApp;Integrated Security=True");

        public adminEkran()
        {
            InitializeComponent();
            satis();
            satisOnay();
            trans();
            logGoster();
        }
        int id = 0;
        private void transLView_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(transLView.SelectedItems[0].SubItems[0].Text);
            cmd = new SqlCommand("EXEC paraOnay '" + id + "'", con);
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
                add.SubItems.Add(dr["miktar"].ToString() + " TL");
                if (!Convert.ToBoolean(dr["transOnay"]))
                {
                    add.SubItems.Add("Onaylanmamış");
                }
                else
                {
                    add.SubItems.Add("Onaylanmış");
                }

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
    }
}
