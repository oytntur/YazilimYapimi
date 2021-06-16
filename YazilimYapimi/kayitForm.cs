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
    public partial class kayitForm : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-7M06I3FK\\SQLEXPRESS;Initial Catalog=BorsaApp;Integrated Security=True");
        public kayitForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool hata = false;
            if (txtBoxAd.Text == "" && txtBoxAdres.Text == "" && txtBoxGSM.Text == "" && txtBoxMail.Text == "" && txtBoxPassword.Text == "" && txtBoxTC.Text == "" && txtBoxUsername.Text == "" && txtBtnSoyad.Text == "")
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    cmd = new SqlCommand("kullaniciKayit '" + txtBoxAd.Text + "','" + txtBtnSoyad.Text + "','" + txtBoxUsername.Text +
                        "','" + txtBoxPassword.Text + "','" + txtBoxTC.Text + "','" + txtBoxAdres.Text + "','" + txtBoxGSM.Text +
                        "','" + txtBoxMail.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    hata = true;
                    throw;
                }
                con.Close();
            }
            if (!hata)
            {
                MessageBox.Show(txtBoxAd.Text + " " + txtBtnSoyad.Text + "\nAdlı Kullanıcı Başarıyla Oluşturuldu", "Kayıt Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
