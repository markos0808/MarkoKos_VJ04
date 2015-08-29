using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Text;

namespace Lab_2_4_EvidencijaStudenata
{
    class DB
    {
        private static DB instance;  //Singleton objekt
        private string connectionString;  //Putanja i ostali podaci za spajanje na bazu
        private SQLiteConnection connection;  //Konekcija prema bazi



        public static DB Instance  //Singleton instanca za rad sa bazom
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }
                
                return instance;
            }
        }


        public string ConnectionString  //Putanja i ostali podaci za spajanje na bazu
        {
            get { return connectionString; }
            private set { connectionString = value; }
        }


        public SQLiteConnection Connection  //Konekcija prema bazi
        {
            get { return connection; }
            private set { connection = value; }
        }

        private DB()  //Konstruktor klase
        {
            ConnectionString = @"Data Source = E:\GitHub\Software_Engineering\LV - novo\Vježba 8\LabStart\Lab_2_4_EvidencijaStudenata\Baza\EvidencijaStudenataPI.db3";
            Connection = new SQLiteConnection(ConnectionString);
            Connection.Open();
        }


        ~DB()  //Destruktor klase
        {
            Connection.Close();
            Connection = null;
        }


        /// <summary>
        /// Dohvaća podatke u obliku DataReader objekta na temelju prosljeđenog upita.
        /// </summary>
        /// <param name="sqlUpit"> SQL upit </param>
        /// <returns> Rezultat upita </returns>
        public DbDataReader DohvatiDataReader(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        /// <summary>
        /// Dohvaća skalarnu vrijednost kao rezultat prosljeđenog upita.
        /// </summary>
        /// <param name="sqlUpit"></param>
        /// <returns> Skalarna vrijednost kao rezultat upita. </returns>
        public object DohvatiVrijednost(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }



        /// <summary>
        /// Izvršava INSERT, UPDATE, DELETE SQL izraz.
        /// </summary>
        /// <param name="sqlUpit"> INSERT, UPDATE, DELETE izraz. </param>
        /// <returns> Broj redaka u tablici koji su promijenjeni. </returns>
        public int IzvrsiUpit(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }



    }
}
