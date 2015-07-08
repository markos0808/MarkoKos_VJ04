using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace EvidencijaStudenata_Vjezbe2._4
{
    /// <summary>
    /// Klasa koja opisuje tim studenata.
    /// </summary>
    public class Tim
    {
        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje novog tima.
        /// </summary>
        public Tim()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za Tim.</param>
        public Tim(DbDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["Id"].ToString());
                //Id = dr.GetInt32(0);
                OznakaTima = dr["OznakaTima"].ToString();
                //OznakaTima = dr.GetString(1);
                NazivProjekta = dr["NazivProjekta"].ToString();
                OpisProjekta = dr["OpisProjekta"].ToString();
                Napomena = dr["Napomena"].ToString();
            }

        }

        #endregion

        #region Private Fields

        private int id;
        private string oznakaTima;
        private string nazivProjekta;
        private string opisProjekta;
        private string napomena;

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator tima.
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                if (id != value)
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// Jedinstvena oznaka tima.
        /// </summary>
        public string OznakaTima
        {
            get
            {
                return oznakaTima;
            }
            set
            {
                if (oznakaTima != value)
                {
                    oznakaTima = value;
                }
            }
        }

        /// <summary>
        /// Naziv projekta kojeg je tim odabrao.
        /// </summary>
        public string NazivProjekta
        {
            get
            {
                return nazivProjekta;
            }
            set
            {
                if (nazivProjekta != value)
                {
                    nazivProjekta = value;
                }
            }
        }

        /// <summary>
        /// Detaljan opis projekta kojeg je tim odabrao.
        /// </summary>
        public string OpisProjekta
        {
            get
            {
                return opisProjekta;
            }
            set
            {
                if (opisProjekta != value)
                {
                    opisProjekta = value;
                }
            }
        }

        /// <summary>
        /// Dodatne opcionalne napomene o timu i projektu.
        /// </summary>
        public string Napomena
        {
            get
            {
                return napomena;
            }
            set
            {
                if (napomena != value)
                {
                    napomena = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sprema vrijednosti objekta u bazu podataka.
        /// </summary>
        /// <returns>Broj redaka koji su izmijenjeni ili dodani.</returns>
        public int Spremi()
        {
            string sqlUpit = "";
            if (Id == 0)        //Insert
            {
                sqlUpit = "INSERT INTO Tim (Id, OznakaTima, NazivProjekta, OpisProjekta, Napomena) VALUES (null, '" + OznakaTima + "','" + NazivProjekta + "','" + OpisProjekta + "','" + Napomena + "')";
            }
            else   //Update
            {
                sqlUpit = "UPDATE Tim SET OznakaTima = '" + OznakaTima
                + "', NazivProjekta = '" + NazivProjekta
                + "', OpisProjekta = '" + OpisProjekta
                + "', Napomena = '" + Napomena
                + "' WHERE Id = " + Id;
            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše objekt iz baze podataka.
        /// </summary>
        /// <returns>Broj obrisanih redaka.</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Tim WHERE Id = " + Id;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve timove iz baze i vraća ih u obliku generičke liste.
        /// </summary>
        /// <returns>Lista timova.</returns>
        public static List<Tim> DohvatiTimove()
        {
            List<Tim> lista = new List<Tim>();
            string sqlUpit = "SELECT * FROM Tim";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Tim tim = new Tim(dr);
                lista.Add(tim);
            }            
            dr.Close();     //DataReader treba obavezno zatvoriti nakon uporabe.
            return lista;
        }

        /// <summary>
        /// Metoda koja nadjačava ToString metodu.
        /// </summary>
        /// <returns>Oznaka tima.</returns>
        public override string ToString()
        {
            return OznakaTima;
        }

        #endregion
    }
}
