using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class FormAppointSee : Form
    {
        public FormAppointSee()
        {
            InitializeComponent();
            LoadTheme();
        }

        Baglanti baglanti = new Baglanti();

        //Açılan formdaki butonların tema rengi ile uyumlu olmasını sağlar.
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColors.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColors.SecondaryColor;
                }
            }
        }
        private void populate()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Appointment";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridAppointment.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FormAppointSee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("\n\n\n\n" + label1.Text + label9.Text + label8.Text, new Font("Calibri", 30, FontStyle.Bold), Brushes.Black, new Point(130));
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n" + label2.Text, new Font("Calibri", 20, FontStyle.Bold), Brushes.Black, new Point(130));
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + label3.Text + "\t\t" + labelUyeAdSoyad.Text, new Font("Calibri", 18, FontStyle.Bold), Brushes.Black, new Point(130));
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + label4.Text + "\t" + labelUyeTC.Text, new Font("Calibri", 18, FontStyle.Bold), Brushes.Black, new Point(130));
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + label5.Text + "\t" + labelDoctorAdSoyad.Text, new Font("Calibri", 18, FontStyle.Bold), Brushes.Black, new Point(130));
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + label6.Text + "\t\t" + labelRandevuTarihi.Text, new Font("Calibri", 18, FontStyle.Bold), Brushes.Black, new Point(130));
            e.Graphics.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + label7.Text + "\t\t" + labelRandevuSaati.Text, new Font("Calibri", 18, FontStyle.Bold), Brushes.Black, new Point(130));
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnTCSearch_Click(object sender, EventArgs e)
        {
            if (TxtTCSearch.Text != "")
            {
                SqlConnection Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "select * from Appointment where UyeTC=" + TxtTCSearch.Text + "";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridAppointment.DataSource = ds.Tables[0];
                Con.Close();
            }

            else
            {
                MessageBox.Show("Lütfen Ad-Soyad Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            labelUyeTC.Text = dataGridAppointment.CurrentRow.Cells["UyeTC"].Value.ToString();
            labelUyeAdSoyad.Text = dataGridAppointment.CurrentRow.Cells["UyeAdSoyad"].Value.ToString();
            labelDoctorAdSoyad.Text = dataGridAppointment.CurrentRow.Cells["DoctorAdSoyad"].Value.ToString();
            labelRandevuTarihi.Text = dataGridAppointment.CurrentRow.Cells["RandevuTarihi"].Value.ToString();
            labelRandevuSaati.Text = dataGridAppointment.CurrentRow.Cells["RandevuSaati"].Value.ToString();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            populate();
            TxtTCSearch.Text = "";
        }
    }
}