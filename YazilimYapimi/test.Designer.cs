
namespace YazilimYapimi
{
    partial class test
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.excelLogTableAdapter = new YazilimYapimi.AppDataTableAdapters.excelLogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAdDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.excelLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "urunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "urunAd";
            this.urunAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            this.urunAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "miktar";
            this.miktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
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
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(665, 489);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(136, 39);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Yazdır";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // excelLogTableAdapter
            // 
            this.excelLogTableAdapter.ClearBeforeFill = true;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 542);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "test";
            this.Text = "Yazdırma Formu";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private AppData appData;
        private System.Windows.Forms.BindingSource excelLogBindingSource;
        private AppDataTableAdapters.excelLogTableAdapter excelLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}