namespace Teknik_Servis_Otomasyon
{
    partial class stok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stok));
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxt_tspt = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_islem_fyt = new System.Windows.Forms.TextBox();
            this.txt_islem_tur = new System.Windows.Forms.TextBox();
            this.txt_islem_no = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teknik_Servis_OtomasyonuDataSet = new Teknik_Servis_Otomasyon.Teknik_Servis_OtomasyonuDataSet();
            this.islemnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemtespitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunTableAdapter = new Teknik_Servis_Otomasyon.Teknik_Servis_OtomasyonuDataSetTableAdapters.urunTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_OtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.rtxt_tspt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_islem_fyt);
            this.panel2.Controls.Add(this.txt_islem_tur);
            this.panel2.Controls.Add(this.txt_islem_no);
            this.panel2.Location = new System.Drawing.Point(12, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 242);
            this.panel2.TabIndex = 8;
            // 
            // rtxt_tspt
            // 
            this.rtxt_tspt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunBindingSource, "islem_tespit", true));
            this.rtxt_tspt.Location = new System.Drawing.Point(510, 82);
            this.rtxt_tspt.Name = "rtxt_tspt";
            this.rtxt_tspt.Size = new System.Drawing.Size(206, 62);
            this.rtxt_tspt.TabIndex = 12;
            this.rtxt_tspt.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tespit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "İşlem Fiyat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "İşlem Tür :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "İşlem No :";
            // 
            // txt_islem_fyt
            // 
            this.txt_islem_fyt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunBindingSource, "islem_fiyat", true));
            this.txt_islem_fyt.Location = new System.Drawing.Point(192, 142);
            this.txt_islem_fyt.Name = "txt_islem_fyt";
            this.txt_islem_fyt.Size = new System.Drawing.Size(205, 26);
            this.txt_islem_fyt.TabIndex = 2;
            // 
            // txt_islem_tur
            // 
            this.txt_islem_tur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunBindingSource, "islem_tur", true));
            this.txt_islem_tur.Location = new System.Drawing.Point(192, 100);
            this.txt_islem_tur.Name = "txt_islem_tur";
            this.txt_islem_tur.Size = new System.Drawing.Size(205, 26);
            this.txt_islem_tur.TabIndex = 1;
            // 
            // txt_islem_no
            // 
            this.txt_islem_no.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunBindingSource, "islem_no", true));
            this.txt_islem_no.Enabled = false;
            this.txt_islem_no.Location = new System.Drawing.Point(192, 59);
            this.txt_islem_no.Name = "txt_islem_no";
            this.txt_islem_no.Size = new System.Drawing.Size(205, 26);
            this.txt_islem_no.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 95);
            this.panel1.TabIndex = 7;
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(775, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(77, 67);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(662, 16);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 67);
            this.button8.TabIndex = 7;
            this.button8.Text = " ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(547, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 67);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(435, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 67);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(320, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 67);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(246, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 43);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(176, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 43);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(45, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 43);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(110, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 43);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islemnoDataGridViewTextBoxColumn,
            this.islemturDataGridViewTextBoxColumn,
            this.islemfiyatDataGridViewTextBoxColumn,
            this.islemtespitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(915, 137);
            this.dataGridView1.TabIndex = 6;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "urun";
            this.urunBindingSource.DataSource = this.teknik_Servis_OtomasyonuDataSet;
            // 
            // teknik_Servis_OtomasyonuDataSet
            // 
            this.teknik_Servis_OtomasyonuDataSet.DataSetName = "Teknik_Servis_OtomasyonuDataSet";
            this.teknik_Servis_OtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // islemnoDataGridViewTextBoxColumn
            // 
            this.islemnoDataGridViewTextBoxColumn.DataPropertyName = "islem_no";
            this.islemnoDataGridViewTextBoxColumn.HeaderText = "islem_no";
            this.islemnoDataGridViewTextBoxColumn.Name = "islemnoDataGridViewTextBoxColumn";
            this.islemnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // islemturDataGridViewTextBoxColumn
            // 
            this.islemturDataGridViewTextBoxColumn.DataPropertyName = "islem_tur";
            this.islemturDataGridViewTextBoxColumn.HeaderText = "islem_tur";
            this.islemturDataGridViewTextBoxColumn.Name = "islemturDataGridViewTextBoxColumn";
            // 
            // islemfiyatDataGridViewTextBoxColumn
            // 
            this.islemfiyatDataGridViewTextBoxColumn.DataPropertyName = "islem_fiyat";
            this.islemfiyatDataGridViewTextBoxColumn.HeaderText = "islem_fiyat";
            this.islemfiyatDataGridViewTextBoxColumn.Name = "islemfiyatDataGridViewTextBoxColumn";
            // 
            // islemtespitDataGridViewTextBoxColumn
            // 
            this.islemtespitDataGridViewTextBoxColumn.DataPropertyName = "islem_tespit";
            this.islemtespitDataGridViewTextBoxColumn.HeaderText = "islem_tespit";
            this.islemtespitDataGridViewTextBoxColumn.Name = "islemtespitDataGridViewTextBoxColumn";
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(951, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "stok";
            this.Text = "Tamir";
            this.Load += new System.EventHandler(this.stok_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_OtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtxt_tspt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_islem_fyt;
        private System.Windows.Forms.TextBox txt_islem_tur;
        private System.Windows.Forms.TextBox txt_islem_no;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Teknik_Servis_OtomasyonuDataSet teknik_Servis_OtomasyonuDataSet;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private Teknik_Servis_OtomasyonuDataSetTableAdapters.urunTableAdapter urunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn işlemnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn işlemturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemtespitDataGridViewTextBoxColumn;
    }
}