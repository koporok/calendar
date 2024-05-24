using System;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendar
{
    internal class ConnectPostgres
    {
        private NpgsqlConnection conn; // Поле для хранения соединения

        public object Conn { get => conn; set => conn = (NpgsqlConnection)value; } // Свойство для доступа к соединению
    }

    public class UtilsPostgres
    {
        private NpgsqlConnection conn; // Поле для хранения соединения

        public NpgsqlConnection Connect(string connectionString)
        {
            conn = new NpgsqlConnection(connectionString); // Инициализация соединения
            try
            {
                conn.Open(); // Открытие соединения
                MessageBox.Show("Успешное подключение к базе данных PostgreSQL!");
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных PostgreSQL: " + ex.Message);
                return null;
            }
        }

        public async Task ExecuteSelectAsReader(string sql, Action<NpgsqlDataReader> action)
        {
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    action(reader);
                }
            }
        }

        internal static ConnectPostgres notMain()
        {
            string connectionString = "Server=localhost; Port=5432; Database=Calendar; User Id=postgres; Password=aaprok2005;";

            ConnectPostgres connectPostgres = new ConnectPostgres();
            UtilsPostgres utilsPostgres = new UtilsPostgres();

            connectPostgres.Conn = utilsPostgres.Connect(connectionString); // Присвоение соединения переменной Conn
            return connectPostgres;
        }
    }
}
