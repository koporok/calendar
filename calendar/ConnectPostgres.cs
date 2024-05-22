using System;
using Npgsql;
using System.Threading.Tasks;

namespace calendar
{
    internal class ConnectPostgres
    {
        private NpgsqlConnection conn; // Поле для хранения соединения

        public object Conn { get => conn; set => conn = (NpgsqlConnection)value; } // Свойство для доступа к соединению

        public class UtilsPostgres
        {
            private NpgsqlConnection conn; // Поле для хранения соединения

            public NpgsqlConnection Connect(string connectionString)
            {
                conn = new NpgsqlConnection(connectionString); // Инициализация соединения
                try
                {
                    conn.Open(); // Открытие соединения
                    Console.WriteLine("Успешное подключение к базе данных PostgreSQL!");
                    return conn;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка подключения к базе данных PostgreSQL: " + ex.Message);
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
        }

        static async Task Main(string[] args)
        {
            string connectionString = "Server=localhost; Port=5432; Database=Calendar; UserId=postgres; Password=aaprok2005; CommandTimeout=120;";

            ConnectPostgres connectPostgres = new ConnectPostgres();
            UtilsPostgres utilsPostgres = new UtilsPostgres();

            connectPostgres.Conn = utilsPostgres.Connect(connectionString); // Присвоение соединения переменной Conn



            Console.ReadLine();
        }
    }
}
