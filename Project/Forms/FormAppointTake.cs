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
    public partial class FormAppointTake : Form
    {
        public FormAppointTake()
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

        void popDoctor()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Doctor";
            cmd.Connection = Con;
            cmd.CommandType = CommandType.Text;

            SqlDataReader dr;
            Con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboDoctor.Items.Add(dr["DoctorAdSoyad"]);
            }
            Con.Close();
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


        void populateCombo()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            string query = "SELECT * FROM Member";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("UyeTC", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboUyeTC.ValueMember = "UyeTC";
                comboUyeTC.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        string memberName;
        void fetchMemberName()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "Select * from Member where UyeTC =" + comboUyeTC.SelectedValue.ToString() + "";

            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                memberName = dr["UyeAdSoyad"].ToString();
                txtMemberNameSurname.Text = memberName;
            }
            Con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboUyeTC.ResetText();
            txtMemberNameSurname.Clear();
            comboDoctor.ResetText();
            dtpDateAppointment.Value = DateTime.Now;
            comboDateTime.ResetText();
        }

        private void FormAppointTake_Load(object sender, EventArgs e)
        {
            populate();
            popDoctor();
            populateCombo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboUyeTC.Text == "" || txtMemberNameSurname.Text == "" || comboDoctor.Text == "" || dtpDateAppointment.Text == "" || comboDateTime.Text == "")
            {
                MessageBox.Show("Eksik Alan Girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlConnection Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "insert into Appointment values('" + comboUyeTC.Text + "','" + txtMemberNameSurname.Text + "','" + comboDoctor.SelectedItem.ToString() + "','" + dtpDateAppointment.Text + "','" + comboDateTime.SelectedItem.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Randevu Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();
                populate();

            }
        }

       

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtTcSearch.Text != "")
            {
                SqlConnection Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "select * from Appointment where UyeTC = " + txtTcSearch.Text + "";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridAppointment.DataSource = ds.Tables[0];
                Con.Close();
            }

            else
            {
                MessageBox.Show("Lütfen TC  Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtTcSearch.Text == "")
            {
                MessageBox.Show("Lütfen TC Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    SqlConnection Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "delete from Appointment where UyeTC=" + txtTcSearch.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla silindi.", "Bilgi", MessageBoxButtons.OK);
                    Con.Close();
                    populate();
                    txtTcSearch.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            populate();
            txtTcSearch.Text = "";
        }

        private void comboUyeTC_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            fetchMemberName();
        }
    }
}
