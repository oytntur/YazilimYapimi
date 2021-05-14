
namespace YazilimYapimi
{
    partial class girisEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisEkran));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtBoxPass = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtBoxUsername = new Bunifu.Framework.UI.BunifuTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // btnSignUp
            // 
            this.btnSignUp.ActiveBorderThickness = 1;
            this.btnSignUp.ActiveCornerRadius = 20;
            this.btnSignUp.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSignUp.ActiveForecolor = System.Drawing.Color.White;
            this.btnSignUp.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignUp.BackgroundImage")));
            this.btnSignUp.ButtonText = "Sign Up";
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSignUp.IdleBorderThickness = 1;
            this.btnSignUp.IdleCornerRadius = 20;
            this.btnSignUp.IdleFillColor = System.Drawing.Color.White;
            this.btnSignUp.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSignUp.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSignUp.Location = new System.Drawing.Point(221, 176);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(181, 41);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Sign In";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(17, 176);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(181, 41);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BackColor = System.Drawing.Color.Silver;
            this.txtBoxPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBoxPass.BackgroundImage")));
            this.txtBoxPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBoxPass.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBoxPass.Icon = ((System.Drawing.Image)(resources.GetObject("txtBoxPass.Icon")));
            this.txtBoxPass.Location = new System.Drawing.Point(165, 94);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(253, 52);
            this.txtBoxPass.TabIndex = 1;
            this.txtBoxPass.text = "";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.Silver;
            this.txtBoxUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBoxUsername.BackgroundImage")));
            this.txtBoxUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBoxUsername.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBoxUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtBoxUsername.Icon")));
            this.txtBoxUsername.Location = new System.Drawing.Point(165, 34);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(253, 52);
            this.txtBoxUsername.TabIndex = 0;
            this.txtBoxUsername.text = "";
            // 
            // girisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 261);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "girisEkran";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTextbox txtBoxUsername;
        private Bunifu.Framework.UI.BunifuTextbox txtBoxPass;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignUp;
    }
}

