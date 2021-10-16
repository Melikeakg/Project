
namespace Project.Forms
{
    partial class FormMemberCodeEncode
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKamera = new System.Windows.Forms.Label();
            this.comboxKamera = new System.Windows.Forms.ComboBox();
            this.btnKamera = new System.Windows.Forms.Button();
            this.pictureBoxKamera = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboxAdSoyad = new System.Windows.Forms.ComboBox();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.comboxTarih = new System.Windows.Forms.ComboBox();
            this.comboxGirisHakki = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamera)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGiris.Location = new System.Drawing.Point(535, 395);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(86, 30);
            this.btnGiris.TabIndex = 17;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(538, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "label";
            this.label1.Visible = false;
            // 
            // lblKamera
            // 
            this.lblKamera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKamera.AutoSize = true;
            this.lblKamera.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.lblKamera.Location = new System.Drawing.Point(407, 81);
            this.lblKamera.Name = "lblKamera";
            this.lblKamera.Size = new System.Drawing.Size(61, 19);
            this.lblKamera.TabIndex = 19;
            this.lblKamera.Text = "Kamera";
            // 
            // comboxKamera
            // 
            this.comboxKamera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboxKamera.FormattingEnabled = true;
            this.comboxKamera.Location = new System.Drawing.Point(490, 81);
            this.comboxKamera.Name = "comboxKamera";
            this.comboxKamera.Size = new System.Drawing.Size(146, 21);
            this.comboxKamera.TabIndex = 20;
            // 
            // btnKamera
            // 
            this.btnKamera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnKamera.FlatAppearance.BorderSize = 0;
            this.btnKamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKamera.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKamera.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKamera.Location = new System.Drawing.Point(651, 75);
            this.btnKamera.Name = "btnKamera";
            this.btnKamera.Size = new System.Drawing.Size(86, 30);
            this.btnKamera.TabIndex = 21;
            this.btnKamera.Text = "Kamera Aç";
            this.btnKamera.UseVisualStyleBackColor = false;
            this.btnKamera.Click += new System.EventHandler(this.btnKamera_Click);
            // 
            // pictureBoxKamera
            // 
            this.pictureBoxKamera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxKamera.Location = new System.Drawing.Point(411, 124);
            this.pictureBoxKamera.Name = "pictureBoxKamera";
            this.pictureBoxKamera.Size = new System.Drawing.Size(326, 205);
            this.pictureBoxKamera.TabIndex = 22;
            this.pictureBoxKamera.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboxAdSoyad
            // 
            this.comboxAdSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboxAdSoyad.BackColor = System.Drawing.SystemColors.Window;
            this.comboxAdSoyad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboxAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.comboxAdSoyad.FormattingEnabled = true;
            this.comboxAdSoyad.Location = new System.Drawing.Point(217, 152);
            this.comboxAdSoyad.Name = "comboxAdSoyad";
            this.comboxAdSoyad.Size = new System.Drawing.Size(149, 26);
            this.comboxAdSoyad.TabIndex = 26;
            // 
            // txtKisi
            // 
            this.txtKisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKisi.Location = new System.Drawing.Point(411, 356);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(326, 20);
            this.txtKisi.TabIndex = 27;
            // 
            // comboxTarih
            // 
            this.comboxTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboxTarih.BackColor = System.Drawing.SystemColors.Window;
            this.comboxTarih.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboxTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.comboxTarih.FormattingEnabled = true;
            this.comboxTarih.Location = new System.Drawing.Point(217, 272);
            this.comboxTarih.Name = "comboxTarih";
            this.comboxTarih.Size = new System.Drawing.Size(149, 26);
            this.comboxTarih.TabIndex = 28;
            // 
            // comboxGirisHakki
            // 
            this.comboxGirisHakki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboxGirisHakki.BackColor = System.Drawing.SystemColors.Window;
            this.comboxGirisHakki.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboxGirisHakki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.comboxGirisHakki.FormattingEnabled = true;
            this.comboxGirisHakki.Location = new System.Drawing.Point(217, 217);
            this.comboxGirisHakki.Name = "comboxGirisHakki";
            this.comboxGirisHakki.Size = new System.Drawing.Size(149, 26);
            this.comboxGirisHakki.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(100, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(100, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 38);
            this.label3.TabIndex = 31;
            this.label3.Text = "Üyeliğinizin \r\nbiteceği tarih:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label4.Location = new System.Drawing.Point(100, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 38);
            this.label4.TabIndex = 32;
            this.label4.Text = "Kalan \r\ngiriş hakkınız:";
            // 
            // FormMemberCodeEncode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(860, 595);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboxGirisHakki);
            this.Controls.Add(this.comboxTarih);
            this.Controls.Add(this.txtKisi);
            this.Controls.Add(this.comboxAdSoyad);
            this.Controls.Add(this.pictureBoxKamera);
            this.Controls.Add(this.btnKamera);
            this.Controls.Add(this.comboxKamera);
            this.Controls.Add(this.lblKamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMemberCodeEncode";
            this.Text = "Karekod Okut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMemberCodeEncode_FormClosing_1);
            this.Load += new System.EventHandler(this.FormMemberCodeEncode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKamera;
        private System.Windows.Forms.ComboBox comboxKamera;
        private System.Windows.Forms.Button btnKamera;
        private System.Windows.Forms.PictureBox pictureBoxKamera;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboxAdSoyad;
        private System.Windows.Forms.TextBox txtKisi;
        private System.Windows.Forms.ComboBox comboxTarih;
        private System.Windows.Forms.ComboBox comboxGirisHakki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}