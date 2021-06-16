
namespace YazilimYapimi
{
    partial class Yazdir
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excelLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new YazilimYapimi.AppData();
            this.YazdirmaBtn = new MetroFramework.Controls.MetroButton();
            this.excelLogTableAdapter = new YazilimYapimi.AppDataTableAdapters.excelLogTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Goster = new MetroFramework.Controls.MetroButton();
            this.Cikis = new System.Windows.Forms.Button();
            this.Don = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAdDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.excelLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 440);
            this.dataGridView1.TabIndex = 0;
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "urunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "urunAd";
            this.urunAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            this.urunAdDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "miktar";
            this.miktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.miktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // excelLogBindingSource
            // 
            this.excelLogBindingSource.DataMember = "excelLog";
            this.excelLogBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // YazdirmaBtn
            // 
            this.YazdirmaBtn.Location = new System.Drawing.Point(946, 415);
            this.YazdirmaBtn.Name = "YazdirmaBtn";
            this.YazdirmaBtn.Size = new System.Drawing.Size(185, 48);
            this.YazdirmaBtn.TabIndex = 1;
            this.YazdirmaBtn.Text = "Tabloyu Yazdır";
            this.YazdirmaBtn.Click += new System.EventHandler(this.YazdirmaBtn_Click);
            // 
            // excelLogTableAdapter
            // 
            this.excelLogTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(931, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(931, 191);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bitiş Tarihi :";
            // 
            // Goster
            // 
            this.Goster.Location = new System.Drawing.Point(915, 249);
            this.Goster.Name = "Goster";
            this.Goster.Size = new System.Drawing.Size(146, 39);
            this.Goster.TabIndex = 6;
            this.Goster.Text = "Tabloyu Güncelle";
            this.Goster.Click += new System.EventHandler(this.Goster_Click);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.Transparent;
            this.Cikis.BackgroundImage = global::YazilimYapimi.Properties.Resources.exit;
            this.Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cikis.Location = new System.Drawing.Point(984, 31);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(65, 40);
            this.Cikis.TabIndex = 24;
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // Don
            // 
            this.Don.BackColor = System.Drawing.Color.Transparent;
            this.Don.BackgroundImage = global::YazilimYapimi.Properties.Resources.left;
            this.Don.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Don.Location = new System.Drawing.Point(895, 31);
            this.Don.Name = "Don";
            this.Don.Size = new System.Drawing.Size(65, 40);
            this.Don.TabIndex = 23;
            this.Don.UseVisualStyleBackColor = false;
            this.Don.Click += new System.EventHandler(this.Don_Click);
            // 
            // Yazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 540);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.Don);
            this.Controls.Add(this.Goster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.YazdirmaBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Yazdir";
            this.Text = "Görüntüle ve Yazdır";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton YazdirmaBtn;
        private AppData appData;
        private System.Windows.Forms.BindingSource excelLogBindingSource;
        private AppDataTableAdapters.excelLogTableAdapter excelLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton Goster;
        private System.Windows.Forms.Button Don;
        private System.Windows.Forms.Button Cikis;
    }
}