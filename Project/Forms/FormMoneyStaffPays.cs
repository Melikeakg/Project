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
    public partial class FormMoneyStaffPays : Form
    {
        Baglanti baglanti = new Baglanti();
        public FormMoneyStaffPays()
        {
            InitializeComponent();
            LoadTheme();
        }

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

        void populateCombo()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            string query = "SELECT * FROM Staff";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PersonelTC", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboPersonelTC.ValueMember = "PersonelTC";
                comboPersonelTC.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        string staffName;
        void fetchStaffName()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "Select * from Staff where PersonelTC =" + comboPersonelTC.SelectedValue.ToString() + "";

            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                staffName = dr["PersonelAdSoyad"].ToString();
                txtStaffNameSurname.Text = staffName;
            }
            Con.Close();
        }

        string staffJob;
        void fetchStaffJob()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "Select * from Staff where PersonelTC =" + comboPersonelTC.SelectedValue.ToString() + "";

            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                staffJob = dr["Gorevi"].ToString();
                txtStaffJob.Text = staffJob;
            }
            Con.Close();
        }


        private void FormMoneyStaffPays_Load(object sender, EventArgs e)
        {
            populate();
            populateCombo();
        }

        private void comboPersonelTC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchStaffName();
            fetchStaffJob();
        }

        

        private void txtStaffJob_TextChanged(object sender, EventArgs e)
        {
            if (txtStaffJob.Text == "Antrenör")
            {
                txtPayAmount.Text = "3000";
            }

            else if (txtStaffJob.Text == "Fitness Hocası")
            {
                txtPayAmount.Text = "3500";
            }
            else
            {
                txtPayAmount.Text = "2000";
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (comboPersonelTC.Text == "" || txtStaffNameSurname.Text == "" || txtStaffJob.Text == "" || txtPayAmount.Text == "" || dtpPayAppointment.Text=="")
            {
                MessageBox.Show("Eksik Alan Girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlConnection Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "insert into StaffPayment values('" + comboPersonelTC.Text + "','" + txtStaffNameSurname.Text + "','" + txtStaffJob.Text + "','" + txtPayAmount.Text + "' , '"+dtpPayAppointment
                    .Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Personel ödemesi yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();
                populate();
            }
        }
        private void populate()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from StaffPayment";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridPaymentStaff.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboPersonelTC.ResetText();
            txtStaffNameSurname.Clear();
            txtStaffJob.ResetText();
            txtPayAmount.ResetText();
            dtpPayAppointment.Value = DateTime.Now;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtTcSearch.Text != "")
            {
                SqlConnection Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "select * from StaffPayment where PersonelTC = " + txtTcSearch.Text + "";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridPaymentStaff.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                MessageBox.Show("Lütfen TC  Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            populate();
            txtTcSearch.Text = "";
        }
    }
}
