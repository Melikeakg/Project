﻿
namespace Project.Forms
{
    partial class FormStaffList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnListeyiGetir = new System.Windows.Forms.Button();
            this.dataGridStaff = new System.Windows.Forms.DataGridView();
            this.btnTcSearch = new System.Windows.Forms.Button();
            this.txtTcSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListeyiGetir
            // 
            this.btnListeyiGetir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListeyiGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnListeyiGetir.FlatAppearance.BorderSize = 0;
            this.btnListeyiGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeyiGetir.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeyiGetir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListeyiGetir.Location = new System.Drawing.Point(623, 91);
            this.btnListeyiGetir.Name = "btnListeyiGetir";
            this.btnListeyiGetir.Size = new System.Drawing.Size(103, 30);
            this.btnListeyiGetir.TabIndex = 24;
            this.btnListeyiGetir.Text = "Liste";
            this.btnListeyiGetir.UseVisualStyleBackColor = false;
            this.btnListeyiGetir.Click += new System.EventHandler(this.btnListeyiGetir_Click);
            // 
            // dataGridStaff
            // 
            this.dataGridStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridStaff.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridStaff.Location = new System.Drawing.Point(106, 180);
            this.dataGridStaff.Name = "dataGridStaff";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridStaff.Size = new System.Drawing.Size(654, 305);
            this.dataGridStaff.TabIndex = 23;
            // 
            // btnTcSearch
            // 
            this.btnTcSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTcSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnTcSearch.FlatAppearance.BorderSize = 0;
            this.btnTcSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTcSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTcSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTcSearch.Location = new System.Drawing.Point(502, 91);
            this.btnTcSearch.Name = "btnTcSearch";
            this.btnTcSearch.Size = new System.Drawing.Size(103, 30);
            this.btnTcSearch.TabIndex = 22;
            this.btnTcSearch.Text = "Ara";
            this.btnTcSearch.UseVisualStyleBackColor = false;
            this.btnTcSearch.Click += new System.EventHandler(this.btnTcSearch_Click);
            // 
            // txtTcSearch
            // 
            this.txtTcSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTcSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTcSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTcSearch.Location = new System.Drawing.Point(283, 99);
            this.txtTcSearch.MaxLength = 11;
            this.txtTcSearch.Name = "txtTcSearch";
            this.txtTcSearch.Size = new System.Drawing.Size(175, 13);
            this.txtTcSearch.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(283, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 1);
            this.panel1.TabIndex = 20;
            // 
            // lblTc
            // 
            this.lblTc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblTc.Location = new System.Drawing.Point(176, 100);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(80, 19);
            this.lblTc.TabIndex = 19;
            this.lblTc.Text = "TC Giriniz :";
            // 
            // FormStaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(860, 595);
            this.Controls.Add(this.btnListeyiGetir);
            this.Controls.Add(this.dataGridStaff);
            this.Controls.Add(this.btnTcSearch);
            this.Controls.Add(this.txtTcSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTc);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStaffList";
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.FormStaffList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListeyiGetir;
        private System.Windows.Forms.DataGridView dataGridStaff;
        private System.Windows.Forms.Button btnTcSearch;
        private System.Windows.Forms.TextBox txtTcSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTc;
    }
}