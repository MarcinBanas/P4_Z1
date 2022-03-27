using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Z1
{
    internal class BazaDanych
    {
        private SqlConnection _connection;

        public BazaDanych(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public void DodajWpis()
        {
            _connection.Open();
            var insertSql = "insert into mg.Kategorie (IDKategorii,NazwaKategorii,Opis) VALUES (@ID,@Nazwakat,@Opis)";
            var insertCommand = new SqlCommand(insertSql, _connection);
            Console.WriteLine("ID:");
            var id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nazwa Kategori:");
            var nazwakat = Console.ReadLine();
            Console.WriteLine("Opis:");
            var opis = Console.ReadLine();
            insertCommand.Parameters.Add(new SqlParameter("ID", id));
            insertCommand.Parameters.Add(new SqlParameter("Nazwakat", nazwakat));
            insertCommand.Parameters.Add(new SqlParameter("Opis", opis));
            insertCommand.ExecuteNonQuery();
            _connection.Close();
        }
        public void WyswietlDane()
        {
            _connection.Open();
            var zapytanie = "SELECT * FROM mg.Kategorie";
            var command = new SqlCommand(zapytanie, _connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.Write(reader.GetInt32(0) + "   ");
                Console.Write(reader.GetString(1) + "          ");
                Console.WriteLine(reader.GetString(2) + "        ");
            }
            _connection.Close();
        }
    }
}
