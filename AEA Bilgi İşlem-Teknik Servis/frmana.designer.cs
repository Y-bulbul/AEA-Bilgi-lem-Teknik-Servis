namespace AEA_Bilgi_İşlem_Teknik_Servis
{
    partial class frmana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmana));
            this.btnmalzeme = new System.Windows.Forms.Button();
            this.btnariza = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmalzeme
            // 
            this.btnmalzeme.Font = new System.Drawing.Font("Myriad Pro Cond", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmalzeme.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnmalzeme.Location = new System.Drawing.Point(58, 32);
            this.btnmalzeme.Name = "btnmalzeme";
            this.btnmalzeme.Size = new System.Drawing.Size(115, 81);
            this.btnmalzeme.TabIndex = 0;
            this.btnmalzeme.Text = "Malzeme Modülü";
            this.btnmalzeme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmalzeme.UseVisualStyleBackColor = true;
            this.btnmalzeme.Click += new System.EventHandler(this.btnmalzeme_Click);
            // 
            // btnariza
            // 
            this.btnariza.Font = new System.Drawing.Font("Myriad Pro Cond", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnariza.Location = new System.Drawing.Point(335, 32);
            this.btnariza.Name = "btnariza";
            this.btnariza.Size = new System.Drawing.Size(115, 81);
            this.btnariza.TabIndex = 1;
            this.btnariza.Text = "Arıza İşlemleri Modülü";
            this.btnariza.UseVisualStyleBackColor = true;
            this.btnariza.Click += new System.EventHandler(this.btnariza_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Myriad Pro Cond", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(58, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yetkili Kullanıcı Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Myriad Pro Cond", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(335, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 81);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kullanıcı Şifresi Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Myriad Pro Cond", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(200, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 81);
            this.button3.TabIndex = 4;
            this.button3.Text = "Bilgi İşlem Modülü";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 332);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnariza);
            this.Controls.Add(this.btnmalzeme);
            this.Name = "frmana";
            this.Text = "Ana Form ";
            this.Load += new System.EventHandler(this.frmana_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmalzeme;
        private System.Windows.Forms.Button btnariza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

