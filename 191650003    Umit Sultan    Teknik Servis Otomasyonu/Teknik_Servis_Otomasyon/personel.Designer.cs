namespace Teknik_Servis_Otomasyon
{
    partial class personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_dog_yer = new System.Windows.Forms.TextBox();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teknik_Servis_OtomasyonuDataSet = new Teknik_Servis_Otomasyon.Teknik_Servis_OtomasyonuDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dog_tar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_badi = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_sadi = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_per_no = new System.Windows.Forms.TextBox();
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
            this.pernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.babaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogtarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogyeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTableAdapter = new Teknik_Servis_Otomasyon.Teknik_Servis_OtomasyonuDataSetTableAdapters.personelTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_OtomasyonuDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_dog_yer);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_dog_tar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_tc);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_badi);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_mail);
            this.panel2.Controls.Add(this.txt_tel);
            this.panel2.Controls.Add(this.txt_sadi);
            this.panel2.Controls.Add(this.txt_adi);
            this.panel2.Controls.Add(this.txt_per_no);
            this.panel2.Location = new System.Drawing.Point(4, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 301);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Doğum Yeri :";
            // 
            // txt_dog_yer
            // 
            this.txt_dog_yer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "dog_yeri", true));
            this.txt_dog_yer.Location = new System.Drawing.Point(266, 244);
            this.txt_dog_yer.Name = "txt_dog_yer";
            this.txt_dog_yer.Size = new System.Drawing.Size(205, 26);
            this.txt_dog_yer.TabIndex = 19;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.teknik_Servis_OtomasyonuDataSet;
            // 
            // teknik_Servis_OtomasyonuDataSet
            // 
            this.teknik_Servis_OtomasyonuDataSet.DataSetName = "Teknik_Servis_OtomasyonuDataSet";
            this.teknik_Servis_OtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Doğum Tarihi :";
            // 
            // txt_dog_tar
            // 
            this.txt_dog_tar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "dog_tar", true));
            this.txt_dog_tar.Location = new System.Drawing.Point(266, 211);
            this.txt_dog_tar.Name = "txt_dog_tar";
            this.txt_dog_tar.Size = new System.Drawing.Size(205, 26);
            this.txt_dog_tar.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tc :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_tc
            // 
            this.txt_tc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "tcno", true));
            this.txt_tc.Location = new System.Drawing.Point(266, 146);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(205, 26);
            this.txt_tc.TabIndex = 15;
            this.txt_tc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Baba Adı :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_badi
            // 
            this.txt_badi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "baba_adi", true));
            this.txt_badi.Location = new System.Drawing.Point(266, 178);
            this.txt_badi.Name = "txt_badi";
            this.txt_badi.Size = new System.Drawing.Size(205, 26);
            this.txt_badi.TabIndex = 13;
            this.txt_badi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "adres", true));
            this.richTextBox1.Location = new System.Drawing.Point(659, 117);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(206, 153);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "E-Posta :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adres :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Personel No :";
            // 
            // txt_mail
            // 
            this.txt_mail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "eposta", true));
            this.txt_mail.Location = new System.Drawing.Point(659, 79);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(205, 26);
            this.txt_mail.TabIndex = 5;
            // 
            // txt_tel
            // 
            this.txt_tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "tel", true));
            this.txt_tel.Location = new System.Drawing.Point(659, 45);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(205, 26);
            this.txt_tel.TabIndex = 3;
            // 
            // txt_sadi
            // 
            this.txt_sadi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "soyad", true));
            this.txt_sadi.Location = new System.Drawing.Point(266, 114);
            this.txt_sadi.Name = "txt_sadi";
            this.txt_sadi.Size = new System.Drawing.Size(205, 26);
            this.txt_sadi.TabIndex = 2;
            // 
            // txt_adi
            // 
            this.txt_adi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "ad", true));
            this.txt_adi.Location = new System.Drawing.Point(266, 82);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(205, 26);
            this.txt_adi.TabIndex = 1;
            // 
            // txt_per_no
            // 
            this.txt_per_no.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "per_no", true));
            this.txt_per_no.Enabled = false;
            this.txt_per_no.Location = new System.Drawing.Point(266, 48);
            this.txt_per_no.Name = "txt_per_no";
            this.txt_per_no.Size = new System.Drawing.Size(205, 26);
            this.txt_per_no.TabIndex = 0;
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
            this.panel1.Location = new System.Drawing.Point(3, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 94);
            this.panel1.TabIndex = 7;
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(974, 13);
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
            this.button8.Location = new System.Drawing.Point(828, 13);
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
            this.button7.Location = new System.Drawing.Point(673, 13);
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
            this.button6.Location = new System.Drawing.Point(525, 13);
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
            this.button5.Location = new System.Drawing.Point(383, 13);
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
            this.button4.Location = new System.Drawing.Point(278, 25);
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
            this.button3.Location = new System.Drawing.Point(190, 25);
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
            this.button1.Location = new System.Drawing.Point(23, 25);
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
            this.button2.Location = new System.Drawing.Point(102, 25);
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
            this.pernoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tcnoDataGridViewTextBoxColumn,
            this.babaadiDataGridViewTextBoxColumn,
            this.dogtarDataGridViewTextBoxColumn,
            this.dogyeriDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 137);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pernoDataGridViewTextBoxColumn
            // 
            this.pernoDataGridViewTextBoxColumn.DataPropertyName = "per_no";
            this.pernoDataGridViewTextBoxColumn.HeaderText = "per_no";
            this.pernoDataGridViewTextBoxColumn.Name = "pernoDataGridViewTextBoxColumn";
            this.pernoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // tcnoDataGridViewTextBoxColumn
            // 
            this.tcnoDataGridViewTextBoxColumn.DataPropertyName = "tcno";
            this.tcnoDataGridViewTextBoxColumn.HeaderText = "tcno";
            this.tcnoDataGridViewTextBoxColumn.Name = "tcnoDataGridViewTextBoxColumn";
            // 
            // babaadiDataGridViewTextBoxColumn
            // 
            this.babaadiDataGridViewTextBoxColumn.DataPropertyName = "baba_adi";
            this.babaadiDataGridViewTextBoxColumn.HeaderText = "baba_adi";
            this.babaadiDataGridViewTextBoxColumn.Name = "babaadiDataGridViewTextBoxColumn";
            // 
            // dogtarDataGridViewTextBoxColumn
            // 
            this.dogtarDataGridViewTextBoxColumn.DataPropertyName = "dog_tar";
            this.dogtarDataGridViewTextBoxColumn.HeaderText = "dog_tar";
            this.dogtarDataGridViewTextBoxColumn.Name = "dogtarDataGridViewTextBoxColumn";
            // 
            // dogyeriDataGridViewTextBoxColumn
            // 
            this.dogyeriDataGridViewTextBoxColumn.DataPropertyName = "dog_yeri";
            this.dogyeriDataGridViewTextBoxColumn.HeaderText = "dog_yeri";
            this.dogyeriDataGridViewTextBoxColumn.Name = "dogyeriDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "eposta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "eposta";
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1083, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "personel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.personel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_OtomasyonuDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_sadi;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_per_no;
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
        private System.Windows.Forms.BindingSource personelBindingSource;
        private Teknik_Servis_OtomasyonuDataSetTableAdapters.personelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn babaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogtarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogyeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_badi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_dog_yer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_dog_tar;
    }
}