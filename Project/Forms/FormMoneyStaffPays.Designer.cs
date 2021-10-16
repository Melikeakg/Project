
namespace Project.Forms
{
    partial class FormMoneyStaffPays
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.dtpPayAppointment = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPersonelTC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStaffNameSurname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStaffJob = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridPaymentStaff = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtTcSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaymentStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReset.Location = new System.Drawing.Point(226, 428);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 31);
            this.btnReset.TabIndex = 116;
            this.btnReset.Text = "Tümünü Sil";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPay.Location = new System.Drawing.Point(116, 428);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(90, 31);
            this.btnPay.TabIndex = 115;
            this.btnPay.Text = "Öde";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dtpPayAppointment
            // 
            this.dtpPayAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpPayAppointment.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dtpPayAppointment.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtpPayAppointment.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dtpPayAppointment.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dtpPayAppointment.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dtpPayAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPayAppointment.Location = new System.Drawing.Point(204, 361);
            this.dtpPayAppointment.Name = "dtpPayAppointment";
            this.dtpPayAppointment.Size = new System.Drawing.Size(135, 20);
            this.dtpPayAppointment.TabIndex = 114;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label9.Location = new System.Drawing.Point(96, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 36);
            this.label9.TabIndex = 113;
            this.label9.Text = "Ödeme Tarihi\r\nseçiniz:";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPayAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPayAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPayAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtPayAmount.Location = new System.Drawing.Point(204, 294);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(135, 13);
            this.txtPayAmount.TabIndex = 112;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(204, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 1);
            this.panel2.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(96, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 110;
            this.label1.Text = "Ödeme Miktarı:";
            // 
            // comboPersonelTC
            // 
            this.comboPersonelTC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboPersonelTC.FormattingEnabled = true;
            this.comboPersonelTC.Location = new System.Drawing.Point(204, 109);
            this.comboPersonelTC.Name = "comboPersonelTC";
            this.comboPersonelTC.Size = new System.Drawing.Size(135, 21);
            this.comboPersonelTC.TabIndex = 109;
            this.comboPersonelTC.SelectionChangeCommitted += new System.EventHandler(this.comboPersonelTC_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(96, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 36);
            this.label5.TabIndex = 108;
            this.label5.Text = "Personel TC\'si\r\nseçiniz:";
            // 
            // txtStaffNameSurname
            // 
            this.txtStaffNameSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStaffNameSurname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStaffNameSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffNameSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtStaffNameSurname.Location = new System.Drawing.Point(204, 170);
            this.txtStaffNameSurname.Name = "txtStaffNameSurname";
            this.txtStaffNameSurname.Size = new System.Drawing.Size(135, 13);
            this.txtStaffNameSurname.TabIndex = 107;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(204, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 1);
            this.panel1.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(96, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 36);
            this.label2.TabIndex = 105;
            this.label2.Text = "Personel \r\nAd-Soyad:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label10.Location = new System.Drawing.Point(92, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 118;
            this.label10.Text = "Görevi :";
            // 
            // txtStaffJob
            // 
            this.txtStaffJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStaffJob.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStaffJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtStaffJob.Location = new System.Drawing.Point(204, 239);
            this.txtStaffJob.Name = "txtStaffJob";
            this.txtStaffJob.Size = new System.Drawing.Size(135, 13);
            this.txtStaffJob.TabIndex = 120;
            this.txtStaffJob.TextChanged += new System.EventHandler(this.txtStaffJob_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(204, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 1);
            this.panel3.TabIndex = 119;
            // 
            // btnList
            // 
            this.btnList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnList.Location = new System.Drawing.Point(706, 67);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(69, 31);
            this.btnList.TabIndex = 126;
            this.btnList.Text = "Liste";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridPaymentStaff
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridPaymentStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPaymentStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridPaymentStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridPaymentStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridPaymentStaff.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridPaymentStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPaymentStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPaymentStaff.Location = new System.Drawing.Point(398, 109);
            this.dataGridPaymentStaff.Name = "dataGridPaymentStaff";
            this.dataGridPaymentStaff.Size = new System.Drawing.Size(377, 357);
            this.dataGridPaymentStaff.TabIndex = 125;
            // 
            // btnAra
            // 
            this.btnAra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAra.Location = new System.Drawing.Point(619, 67);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(69, 31);
            this.btnAra.TabIndex = 124;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtTcSearch
            // 
            this.txtTcSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTcSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTcSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTcSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtTcSearch.Location = new System.Drawing.Point(495, 73);
            this.txtTcSearch.MaxLength = 11;
            this.txtTcSearch.Name = "txtTcSearch";
            this.txtTcSearch.Size = new System.Drawing.Size(109, 13);
            this.txtTcSearch.TabIndex = 123;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(495, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(109, 1);
            this.panel4.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(395, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 36);
            this.label3.TabIndex = 121;
            this.label3.Text = "Personel TC \r\nGiriniz : ";
            // 
            // FormMoneyStaffPays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(860, 595);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dataGridPaymentStaff);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtTcSearch);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStaffJob);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.dtpPayAppointment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPayAmount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPersonelTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStaffNameSurname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMoneyStaffPays";
            this.Text = "Personel Ödemeleri";
            this.Load += new System.EventHandler(this.FormMoneyStaffPays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaymentStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DateTimePicker dtpPayAppointment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPersonelTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStaffNameSurname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStaffJob;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridPaymentStaff;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtTcSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
    }
}