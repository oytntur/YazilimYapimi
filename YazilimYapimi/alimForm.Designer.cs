
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
            this.label1 = new System.Windows.Forms.Label();
            this.urunAd = new System.Windows.Forms.Label();
            this.saticiAd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbStok = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alınacak Ürün :";
            // 
            // urunAd
            // 
            this.urunAd.AutoSize = true;
            this.urunAd.Location = new System.Drawing.Point(123, 13);
            this.urunAd.Name = "urunAd";
            this.urunAd.Size = new System.Drawing.Size(46, 17);
            this.urunAd.TabIndex = 1;
            this.urunAd.Text = "label2";
            // 
            // saticiAd
            // 
            this.saticiAd.AutoSize = true;
            this.saticiAd.Location = new System.Drawing.Point(370, 13);
            this.saticiAd.Name = "saticiAd";
            this.saticiAd.Size = new System.Drawing.Size(46, 17);
            this.saticiAd.TabIndex = 3;
            this.saticiAd.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kimden Alınacak :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alınacak Birim Miktarı :";
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Location = new System.Drawing.Point(560, 13);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(46, 17);
            this.lblcost.TabIndex = 7;
            this.lblcost.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birim Fiyatı :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Satın Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbStok
            // 
            this.cmbStok.FormattingEnabled = true;
            this.cmbStok.Location = new System.Drawing.Point(220, 107);
            this.cmbStok.Name = "cmbStok";
            this.cmbStok.Size = new System.Drawing.Size(121, 24);
            this.cmbStok.TabIndex = 9;
            // 
            // alimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 542);
            this.Controls.Add(this.cmbStok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbStok;
    }
}