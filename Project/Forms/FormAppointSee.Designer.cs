
namespace Project.Forms
{
    partial class FormAppointSee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppointSee));
            this.btnSave = new System.Windows.Forms.Button();
            this.panelSeeAppointment = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRandevuSaati = new System.Windows.Forms.Label();
            this.labelDoctorAdSoyad = new System.Windows.Forms.Label();
            this.labelRandevuTarihi = new System.Windows.Forms.Label();
            this.labelUyeTC = new System.Windows.Forms.Label();
            this.labelUyeAdSoyad = new System.Windows.Forms.Label();
            this.dataGridAppointment = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTCSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTCSearch = new System.Windows.Forms.Button();
            this.btnSee = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.panelSeeAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(614, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 31);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Yazdır";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelSeeAppointment
            // 
            this.panelSeeAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSeeAppointment.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSeeAppointment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSeeAppointment.Controls.Add(this.label9);
            this.panelSeeAppointment.Controls.Add(this.label8);
            this.panelSeeAppointment.Controls.Add(this.label7);
            this.panelSeeAppointment.Controls.Add(this.label6);
            this.panelSeeAppointment.Controls.Add(this.label5);
            this.panelSeeAppointment.Controls.Add(this.label4);
            this.panelSeeAppointment.Controls.Add(this.label3);
            this.panelSeeAppointment.Controls.Add(this.label2);
            this.panelSeeAppointment.Controls.Add(this.label1);
            this.panelSeeAppointment.Controls.Add(this.labelRandevuSaati);
            this.panelSeeAppointment.Controls.Add(this.labelDoctorAdSoyad);
            this.panelSeeAppointment.Controls.Add(this.labelRandevuTarihi);
            this.panelSeeAppointment.Controls.Add(this.labelUyeTC);
            this.panelSeeAppointment.Controls.Add(this.labelUyeAdSoyad);
            this.panelSeeAppointment.Location = new System.Drawing.Point(505, 117);
            this.panelSeeAppointment.MaximumSize = new System.Drawing.Size(298, 356);
            this.panelSeeAppointment.Name = "panelSeeAppointment";
            this.panelSeeAppointment.Size = new System.Drawing.Size(279, 356);
            this.panelSeeAppointment.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label9.Location = new System.Drawing.Point(110, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 36);
            this.label9.TabIndex = 13;
            this.label9.Text = "|";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label8.Location = new System.Drawing.Point(139, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Randevu Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label7.Location = new System.Drawing.Point(36, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Randevu Saati:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label6.Location = new System.Drawing.Point(36, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Randevu Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(36, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Diyetisyen Adı Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label4.Location = new System.Drawing.Point(36, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Randevu Alan Kişi TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Randevu Alan Kişi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sayın üyemiz almış olduğunuz randevu bilgileri \r\naşağıda verilmiştir. Sağlıklı ve" +
    " fit günler dileriz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "FITGYM";
            // 
            // labelRandevuSaati
            // 
            this.labelRandevuSaati.AutoSize = true;
            this.labelRandevuSaati.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRandevuSaati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.labelRandevuSaati.Location = new System.Drawing.Point(176, 291);
            this.labelRandevuSaati.Name = "labelRandevuSaati";
            this.labelRandevuSaati.Size = new System.Drawing.Size(0, 15);
            this.labelRandevuSaati.TabIndex = 4;
            // 
            // labelDoctorAdSoyad
            // 
            this.labelDoctorAdSoyad.AutoSize = true;
            this.labelDoctorAdSoyad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDoctorAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.labelDoctorAdSoyad.Location = new System.Drawing.Point(176, 211);
            this.labelDoctorAdSoyad.Name = "labelDoctorAdSoyad";
            this.labelDoctorAdSoyad.Size = new System.Drawing.Size(0, 15);
            this.labelDoctorAdSoyad.TabIndex = 3;
            // 
            // labelRandevuTarihi
            // 
            this.labelRandevuTarihi.AutoSize = true;
            this.labelRandevuTarihi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRandevuTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.labelRandevuTarihi.Location = new System.Drawing.Point(176, 252);
            this.labelRandevuTarihi.Name = "labelRandevuTarihi";
            this.labelRandevuTarihi.Size = new System.Drawing.Size(0, 15);
            this.labelRandevuTarihi.TabIndex = 2;
            // 
            // labelUyeTC
            // 
            this.labelUyeTC.AutoSize = true;
            this.labelUyeTC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUyeTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.labelUyeTC.Location = new System.Drawing.Point(176, 169);
            this.labelUyeTC.Name = "labelUyeTC";
            this.labelUyeTC.Size = new System.Drawing.Size(0, 15);
            this.labelUyeTC.TabIndex = 1;
            // 
            // labelUyeAdSoyad
            // 
            this.labelUyeAdSoyad.AutoSize = true;
            this.labelUyeAdSoyad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUyeAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.labelUyeAdSoyad.Location = new System.Drawing.Point(176, 133);
            this.labelUyeAdSoyad.Name = "labelUyeAdSoyad";
            this.labelUyeAdSoyad.Size = new System.Drawing.Size(0, 15);
            this.labelUyeAdSoyad.TabIndex = 0;
            // 
            // dataGridAppointment
            // 
            this.dataGridAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridAppointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridAppointment.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAppointment.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAppointment.Location = new System.Drawing.Point(83, 117);
            this.dataGridAppointment.Name = "dataGridAppointment";
            this.dataGridAppointment.Size = new System.Drawing.Size(404, 356);
            this.dataGridAppointment.TabIndex = 76;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.label10.Location = new System.Drawing.Point(80, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 79;
            this.label10.Text = "TC giriniz:";
            // 
            // TxtTCSearch
            // 
            this.TxtTCSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTCSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtTCSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTCSearch.Location = new System.Drawing.Point(154, 84);
            this.TxtTCSearch.Name = "TxtTCSearch";
            this.TxtTCSearch.Size = new System.Drawing.Size(113, 13);
            this.TxtTCSearch.TabIndex = 80;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(154, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 1);
            this.panel1.TabIndex = 81;
            // 
            // btnTCSearch
            // 
            this.btnTCSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTCSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnTCSearch.FlatAppearance.BorderSize = 0;
            this.btnTCSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTCSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTCSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTCSearch.Location = new System.Drawing.Point(275, 75);
            this.btnTCSearch.Name = "btnTCSearch";
            this.btnTCSearch.Size = new System.Drawing.Size(55, 30);
            this.btnTCSearch.TabIndex = 82;
            this.btnTCSearch.Text = "Ara";
            this.btnTCSearch.UseVisualStyleBackColor = false;
            this.btnTCSearch.Click += new System.EventHandler(this.btnTCSearch_Click);
            // 
            // btnSee
            // 
            this.btnSee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSee.FlatAppearance.BorderSize = 0;
            this.btnSee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSee.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSee.Location = new System.Drawing.Point(336, 75);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(85, 30);
            this.btnSee.TabIndex = 83;
            this.btnSee.Text = "Görüntüle";
            this.btnSee.UseVisualStyleBackColor = false;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // btnList
            // 
            this.btnList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnList.Location = new System.Drawing.Point(426, 75);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(61, 30);
            this.btnList.TabIndex = 84;
            this.btnList.Text = "Liste";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // FormAppointSee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(860, 595);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.btnTCSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtTCSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelSeeAppointment);
            this.Controls.Add(this.dataGridAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAppointSee";
            this.Text = "Randevu Görüntüle";
            this.Load += new System.EventHandler(this.FormAppointSee_Load);
            this.panelSeeAppointment.ResumeLayout(false);
            this.panelSeeAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelSeeAppointment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRandevuSaati;
        private System.Windows.Forms.Label labelDoctorAdSoyad;
        private System.Windows.Forms.Label labelRandevuTarihi;
        private System.Windows.Forms.Label labelUyeTC;
        private System.Windows.Forms.Label labelUyeAdSoyad;
        private System.Windows.Forms.DataGridView dataGridAppointment;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTCSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTCSearch;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.Button btnList;
    }
}