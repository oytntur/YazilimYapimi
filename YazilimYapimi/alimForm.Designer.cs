
namespace YazilimYapimi
{
    partial class alimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alimForm));
            this.label1 = new System.Windows.Forms.Label();
            this.urunAd = new System.Windows.Forms.Label();
            this.saticiAd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuy = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alınacak Ürün :";
            // 
            // urunAd
            // 
            this.urunAd.AutoSize = true;
            this.urunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAd.Location = new System.Drawing.Point(179, 13);
            this.urunAd.Name = "urunAd";
            this.urunAd.Size = new System.Drawing.Size(70, 25);
            this.urunAd.TabIndex = 1;
            this.urunAd.Text = "label2";
            // 
            // saticiAd
            // 
            this.saticiAd.AutoSize = true;
            this.saticiAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saticiAd.Location = new System.Drawing.Point(483, 13);
            this.saticiAd.Name = "saticiAd";
            this.saticiAd.Size = new System.Drawing.Size(70, 25);
            this.saticiAd.TabIndex = 3;
            this.saticiAd.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(290, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kimden Alınacak :";
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcost.Location = new System.Drawing.Point(740, 13);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(70, 25);
            this.lblcost.TabIndex = 7;
            this.lblcost.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(603, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birim Fiyatı :";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(519, 128);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 30);
            this.metroComboBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(254, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alınacak Birim Miktarı :";
            // 
            // btnBuy
            // 
            this.btnBuy.ActiveBorderThickness = 1;
            this.btnBuy.ActiveCornerRadius = 20;
            this.btnBuy.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnBuy.ActiveForecolor = System.Drawing.Color.White;
            this.btnBuy.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnBuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuy.BackgroundImage")));
            this.btnBuy.ButtonText = "Satın Al";
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBuy.IdleBorderThickness = 1;
            this.btnBuy.IdleCornerRadius = 20;
            this.btnBuy.IdleFillColor = System.Drawing.Color.White;
            this.btnBuy.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnBuy.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnBuy.Location = new System.Drawing.Point(329, 199);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(181, 41);
            this.btnBuy.TabIndex = 12;
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // alimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 333);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saticiAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urunAd);
            this.Controls.Add(this.label1);
            this.Name = "alimForm";
            this.Text = "alimForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label urunAd;
        private System.Windows.Forms.Label saticiAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBuy;
    }
}