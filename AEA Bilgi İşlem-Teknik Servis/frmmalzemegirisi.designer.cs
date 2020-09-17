namespace AEA_Bilgi_İşlem_Teknik_Servis
{
    partial class frmmalzemegirisi
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
            this.txtmalzemeadi = new System.Windows.Forms.TextBox();
            this.cmbmalzemecinsi = new System.Windows.Forms.ComboBox();
            this.dtgiris = new System.Windows.Forms.DateTimePicker();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.lblmalzemeadi = new System.Windows.Forms.Label();
            this.lblmalzemecinsi = new System.Windows.Forms.Label();
            this.lblgiristarihi = new System.Windows.Forms.Label();
            this.lblaciklama = new System.Windows.Forms.Label();
            this.bkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmalzemeadi
            // 
            this.txtmalzemeadi.Location = new System.Drawing.Point(205, 9);
            this.txtmalzemeadi.Name = "txtmalzemeadi";
            this.txtmalzemeadi.Size = new System.Drawing.Size(175, 20);
            this.txtmalzemeadi.TabIndex = 0;
            // 
            // cmbmalzemecinsi
            // 
            this.cmbmalzemecinsi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmalzemecinsi.FormattingEnabled = true;
            this.cmbmalzemecinsi.Location = new System.Drawing.Point(205, 35);
            this.cmbmalzemecinsi.Name = "cmbmalzemecinsi";
            this.cmbmalzemecinsi.Size = new System.Drawing.Size(175, 21);
            this.cmbmalzemecinsi.TabIndex = 1;
            this.cmbmalzemecinsi.SelectedIndexChanged += new System.EventHandler(this.cmbmalzemecinsi_SelectedIndexChanged);
            // 
            // dtgiris
            // 
            this.dtgiris.Location = new System.Drawing.Point(205, 106);
            this.dtgiris.Name = "dtgiris";
            this.dtgiris.Size = new System.Drawing.Size(175, 20);
            this.dtgiris.TabIndex = 2;
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(205, 135);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(175, 50);
            this.txtaciklama.TabIndex = 3;
            // 
            // lblmalzemeadi
            // 
            this.lblmalzemeadi.AutoSize = true;
            this.lblmalzemeadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmalzemeadi.ForeColor = System.Drawing.Color.White;
            this.lblmalzemeadi.Location = new System.Drawing.Point(83, 7);
            this.lblmalzemeadi.Name = "lblmalzemeadi";
            this.lblmalzemeadi.Size = new System.Drawing.Size(116, 20);
            this.lblmalzemeadi.TabIndex = 4;
            this.lblmalzemeadi.Text = "Malzeme Adı:";
            // 
            // lblmalzemecinsi
            // 
            this.lblmalzemecinsi.AutoSize = true;
            this.lblmalzemecinsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmalzemecinsi.ForeColor = System.Drawing.Color.White;
            this.lblmalzemecinsi.Location = new System.Drawing.Point(70, 33);
            this.lblmalzemecinsi.Name = "lblmalzemecinsi";
            this.lblmalzemecinsi.Size = new System.Drawing.Size(129, 20);
            this.lblmalzemecinsi.TabIndex = 5;
            this.lblmalzemecinsi.Text = "Malzeme Cinsi:";
            this.lblmalzemecinsi.Click += new System.EventHandler(this.lblmalzemecinsi_Click);
            // 
            // lblgiristarihi
            // 
            this.lblgiristarihi.AutoSize = true;
            this.lblgiristarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgiristarihi.ForeColor = System.Drawing.Color.White;
            this.lblgiristarihi.Location = new System.Drawing.Point(105, 106);
            this.lblgiristarihi.Name = "lblgiristarihi";
            this.lblgiristarihi.Size = new System.Drawing.Size(95, 20);
            this.lblgiristarihi.TabIndex = 6;
            this.lblgiristarihi.Text = "Giriş Tarihi";
            // 
            // lblaciklama
            // 
            this.lblaciklama.AutoSize = true;
            this.lblaciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaciklama.ForeColor = System.Drawing.Color.White;
            this.lblaciklama.Location = new System.Drawing.Point(105, 147);
            this.lblaciklama.Name = "lblaciklama";
            this.lblaciklama.Size = new System.Drawing.Size(81, 20);
            this.lblaciklama.TabIndex = 7;
            this.lblaciklama.Text = "Açıklama";
            // 
            // bkaydet
            // 
            this.bkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bkaydet.Location = new System.Drawing.Point(220, 191);
            this.bkaydet.Name = "bkaydet";
            this.bkaydet.Size = new System.Drawing.Size(133, 46);
            this.bkaydet.TabIndex = 8;
            this.bkaydet.Text = "Kaydet ";
            this.bkaydet.UseVisualStyleBackColor = true;
            this.bkaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adedi :";
            // 
            // txtadet
            // 
            this.txtadet.Location = new System.Drawing.Point(205, 73);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(175, 20);
            this.txtadet.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 237);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(515, 176);
            this.dataGridView2.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(386, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 250);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Bölümü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(209, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Arama Kriteri:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 27);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(56, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(684, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 157);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Malzeme Adına Göre Sil";
            // 
            // frmmalzemegirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(913, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadet);
            this.Controls.Add(this.bkaydet);
            this.Controls.Add(this.lblaciklama);
            this.Controls.Add(this.lblgiristarihi);
            this.Controls.Add(this.lblmalzemecinsi);
            this.Controls.Add(this.lblmalzemeadi);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.dtgiris);
            this.Controls.Add(this.cmbmalzemecinsi);
            this.Controls.Add(this.txtmalzemeadi);
            this.Name = "frmmalzemegirisi";
            this.Text = "Malzeme Giriş Ekranı";
            this.Load += new System.EventHandler(this.frmmalzemegirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmalzemeadi;
        private System.Windows.Forms.ComboBox cmbmalzemecinsi;
        private System.Windows.Forms.DateTimePicker dtgiris;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label lblmalzemeadi;
        private System.Windows.Forms.Label lblmalzemecinsi;
        private System.Windows.Forms.Label lblgiristarihi;
        private System.Windows.Forms.Label lblaciklama;
        private System.Windows.Forms.Button bkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}