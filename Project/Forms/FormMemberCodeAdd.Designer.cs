
namespace Project.Forms
{
    partial class FormMemberCodeAdd
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
            this.comboUyeID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemberNameSurname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.pictureBoxQr = new System.Windows.Forms.PictureBox();
            this.btnIndir = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQr)).BeginInit();
            this.SuspendLayout();
            // 
            // comboUyeID
            // 
            this.comboUyeID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboUyeID.FormattingEnabled = true;
            this.comboUyeID.Location = new System.Drawing.Point(245, 120);
            this.comboUyeID.Name = "comboUyeID";
            this.comboUyeID.Size = new System.Drawing.Size(135, 21);
            this.comboUyeID.TabIndex = 61;
            this.comboUyeID.SelectionChangeCommitted += new System.EventHandler(this.comboUyeID_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(178, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 36);
            this.label5.TabIndex = 60;
            this.label5.Text = "Üye ID\'si\r\nseçiniz:";
            // 
            // txtMemberNameSurname
            // 
            this.txtMemberNameSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMemberNameSurname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMemberNameSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemberNameSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtMemberNameSurname.Location = new System.Drawing.Point(512, 121);
            this.txtMemberNameSurname.Name = "txtMemberNameSurname";
            this.txtMemberNameSurname.Size = new System.Drawing.Size(135, 13);
            this.txtMemberNameSurname.TabIndex = 64;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(512, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 1);
            this.panel1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(404, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Üye Ad-Soyad:";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnOlustur.FlatAppearance.BorderSize = 0;
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlustur.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOlustur.Location = new System.Drawing.Point(240, 175);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(90, 35);
            this.btnOlustur.TabIndex = 66;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // pictureBoxQr
            // 
            this.pictureBoxQr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxQr.Location = new System.Drawing.Point(288, 227);
            this.pictureBoxQr.Name = "pictureBoxQr";
            this.pictureBoxQr.Size = new System.Drawing.Size(291, 175);
            this.pictureBoxQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQr.TabIndex = 67;
            this.pictureBoxQr.TabStop = false;
            // 
            // btnIndir
            // 
            this.btnIndir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIndir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnIndir.FlatAppearance.BorderSize = 0;
            this.btnIndir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndir.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIndir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIndir.Location = new System.Drawing.Point(529, 175);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(90, 35);
            this.btnIndir.TabIndex = 68;
            this.btnIndir.Text = "İndir";
            this.btnIndir.UseVisualStyleBackColor = false;
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGuncelle.Location = new System.Drawing.Point(432, 175);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(90, 35);
            this.btnGuncelle.TabIndex = 70;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSee
            // 
            this.btnSee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSee.FlatAppearance.BorderSize = 0;
            this.btnSee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSee.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSee.Location = new System.Drawing.Point(336, 175);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(90, 35);
            this.btnSee.TabIndex = 71;
            this.btnSee.Text = "Görüntüle";
            this.btnSee.UseVisualStyleBackColor = false;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // FormMemberCodeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(844, 556);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnIndir);
            this.Controls.Add(this.pictureBoxQr);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.txtMemberNameSurname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboUyeID);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMemberCodeAdd";
            this.Text = "Karekod Oluştur";
            this.Load += new System.EventHandler(this.FormMemberCodeAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboUyeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMemberNameSurname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.PictureBox pictureBoxQr;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSee;
    }
}