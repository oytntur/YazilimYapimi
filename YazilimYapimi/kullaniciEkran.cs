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
    public partial class kullaniciEkran : MetroFramework.Forms.MetroForm
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1IT89F\\SQLEXPRESS;Initial Catalog=BorsaApp;Integrated Security=True");
        int userID;
        public kullaniciEkran(int userID)
        {
            InitializeComponent();
            this.userID =userID;
            urunGetir();
            urunAdGetir();
            logGetir();
            paraGetir();
        } 
        int id = 0;

        private void urunListView_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(urunListView.SelectedItems[0].SubItems[0].Text);
            int saticiID=0,stok=0;
            decimal cost = 0;
            cmd = new SqlCommand("SELECT userID,cost,stokMiktar FROM tblSatis WHERE satisID='" + urunListView.SelectedItems[0].SubItems[0].Text + "' ", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                saticiID = Convert.ToInt32(dr["userID"]);
                cost = Convert.ToDecimal(dr["cost"]);
                stok = Convert.ToInt32(dr["stokMiktar"]);
            }
            con.Close();
            dr.Close();
            MessageBox.Show("Seçilen Ürün : " + urunListView.SelectedItems[0].SubItems[1].Text+"\nSatan Kişi : "
                +urunListView.SelectedItems[0].SubItems[4].Text);
            alimForm alimForm = new alimForm(userID, urunListView.SelectedItems[0].SubItems[1].Text,
                urunListView.SelectedItems[0].SubItems[4].Text, saticiID, cost, stok,
                Convert.ToInt32(urunListView.SelectedItems[0].SubItems[0].Text), Convert.ToDecimal(lblMoney.Text),
                urunListView);
            alimForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("EXEC addMoney '" + userID + "','" + Convert.ToDecimal(textBox1.Text) + "'", con);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Para Yatırma İşleminiz Oluşturuldu");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Meydana Geldi");
                throw;
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("EXEC satisEkle '" + userID + "','" + (cmbUrun.SelectedIndex + 1) + "','" + Convert.ToDecimal(txtFiyat.Text)
                + "','" + Convert.ToInt32(txtStok.Text) + "'", con);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("işlem başarıyla gerçekleşti");
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
        }
        private void urunGetir()
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
        private void paraGetir()
        {
            cmd = new SqlCommand("SELECT * FROM tblUser WHERE userID='" + userID + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblMoney.Text = dr["userMoney"].ToString();
                groupBox3.Text = dr["userAd"].ToString() + " " + dr["userSoyad"].ToString();
            }
            dr.Close();
            con.Close();
        }
        private void urunAdGetir()
        {
            cmd = new SqlCommand("SELECT * FROM urunView", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbUrun.Items.Add(dr["Ad"].ToString());
                comboBox1.Items.Add(dr["Ad"].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void logGetir()
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

        private void kullaniciEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("EXEC satisEkle '" + userID + "','" + (cmbUrun.SelectedIndex + 1) + "','" + Convert.ToDecimal(txtFiyat.Text)
                + "','" + Convert.ToInt32(txtStok.Text) + "'", con);
            con.Open();
            bool hata = false;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("işlem başarıyla gerçekleşti");
            }
            catch (Exception)
            {
                hata = true;
                throw;
            }
            con.Close();
            if (!hata)
            {
                talepKontrol(Convert.ToInt32(txtStok.Text), Convert.ToDecimal(txtFiyat.Text),cmbUrun.SelectedIndex+1);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("EXEC addMoney '" + userID + "','" + Convert.ToDecimal(textBox1.Text) + "','"+paraBirim.Text+"'", con);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Para Yatırma İşleminiz Oluşturuldu");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Meydana Geldi");
                throw;
            }
            con.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("exec talepOlustur '" + (comboBox1.SelectedIndex + 1) + "'," +
                "'" + Convert.ToInt32(bunifuMetroTextbox2.Text) + "'," +
                "'" + Convert.ToDecimal(bunifuMetroTextbox1.Text) + "'," +
                "'"+userID+"'", con);
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
            satisKontrol(Convert.ToInt32(bunifuMetroTextbox2.Text), Convert.ToDecimal(bunifuMetroTextbox1.Text), comboBox1.SelectedIndex + 1);
        }
        private void talepKontrol(int miktar,decimal fiyat,int urunid)
        {
            SqlCommand cmd2;
            cmd = new SqlCommand("select * from tblTalepler where bitti=0 and urunID='"+urunid+"'and" +
                " userID != '"+userID+"'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            int stok=0,satisid=0;
            int userid = 0,talepid=0;
            while (dr.Read())
            {
                if (Convert.ToDecimal(dr["priceTag"]) >= fiyat && Convert.ToInt32(dr["miktar"]) >= miktar)
                {
                    stok = Convert.ToInt32(dr["miktar"]);
                    userid = Convert.ToInt32(dr["userID"]);
                    talepid = Convert.ToInt32(dr["talepID"]);
                    break;
                }
            }

            dr.Close();
            cmd = new SqlCommand("(select count(satisID) as 'Test' from tblSatis)",con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                satisid = Convert.ToInt32(dr["test"]);
            }
            dr.Close();
            cmd2 = new SqlCommand("exec satinAl '" + stok + "'," +
                        " '"+satisid+"' ," +
                        "'" + fiyat + "','" + userid + "'," +
                        "'" + userID + "'", con);
            cmd2.ExecuteNonQuery();
            cmd = new SqlCommand("update tblTalepler set bitti=1 where talepID='" + talepid + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void satisKontrol(int miktar, decimal fiyat, int urunid)
        {
            SqlCommand cmd2;
            cmd = new SqlCommand("select * from tblSatis where urunID='" + urunid + "'and" +
                " userID != '" + userID + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            int stok = 0, satisid = 0;
            int userid = 0, talepid = 0;
            while (dr.Read())
            {
                if (Convert.ToDecimal(dr["cost"]) <= fiyat && Convert.ToInt32(dr["stokMiktar"]) >= miktar)
                {                   
                    userid = Convert.ToInt32(dr["userID"]);
                    satisid = Convert.ToInt32(dr["satisID"]);
                    break;
                }
            }

            dr.Close();
            cmd = new SqlCommand("(select count(talepID) as 'Test' from tblTalepler)", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                talepid = Convert.ToInt32(dr["Test"]);
            }
            dr.Close();
            cmd2 = new SqlCommand("exec satinAl '" + miktar + "'," +
                        " '" + satisid + "' ," +
                        "'" + fiyat + "','" + userID + "'," +
                        "'" + userid + "'", con);
            cmd2.ExecuteNonQuery();
            cmd = new SqlCommand("update tblTalepler set bitti=1 where talepID='" + talepid + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
