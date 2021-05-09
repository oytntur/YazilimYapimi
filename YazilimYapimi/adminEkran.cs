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
            cmd = new SqlCommand("SELECT * FROM satisOnayView", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["UrunAd"].ToString();
                add.SubItems.Add(dr["Fiyat"].ToString() + " TL");
                add.SubItems.Add(dr["Miktar"].ToString()+" Birim");
                add.SubItems.Add(dr["Ad"].ToString() + " " + dr["Soyad"].ToString());
                transListView.Items.Add(add);

            }
            dr.Close();
            cmd = new SqlCommand("SELECT * from satisView", con);
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
        }
    }
}
