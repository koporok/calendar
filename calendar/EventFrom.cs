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
    public partial class EventFrom : Form
    {
        public EventFrom()
        {
            InitializeComponent();
        }

        private void bynSave_Click(object sender, EventArgs e)
        {
            ConnectPostgres db = UtilsPostgres.notMain();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            DataTable dt = new DataTable();

            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO users (username, email, password)\r\nVALUES\r\n(@login, @email, @password)");
            //cmd.Parameters.Add(new NpgsqlParameter("@login", NpgsqlDbType.Varchar)).Value = userFeld.Text;
            //cmd.Parameters.Add(new NpgsqlParameter("@email", NpgsqlDbType.Varchar)).Value = emailForm.Text;
            //cmd.Parameters.Add(new NpgsqlParameter("@password", NpgsqlDbType.Varchar)).Value = passField.Text;
            //cmd.Connection = (NpgsqlConnection)db.Conn;
            cmd.ExecuteNonQuery();

            this.Hide();
            authorization form2 = new authorization();
            form2.Show();
            MessageBox.Show("Регистрация прошла успешно!");
        }
    }
}
