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
    public partial class UserControlDays : UserControl
    {
        public static string static_dae;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            Ibdays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_dae = Ibdays.Text;
            timer1.Start(); 
            EventFrom eventFrom = new EventFrom();
            eventFrom.ShowDialog();
            if (eventFrom.DialogResult == DialogResult.OK) displayEvent();
        }

        private void displayEvent()
        {
            try
            {
                ConnectPostgres db = UtilsPostgres.notMain();
                DataTable dt = new DataTable();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Events WHERE event_date = @date", (NpgsqlConnection)db.Conn))
                {
                    string asdas = int.Parse(Ibdays.Text) + "-" + calendar_window.static_month + "-" + calendar_window.static_year;
                    command.Parameters.Add(new NpgsqlParameter("@date", NpgsqlDbType.Varchar)).Value = int.Parse(Ibdays.Text) + "-"+ calendar_window.static_month + "-" + calendar_window.static_year;

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(dt); // Заполнить DataTable данными из запроса
                    }

                    // Проверка на наличие данных
                    if (dt.Rows.Count > 0)
                    {
                        Ibevent.Text = dt.Rows[0]["description"].ToString();
                    }
                    else
                    {
                        Ibevent.Text = "Данные не найдены";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //displayEvent(); 
        }
    }
}
