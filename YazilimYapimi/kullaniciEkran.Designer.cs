
namespace YazilimYapimi
{
    partial class kullaniciEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.urunListView = new System.Windows.Forms.ListView();
            this.urunAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.satanUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1115, 518);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage1.Controls.Add(this.lblAdSoyad);
            this.tabPage1.Controls.Add(this.lblMoney);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.urunListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1107, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürünler";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(1014, 35);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(87, 17);
            this.lblMoney.TabIndex = 2;
            this.lblMoney.Text = "Mevcut Para";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(954, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bakiye :";
            // 
            // urunListView
            // 
            this.urunListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunAd,
            this.urunFiyat,
            this.stok,
            this.satanUser});
            this.urunListView.HideSelection = false;
            this.urunListView.Location = new System.Drawing.Point(7, 7);
            this.urunListView.Name = "urunListView";
            this.urunListView.Size = new System.Drawing.Size(941, 476);
            this.urunListView.TabIndex = 0;
            this.urunListView.UseCompatibleStateImageBehavior = false;
            this.urunListView.View = System.Windows.Forms.View.Details;
            this.urunListView.DoubleClick += new System.EventHandler(this.urunListView_DoubleClick);
            // 
            // urunAd
            // 
            this.urunAd.Text = "Ürün Adı";
            this.urunAd.Width = 130;
            // 
            // urunFiyat
            // 
            this.urunFiyat.Text = "Fiyat";
            this.urunFiyat.Width = 72;
            // 
            // stok
            // 
            this.stok.Text = "Stok Miktarı";
            this.stok.Width = 104;
            // 
            // satanUser
            // 
            this.satanUser.Text = "Satan Kişi";
            this.satanUser.Width = 146;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1107, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Para/Ürün Ekle";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(983, 7);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(87, 17);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "Mevcut Para";
            // 
            // kullaniciEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 542);
            this.Controls.Add(this.tabControl1);
            this.Name = "kullaniciEkran";
            this.Text = "kullaniciEkran";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView urunListView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader urunAd;
        private System.Windows.Forms.ColumnHeader urunFiyat;
        private System.Windows.Forms.ColumnHeader stok;
        private System.Windows.Forms.ColumnHeader satanUser;
        private System.Windows.Forms.Label lblAdSoyad;
    }
}