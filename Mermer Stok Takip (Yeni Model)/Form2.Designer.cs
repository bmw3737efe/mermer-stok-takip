namespace Mermer_Stok_Takip__Yeni_Model_
{
    partial class Form2
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
            this.gvMalzemeler = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBirim = new System.Windows.Forms.ComboBox();
            this.tbMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btEkle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bilgiDataSet1 = new Mermer_Stok_Takip__Yeni_Model_.bilgiDataSet1();
            this.verilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verilerTableAdapter = new Mermer_Stok_Takip__Yeni_Model_.bilgiDataSet1TableAdapters.verilerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvMalzemeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMalzemeler
            // 
            this.gvMalzemeler.AllowUserToOrderColumns = true;
            this.gvMalzemeler.AutoGenerateColumns = false;
            this.gvMalzemeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMalzemeler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvMalzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMalzemeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maDataGridViewTextBoxColumn,
            this.mbDataGridViewTextBoxColumn,
            this.mtDataGridViewTextBoxColumn});
            this.gvMalzemeler.DataSource = this.verilerBindingSource;
            this.gvMalzemeler.Location = new System.Drawing.Point(-2, 207);
            this.gvMalzemeler.Margin = new System.Windows.Forms.Padding(2);
            this.gvMalzemeler.Name = "gvMalzemeler";
            this.gvMalzemeler.RowTemplate.Height = 24;
            this.gvMalzemeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMalzemeler.Size = new System.Drawing.Size(540, 122);
            this.gvMalzemeler.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(114, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Birimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(98, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Markası";
            // 
            // cbBirim
            // 
            this.cbBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBirim.FormattingEnabled = true;
            this.cbBirim.Items.AddRange(new object[] {
            "Metre",
            "Cm"});
            this.cbBirim.Location = new System.Drawing.Point(219, 44);
            this.cbBirim.Margin = new System.Windows.Forms.Padding(2);
            this.cbBirim.Name = "cbBirim";
            this.cbBirim.Size = new System.Drawing.Size(167, 32);
            this.cbBirim.TabIndex = 16;
            // 
            // tbMalzemeAdi
            // 
            this.tbMalzemeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMalzemeAdi.Location = new System.Drawing.Point(219, 7);
            this.tbMalzemeAdi.Margin = new System.Windows.Forms.Padding(2);
            this.tbMalzemeAdi.Name = "tbMalzemeAdi";
            this.tbMalzemeAdi.Size = new System.Drawing.Size(167, 29);
            this.tbMalzemeAdi.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Malzeme Adı:";
            // 
            // btEkle
            // 
            this.btEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btEkle.Location = new System.Drawing.Point(12, 126);
            this.btEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(373, 37);
            this.btEkle.TabIndex = 13;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Afyon",
            "Marmara\t",
            "Bursa",
            "Granit ",
            "Galaxy"});
            this.comboBox1.Location = new System.Drawing.Point(219, 84);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 32);
            this.comboBox1.TabIndex = 21;
            // 
            // bilgiDataSet1
            // 
            this.bilgiDataSet1.DataSetName = "bilgiDataSet1";
            this.bilgiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verilerBindingSource
            // 
            this.verilerBindingSource.DataMember = "veriler";
            this.verilerBindingSource.DataSource = this.bilgiDataSet1;
            // 
            // verilerTableAdapter
            // 
            this.verilerTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // maDataGridViewTextBoxColumn
            // 
            this.maDataGridViewTextBoxColumn.DataPropertyName = "m_a";
            this.maDataGridViewTextBoxColumn.HeaderText = "m_a";
            this.maDataGridViewTextBoxColumn.Name = "maDataGridViewTextBoxColumn";
            // 
            // mbDataGridViewTextBoxColumn
            // 
            this.mbDataGridViewTextBoxColumn.DataPropertyName = "m_b";
            this.mbDataGridViewTextBoxColumn.HeaderText = "m_b";
            this.mbDataGridViewTextBoxColumn.Name = "mbDataGridViewTextBoxColumn";
            // 
            // mtDataGridViewTextBoxColumn
            // 
            this.mtDataGridViewTextBoxColumn.DataPropertyName = "m_t";
            this.mtDataGridViewTextBoxColumn.HeaderText = "m_t";
            this.mtDataGridViewTextBoxColumn.Name = "mtDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(13, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(373, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(538, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gvMalzemeler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBirim);
            this.Controls.Add(this.tbMalzemeAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEkle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMalzemeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMalzemeler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBirim;
        private System.Windows.Forms.TextBox tbMalzemeAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.ComboBox comboBox1;
        private bilgiDataSet1 bilgiDataSet1;
        private System.Windows.Forms.BindingSource verilerBindingSource;
        private bilgiDataSet1TableAdapters.verilerTableAdapter verilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}