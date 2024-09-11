namespace ÖDEVV2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTNSonraki = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BTNA = new System.Windows.Forms.RadioButton();
            this.BTNB = new System.Windows.Forms.RadioButton();
            this.BTNc = new System.Windows.Forms.RadioButton();
            this.BTND = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBLSoruno = new System.Windows.Forms.Label();
            this.LBLDogru = new System.Windows.Forms.Label();
            this.LBLYanlıs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSonraki
            // 
            this.BTNSonraki.Location = new System.Drawing.Point(375, 179);
            this.BTNSonraki.Name = "BTNSonraki";
            this.BTNSonraki.Size = new System.Drawing.Size(131, 58);
            this.BTNSonraki.TabIndex = 0;
            this.BTNSonraki.Text = "Sonraki";
            this.BTNSonraki.UseVisualStyleBackColor = true;
            this.BTNSonraki.Click += new System.EventHandler(this.BTNSonraki_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-5, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(374, 186);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // BTNA
            // 
            this.BTNA.AutoSize = true;
            this.BTNA.Location = new System.Drawing.Point(66, 265);
            this.BTNA.Name = "BTNA";
            this.BTNA.Size = new System.Drawing.Size(38, 23);
            this.BTNA.TabIndex = 2;
            this.BTNA.TabStop = true;
            this.BTNA.Text = "A";
            this.BTNA.UseVisualStyleBackColor = true;
            this.BTNA.CheckedChanged += new System.EventHandler(this.BTNA_CheckedChanged);
            // 
            // BTNB
            // 
            this.BTNB.AutoSize = true;
            this.BTNB.Location = new System.Drawing.Point(239, 265);
            this.BTNB.Name = "BTNB";
            this.BTNB.Size = new System.Drawing.Size(37, 23);
            this.BTNB.TabIndex = 3;
            this.BTNB.TabStop = true;
            this.BTNB.Text = "B";
            this.BTNB.UseVisualStyleBackColor = true;
            this.BTNB.CheckedChanged += new System.EventHandler(this.BTNB_CheckedChanged);
            // 
            // BTNc
            // 
            this.BTNc.AutoSize = true;
            this.BTNc.Location = new System.Drawing.Point(66, 314);
            this.BTNc.Name = "BTNc";
            this.BTNc.Size = new System.Drawing.Size(36, 23);
            this.BTNc.TabIndex = 4;
            this.BTNc.TabStop = true;
            this.BTNc.Text = "C";
            this.BTNc.UseVisualStyleBackColor = true;
            this.BTNc.CheckedChanged += new System.EventHandler(this.BTNc_CheckedChanged);
            // 
            // BTND
            // 
            this.BTND.AutoSize = true;
            this.BTND.Location = new System.Drawing.Point(238, 314);
            this.BTND.Name = "BTND";
            this.BTND.Size = new System.Drawing.Size(38, 23);
            this.BTND.TabIndex = 5;
            this.BTND.TabStop = true;
            this.BTND.Text = "D";
            this.BTND.UseVisualStyleBackColor = true;
            this.BTND.CheckedChanged += new System.EventHandler(this.BTND_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dogru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "yanlış:";
            // 
            // LBLSoruno
            // 
            this.LBLSoruno.AutoSize = true;
            this.LBLSoruno.Location = new System.Drawing.Point(489, 63);
            this.LBLSoruno.Name = "LBLSoruno";
            this.LBLSoruno.Size = new System.Drawing.Size(17, 19);
            this.LBLSoruno.TabIndex = 9;
            this.LBLSoruno.Text = "0";
            // 
            // LBLDogru
            // 
            this.LBLDogru.AutoSize = true;
            this.LBLDogru.Location = new System.Drawing.Point(489, 98);
            this.LBLDogru.Name = "LBLDogru";
            this.LBLDogru.Size = new System.Drawing.Size(17, 19);
            this.LBLDogru.TabIndex = 10;
            this.LBLDogru.Text = "0";
            // 
            // LBLYanlıs
            // 
            this.LBLYanlıs.AutoSize = true;
            this.LBLYanlıs.Location = new System.Drawing.Point(488, 137);
            this.LBLYanlıs.Name = "LBLYanlıs";
            this.LBLYanlıs.Size = new System.Drawing.Size(17, 19);
            this.LBLYanlıs.TabIndex = 11;
            this.LBLYanlıs.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(493, 253);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBLYanlıs);
            this.Controls.Add(this.LBLDogru);
            this.Controls.Add(this.LBLSoruno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTND);
            this.Controls.Add(this.BTNc);
            this.Controls.Add(this.BTNB);
            this.Controls.Add(this.BTNA);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BTNSonraki);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSonraki;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton BTNA;
        private System.Windows.Forms.RadioButton BTNB;
        private System.Windows.Forms.RadioButton BTNc;
        private System.Windows.Forms.RadioButton BTND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBLSoruno;
        private System.Windows.Forms.Label LBLDogru;
        private System.Windows.Forms.Label LBLYanlıs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

