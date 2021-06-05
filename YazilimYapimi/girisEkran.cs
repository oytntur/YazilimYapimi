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
using System.IO;
using ClosedXML.Excel;

namespace YazilimYapimi
{
   
    public partial class girisEkran : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1IT89F\\SQLEXPRESS;Initial Catalog=BorsaApp;Integrated Security=True");
        public girisEkran()
        {
            InitializeComponent();
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * from tblUser where userUsername='" + txtBoxUsername.text + "'AND userPassword='" + txtBoxPass.text + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show(dr["userAd"].ToString() + " " + dr["userSoyad"].ToString()
                    + "\nHoşgeldiniz", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Convert.ToInt32(dr["yetkiID"]) == 2)
                {
                    kullaniciEkran kullaniciEkran = new kullaniciEkran(Convert.ToInt32(dr["userID"]));
                    kullaniciEkran.Show();
                    this.Hide();
                }
                else if (Convert.ToInt32(dr["yetkiID"]) == 1)
                {
                    adminEkran adminEkran = new adminEkran();
                    adminEkran.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanici Adı Veya Şifre Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            kayitForm kayitForm = new kayitForm();
            kayitForm.ShowDialog();
        }

        
    }
}
