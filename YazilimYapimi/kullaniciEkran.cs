using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazilimYapimi
{
    public partial class kullaniciEkran : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1IT89F\\SQLEXPRESS;Initial Catalog=BorsaApp;Integrated Security=True");

        public kullaniciEkran(int userID)
        {
            InitializeComponent();
            cmd = new SqlCommand("SELECT * from satisView",con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["UrunAd"].ToString();
                add.SubItems.Add(dr["Fiyat"].ToString()+" TL");
                add.SubItems.Add(dr["Miktar"].ToString() + " Birim");
                add.SubItems.Add(dr["Ad"].ToString() + " " + dr["Soyad"].ToString());
                urunListView.Items.Add(add);

            }
            dr.Close();
            cmd = new SqlCommand("SELECT * FROM tblUser WHERE userID='" + userID + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblMoney.Text = dr["yetkiID"].ToString()+" TL";
                lblAdSoyad.Text = dr["userAd"].ToString()+" "+dr["userSoyad"].ToString();
            }
            con.Close();
            dr.Close();
        } 
        int id = 0;

        private void urunListView_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(urunListView.SelectedItems[0].SubItems[0].Text);
        }
    }
}
