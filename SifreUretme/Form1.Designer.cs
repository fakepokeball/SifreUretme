namespace SifreUretme
{
    partial class Form1
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
            this.gbxParametreler = new System.Windows.Forms.GroupBox();
            this.cbxKucukHarf = new System.Windows.Forms.CheckBox();
            this.cbxBuyukHarf = new System.Windows.Forms.CheckBox();
            this.cbxRakam = new System.Windows.Forms.CheckBox();
            this.cbxSembol = new System.Windows.Forms.CheckBox();
            this.lblSifreAdedi = new System.Windows.Forms.Label();
            this.lblSifreUzunlugu = new System.Windows.Forms.Label();
            this.nudSifreAdedi = new System.Windows.Forms.NumericUpDown();
            this.nudSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.gbxParametreler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreAdedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxParametreler
            // 
            this.gbxParametreler.Controls.Add(this.btnUret);
            this.gbxParametreler.Controls.Add(this.nudSifreUzunlugu);
            this.gbxParametreler.Controls.Add(this.nudSifreAdedi);
            this.gbxParametreler.Controls.Add(this.lblSifreUzunlugu);
            this.gbxParametreler.Controls.Add(this.lblSifreAdedi);
            this.gbxParametreler.Controls.Add(this.cbxSembol);
            this.gbxParametreler.Controls.Add(this.cbxRakam);
            this.gbxParametreler.Controls.Add(this.cbxBuyukHarf);
            this.gbxParametreler.Controls.Add(this.cbxKucukHarf);
            this.gbxParametreler.Location = new System.Drawing.Point(12, 12);
            this.gbxParametreler.Name = "gbxParametreler";
            this.gbxParametreler.Size = new System.Drawing.Size(219, 231);
            this.gbxParametreler.TabIndex = 0;
            this.gbxParametreler.TabStop = false;
            this.gbxParametreler.Text = "Parametreler";
            // 
            // cbxKucukHarf
            // 
            this.cbxKucukHarf.AutoSize = true;
            this.cbxKucukHarf.Location = new System.Drawing.Point(6, 19);
            this.cbxKucukHarf.Name = "cbxKucukHarf";
            this.cbxKucukHarf.Size = new System.Drawing.Size(80, 17);
            this.cbxKucukHarf.TabIndex = 0;
            this.cbxKucukHarf.Text = "Küçük Harf";
            this.cbxKucukHarf.UseVisualStyleBackColor = true;
            // 
            // cbxBuyukHarf
            // 
            this.cbxBuyukHarf.AutoSize = true;
            this.cbxBuyukHarf.Location = new System.Drawing.Point(6, 42);
            this.cbxBuyukHarf.Name = "cbxBuyukHarf";
            this.cbxBuyukHarf.Size = new System.Drawing.Size(79, 17);
            this.cbxBuyukHarf.TabIndex = 1;
            this.cbxBuyukHarf.Text = "Büyük Harf";
            this.cbxBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // cbxRakam
            // 
            this.cbxRakam.AutoSize = true;
            this.cbxRakam.Location = new System.Drawing.Point(6, 65);
            this.cbxRakam.Name = "cbxRakam";
            this.cbxRakam.Size = new System.Drawing.Size(60, 17);
            this.cbxRakam.TabIndex = 2;
            this.cbxRakam.Text = "Rakam";
            this.cbxRakam.UseVisualStyleBackColor = true;
            // 
            // cbxSembol
            // 
            this.cbxSembol.AutoSize = true;
            this.cbxSembol.Location = new System.Drawing.Point(6, 88);
            this.cbxSembol.Name = "cbxSembol";
            this.cbxSembol.Size = new System.Drawing.Size(61, 17);
            this.cbxSembol.TabIndex = 3;
            this.cbxSembol.Text = "Sembol";
            this.cbxSembol.UseVisualStyleBackColor = true;
            // 
            // lblSifreAdedi
            // 
            this.lblSifreAdedi.AutoSize = true;
            this.lblSifreAdedi.Location = new System.Drawing.Point(3, 138);
            this.lblSifreAdedi.Name = "lblSifreAdedi";
            this.lblSifreAdedi.Size = new System.Drawing.Size(61, 13);
            this.lblSifreAdedi.TabIndex = 4;
            this.lblSifreAdedi.Text = "Şifre Adedi:";
            // 
            // lblSifreUzunlugu
            // 
            this.lblSifreUzunlugu.AutoSize = true;
            this.lblSifreUzunlugu.Location = new System.Drawing.Point(3, 161);
            this.lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            this.lblSifreUzunlugu.Size = new System.Drawing.Size(76, 13);
            this.lblSifreUzunlugu.TabIndex = 5;
            this.lblSifreUzunlugu.Text = "Şifre Uzunluğu";
            // 
            // nudSifreAdedi
            // 
            this.nudSifreAdedi.Location = new System.Drawing.Point(85, 136);
            this.nudSifreAdedi.Name = "nudSifreAdedi";
            this.nudSifreAdedi.Size = new System.Drawing.Size(120, 20);
            this.nudSifreAdedi.TabIndex = 6;
            // 
            // nudSifreUzunlugu
            // 
            this.nudSifreUzunlugu.Location = new System.Drawing.Point(85, 159);
            this.nudSifreUzunlugu.Name = "nudSifreUzunlugu";
            this.nudSifreUzunlugu.Size = new System.Drawing.Size(120, 20);
            this.nudSifreUzunlugu.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 231);
            this.textBox1.TabIndex = 1;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(6, 202);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(80, 23);
            this.btnUret.TabIndex = 8;
            this.btnUret.Text = "Şifre Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 265);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbxParametreler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxParametreler.ResumeLayout(false);
            this.gbxParametreler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreAdedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxParametreler;
        private System.Windows.Forms.NumericUpDown nudSifreUzunlugu;
        private System.Windows.Forms.NumericUpDown nudSifreAdedi;
        private System.Windows.Forms.Label lblSifreUzunlugu;
        private System.Windows.Forms.Label lblSifreAdedi;
        private System.Windows.Forms.CheckBox cbxSembol;
        private System.Windows.Forms.CheckBox cbxRakam;
        private System.Windows.Forms.CheckBox cbxBuyukHarf;
        private System.Windows.Forms.CheckBox cbxKucukHarf;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.TextBox textBox1;
    }
}

