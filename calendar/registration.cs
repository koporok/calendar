using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendar
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();

            userFeld.Text = "Введите имя";
            userFeld.ForeColor = Color.Green;

            emailForm.Text = "Введите почту";
            emailForm.ForeColor = Color.Green;

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            ConnectPostgres db = UtilsPostgres.notMain();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            DataTable dt = new DataTable();

            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO users (username, email, password)\r\nVALUES\r\n(@login, @email, @password)");
            cmd.Parameters.Add(new NpgsqlParameter("@login", NpgsqlDbType.Varchar)).Value = userFeld.Text;
            cmd.Parameters.Add(new NpgsqlParameter("@email", NpgsqlDbType.Varchar)).Value = emailForm.Text;
            cmd.Parameters.Add(new NpgsqlParameter("@password", NpgsqlDbType.Varchar)).Value = passField.Text;
            cmd.Connection = (NpgsqlConnection)db.Conn;
            cmd.ExecuteNonQuery();
        }

        private void Clik_Pass_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void обои_authorization_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userFeld_Enter(object sender, EventArgs e)
        {
            if(userFeld.Text== "Введите имя" ) { userFeld.Text = "";
                userFeld.ForeColor = Color.White;
            }
            
        } 
        private void userFeld_Leave(object sender, EventArgs e)
        {
            if (userFeld.Text == "")
            {
                userFeld.Text = "Введите имя";
                userFeld.ForeColor = Color.Green;
            }
        }

        private void emailForm_Enter(object sender, EventArgs e)
        {
            if (emailForm.Text == "Введите почту")
            {
                emailForm.Text = "";
                emailForm.ForeColor = Color.White;
            }
        }

        private void emailForm_Leave(object sender, EventArgs e)
        {
            if (emailForm.Text == "")
            {
                emailForm.Text = "Введите почту";
                emailForm.ForeColor = Color.Green;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" В разработке ");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" В разработке ");
        }

        private void registration_Load(object sender, EventArgs e)
        {

        }
    }
}
