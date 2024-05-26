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
        public string LoginName;

        public authorization()
        {
            InitializeComponent();


            loginField.Text = "Введите имя";
            loginField.ForeColor = Color.Green;

            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Green;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void об_authorization(object sender, PaintEventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" В разработке ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectPostgres db = UtilsPostgres.notMain();

                DataTable dt = new DataTable();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE username = @uL AND password = @uP", (NpgsqlConnection)db.Conn))
                {
                    command.Parameters.Add(new NpgsqlParameter("@uL", NpgsqlDbType.Varchar)).Value = loginField.Text;
                    command.Parameters.Add(new NpgsqlParameter("@uP", NpgsqlDbType.Varchar)).Value = passField.Text;
                    

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                    LoginName = loginField.Text;
                }

                if (dt.Rows.Count > 0)
                {
                    // Скрыть текущую форму (Form1)
                    this.Hide();

                    // Создать новый экземпляр формы Form2
                    main form2 = new main(loginField);
                    // Показать форму Form2
                    form2.Show();
                    MessageBox.Show($"{loginField.Text}, добро пожаловать в ваш личный календарь!");

                }
                else
                {
                    MessageBox.Show("Введён неверный логин или пароль");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
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
            MessageBox.Show(" В разработке ");
        }

        private void Clik_Registration_Click(object sender, EventArgs e)
        {
            // Скрыть текущую форму (Form1)
            this.Hide();

            // Создать новый экземпляр формы Form2
            registration form2 = new registration();

            // Показать форму Form2
            form2.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorization_Load(object sender, EventArgs e)
        {

        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите имя")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.White;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {

            if (loginField.Text == "")
            {
                loginField.Text = "Введите имя";
                loginField.ForeColor = Color.Green;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.White;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Green;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" В разработке ");
        }

    }

}
