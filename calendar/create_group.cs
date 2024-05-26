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
    public partial class create_group : Form
    {
        public create_group()
        {
            InitializeComponent();

            name.Text = "Введите имя группы";
            name.ForeColor = Color.Green;

            description.Text = "Введите имя группы";
            description.ForeColor = Color.Green;

            nameID.Text = "Введите ID группы";
            nameID.ForeColor = Color.Green;

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Введите имя группы")
            {
                name.Text = "";
                name.ForeColor = Color.White;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Введите имя группы";
                name.ForeColor = Color.Green;
            }
        }

        private void description_Enter(object sender, EventArgs e)
        {
            if (description.Text == "Введите имя группы")
            {
                description.Text = "";
                description.ForeColor = Color.White;
            }
        }

        private void description_Leave(object sender, EventArgs e)
        {

            if (description.Text == "")
            {
                description.Text = "Введите имя группы";
                description.ForeColor = Color.Green;
            }
        }
      


        private void nameID_Enter(object sender, EventArgs e)
        {
            if (nameID.Text == "Введите ID группы")
            {
                nameID.Text = "";
                nameID.ForeColor = Color.White;
            }

        }

        private void nameID_Leave(object sender, EventArgs e)
        {
            if (nameID.Text == "")
            {
                nameID.Text = "Введите ID группы";
                nameID.ForeColor = Color.Green;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            ConnectPostgres db = UtilsPostgres.notMain();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            DataTable dt = new DataTable();

            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO users (group_id, group_name, description, user_id)\r\nVALUES\r\n(@nameID, @name, @description, @id)");
            //cmd.Parameters.Add(new NpgsqlParameter("@id", NpgsqlDbType.Varchar)).Value = loginName;
            cmd.Parameters.Add(new NpgsqlParameter("@name", NpgsqlDbType.Varchar)).Value = name.Text;
            cmd.Parameters.Add(new NpgsqlParameter("@description", NpgsqlDbType.Varchar)).Value = description.Text;
            cmd.Parameters.Add(new NpgsqlParameter("@nameID", NpgsqlDbType.Varchar)).Value = nameID.Text;
            cmd.Connection = (NpgsqlConnection)db.Conn;
            cmd.ExecuteNonQuery();

            this.Hide();
            main form2 = new main();
            form2.Show();
            MessageBox.Show("Группа создана!");
        }
    }
}
