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
    public partial class alimForm : Form
    {
        int userID, saticiID,satisID;
        decimal cost,userMoney;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1IT89F\\SQLEXPRESS;Initial Catalog=BorsaApp;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("satinAl '" + (cmbStok.SelectedIndex + 1) + "','" + satisID + "'," +
                "'" + Convert.ToInt32(cost * (cmbStok.SelectedIndex + 1)) + "','" + userID + "','" + saticiID + "'", con);
            if ((cmbStok.SelectedIndex + 1) * cost < userMoney)
            {
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye!!!");
            }

        }

        public alimForm(int userID,string urun,string satici,int saticiID,decimal fiyat,int stok,int satisID,decimal userMoney)
        {
            InitializeComponent();
            urunAd.Text = urun;
            saticiAd.Text = satici;
            cost = fiyat;
            lblcost.Text = cost.ToString()+" TL";
            this.userID = userID;
            this.saticiID = saticiID;
            this.satisID = satisID;
            this.userMoney = userMoney;
            for(int i = 0; i < stok; i++)
            {
                cmbStok.Items.Add((i + 1).ToString() + " Birim");
            }
        }
    }
}
