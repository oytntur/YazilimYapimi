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
    public partial class alimForm : MetroFramework.Forms.MetroForm
    {
        int userID, saticiID, satisID;
        decimal cost, userMoney;
        ListView list;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-7M06I3FK\\SQLEXPRESS;Initial Catalog=BorsaApp;Integrated Security=True");

        private void btnBuy_Click(object sender, EventArgs e)
        {
            bool hata = false;
            cmd = new SqlCommand("satinAl '" + (metroComboBox1.SelectedIndex + 1) + "','" + satisID + "'," +
                "'" + Convert.ToInt32(cost * (metroComboBox1.SelectedIndex + 1)) + "','" + userID + "','" + saticiID + "'", con);
            if ((metroComboBox1.SelectedIndex + 1) * cost < userMoney)
            {
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün Başarıyla Satın Alındı", "Satın Alma Başarılı", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    con.Close();
                    urunGetir(list);
                }
                catch (Exception)
                {
                    hata = true;
                    throw;
                }

                if (!hata)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hata = false;
            cmd = new SqlCommand("satinAl '" + (metroComboBox1.SelectedIndex + 1) + "','" + satisID + "'," +
                "'" + Convert.ToInt32(cost * (metroComboBox1.SelectedIndex + 1)) + "','" + userID + "','" + saticiID + "'", con);
            if ((metroComboBox1.SelectedIndex + 1) * cost < userMoney)
            {
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün Başarıyla Satın Alındı", "Satın Alma Başarılı", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    con.Close();
                    urunGetir(list);
                }
                catch (Exception)
                {
                    hata = true;
                    throw;
                }
                
                if (!hata)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye!!!");
            }


        }

        public alimForm(int userID, string urun, string satici, int saticiID, decimal fiyat, int stok, int satisID, decimal userMoney, ListView listView)
        {
            InitializeComponent();
            urunAd.Text = urun;
            saticiAd.Text = satici;
            cost = fiyat;
            lblcost.Text = cost.ToString() + " TL";
            this.userID = userID;
            this.saticiID = saticiID;
            this.satisID = satisID;
            this.userMoney = userMoney;
            list = listView;
            for (int i = 0; i < stok; i++)
            {
                metroComboBox1.Items.Add((i + 1).ToString() + " Birim");
            }
        }
        private void urunGetir(ListView urunListView)
        {
            urunListView.Items.Clear();
            cmd = new SqlCommand("satisProc '" + userID + "'", con);
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
                urunListView.Items.Add(add);

            }
            dr.Close();
            con.Close();
        }
    }
}
