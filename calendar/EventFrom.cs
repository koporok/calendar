using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            date.Text = $"{UserControlDays.static_dae}-{calendar_window.static_month}-{calendar_window.static_year}"; 
            date.ReadOnly = true; 
        }


        private void bynSave_Click(object sender, EventArgs e)
        {
            

            ConnectPostgres db = UtilsPostgres.notMain();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            DataTable dt = new DataTable();

            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO Events (description, event_date, user_id, group_id)\r\nVALUES\r\n(@descr, @date, @user, @group)");
            cmd.Parameters.Add(new NpgsqlParameter("@descr", NpgsqlDbType.Varchar)).Value = description.Text;
            cmd.Parameters.Add(new NpgsqlParameter("@date", NpgsqlDbType.Varchar)).Value = date.Text;
            cmd.Parameters.Add(new NpgsqlParameter("@user", NpgsqlDbType.Integer)).Value = 1;// надо пользователя 
            cmd.Parameters.Add(new NpgsqlParameter("@group", NpgsqlDbType.Integer)).Value = 1;// группу надо передать
            cmd.Connection = (NpgsqlConnection)db.Conn;
            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;
            Close();
            MessageBox.Show("Событие сохранено!");
        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
