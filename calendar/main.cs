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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

            textBox2.Text = "Введите ID группы";
            textBox2.ForeColor = Color.Green;
        }

        private void heading_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorization form2 = new authorization();
            form2.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            create_group form2 = new create_group();
            form2.Show();
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите ID группы")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox2.Text = "Введите ID группы";
                textBox2.ForeColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectPostgres db = UtilsPostgres.notMain();

                DataTable dt = new DataTable();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Groups WHERE group_id = @uI", (NpgsqlConnection)db.Conn))
                {
                    command.Parameters.Add(new NpgsqlParameter("@uI", NpgsqlDbType.Integer)).Value = Convert.ToInt32(textBox2.Text);
                    
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
       
                }

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    calendar_window form2 = new calendar_window();
                    form2.Show();
                    //MessageBox.Show($"{loginField.Text}, добро пожаловать в ваш личный календарь!");

                }
                else
                {
                    MessageBox.Show("Введён ID группы или такого ID нет");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
           
        }
    }
}
