using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;
using NpgsqlTypes;
using static calendar.ConnectPostgres;

namespace calendar
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void об_authorization(object sender, PaintEventArgs e)
        {
            // Предполагается, что у вас есть пути к изображениям для утра, дня, вечера и ночи.
            string morningImagePath = "images.обои_вечер.jpg";
            string afternoonImagePath = "images.обои_день.jpg";
            string eveningImagePath = "images.обои_вечер.jpg";
            string nightImagePath = "images.обои_ночь.jpg";

            DateTime currentTime = DateTime.Now;

            if (currentTime.Hour >= 5 && currentTime.Hour < 12)  // Утро (с 5:00 до 11:59)
            {
                обои_authorization.BackgroundImage = Image.FromFile(morningImagePath);
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour < 17)  // День (с 12:00 до 16:59)
            {
                обои_authorization.BackgroundImage = Image.FromFile(afternoonImagePath);
            }
            else if (currentTime.Hour >= 17 && currentTime.Hour < 20)  // Вечер (с 17:00 до 19:59)
            {
                обои_authorization.BackgroundImage = Image.FromFile(eveningImagePath);
            }
            else  // Ночь (с 20:00 до 4:59)
            {
                обои_authorization.BackgroundImage = Image.FromFile(nightImagePath);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            ConnectPostgres db = new ConnectPostgres();

            DataTable dt = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE username = @uL AND password = @uP");
            command.Parameters.Add(new NpgsqlParameter("@uL", NpgsqlDbType.Varchar)).Value = loginUser;
            command.Parameters.Add(new NpgsqlParameter("@uP", NpgsqlDbType.Varchar)).Value = passUser;
            command.Connection = (NpgsqlConnection)db.Conn;


            adapter.SelectCommand = command;
            //adapter.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show(loginUser +", добро пожаловать в ваш личный календарь!");
            }
            else
            {
                MessageBox.Show("Введён неверный логин или пароль");
            }

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Clik_Pass.ForeColor = Color.Blue;
        }

        private void Clik_Pass_MouseLeave(object sender, EventArgs e)
        {
            Clik_Pass.ForeColor = Color.White;
        }

        private void Clik_Registration_MouseEnter(object sender, EventArgs e)
        {
            Clik_Registration.ForeColor = Color.Blue;
        }

        private void Clik_Registration_MouseLeave(object sender, EventArgs e)
        {
            Clik_Registration.ForeColor = Color.White;
        }

  

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Clik_Registration_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
