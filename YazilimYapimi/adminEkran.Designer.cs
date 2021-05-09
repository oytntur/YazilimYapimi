
namespace YazilimYapimi
{
    partial class adminEkran
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.transListView = new System.Windows.Forms.ListView();
            this.urunAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.satanUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1349, 708);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.urunListView);
            this.tabPage1.Controls.Add(this.transListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1341, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün Onay";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1341, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Para Onay";
            // 
            // transListView
            // 
            this.transListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunAd,
            this.urunFiyat,
            this.stok,
            this.satanUser});
            this.transListView.HideSelection = false;
            this.transListView.Location = new System.Drawing.Point(6, 69);
            this.transListView.Name = "transListView";
            this.transListView.Size = new System.Drawing.Size(625, 476);
            this.transListView.TabIndex = 1;
            this.transListView.UseCompatibleStateImageBehavior = false;
            this.transListView.View = System.Windows.Forms.View.Details;
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
            // urunListView
            // 
            this.urunListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.urunListView.HideSelection = false;
            this.urunListView.Location = new System.Drawing.Point(637, 69);
            this.urunListView.Name = "urunListView";
            this.urunListView.Size = new System.Drawing.Size(631, 476);
            this.urunListView.TabIndex = 2;
            this.urunListView.UseCompatibleStateImageBehavior = false;
            this.urunListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stok Miktarı";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Satan Kişi";
            this.columnHeader4.Width = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Onay Bekleyen Ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(863, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Onay Almış Ürünler";
            // 
            // adminEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 733);
            this.Controls.Add(this.tabControl1);
            this.Name = "adminEkran";
            this.Text = "adminEkran";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView transListView;
        private System.Windows.Forms.ColumnHeader urunAd;
        private System.Windows.Forms.ColumnHeader urunFiyat;
        private System.Windows.Forms.ColumnHeader stok;
        private System.Windows.Forms.ColumnHeader satanUser;
        private System.Windows.Forms.ListView urunListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}