using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace EvidencijaStudenata_Vjezbe2._4
{
    /// <summary>
    /// Klasa za opis studenata.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Konstruktor klase.
        /// </summary>
        public Student()
        {

        }

        public Student(DbDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["Id"].ToString());
                Ime = dr["Ime"].ToString();
                Prezime = dr["Prezime"].ToString();
                Status =  char.Parse(dr["Status"].ToString());
                OdabraniModel = char.Parse(dr["OdabraniModel"].ToString());
                Email = dr["Email"].ToString();
                Napomena = dr["Napomena"].ToString();
            }
        }

        #region Private Fields

        private int id;
        private string ime;
        private string prezime;
        private char status;
        private char odabraniModel;
        private string email;
        private string napomena;
        private Tim tim;

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator studenta.
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (id != value)
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// Ime studenta.
        /// </summary>
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                if (ime != value)
                {
                    ime = value;
                }
            }
        }

        /// <summary>
        /// Prezime studenta.
        /// </summary>
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                if (prezime != value)
                {
                    prezime = value;
                }
            }
        }

        /// <summary>
        /// Status studenta (Izvanredni = I; Redoviti = R).
        /// </summary>
        public char Status
        {
            get
            {
                return status;
            }
            set
            {
                if (status != value)
                {
                    status = value;
                }
            }
        }

        /// <summary>
        /// Odabrani model praćenja (A ili B).
        /// </summary>
        public char OdabraniModel
        {
            get
            {
                return odabraniModel;
            }
            set
            {
                if (odabraniModel != value)
                {
                    odabraniModel = value;
                }
            }
        }

        /// <summary>
        /// Email studenta.
        /// </summary>
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email != value)
                {
                    email = value;
                }
            }
        }

        /// <summary>
        /// Napomena o studentu.
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

        /// <summary>
        /// Tim kojem student pripada.
        /// </summary>
        public Tim Tim
        {
            get
            {
                return tim;
            }
            set
            {
                if (tim != value)
                {
                    tim = value;
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
                sqlUpit = "INSERT INTO Student (Id, Ime, Prezime, Status, Email, Napomena, OdabraniModel, TimId) VALUES (null, '" + Ime + "','" + Prezime + "','" + Status + "','" + Email + "','" + Napomena + "','" + OdabraniModel + "'," + Tim.Id + ")";
            }
            else   //Update
            {
                sqlUpit = "UPDATE Student SET Ime = '" + Ime
                + "', Prezime = '" + Prezime
                + "', Status = '" + Status
                + "', Email = '" + Email
                + "', Napomena = '" + Napomena
                + "', OdabraniModel = '" + OdabraniModel
                + "', TimId = '" + Tim.Id
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
            string sqlDelete = "DELETE FROM Student WHERE Id = " + Id;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća iz baze studente određenog tima, i vraća listu studenata.
        /// </summary>
        /// <param name="odabraniTim"></param>
        /// <returns></returns>
        public static List<Student> DohvatiStudente(Tim odabraniTim)
        {
            Student student = null;
            List<Student> listaStudenata = new List<Student>();
            string sqlUpit = "SELECT * FROM Student WHERE TimId = " + odabraniTim.Id;
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                student = new Student(dr);
                student.Tim = odabraniTim;
                listaStudenata.Add(student);
            }

            dr.Close();

            return listaStudenata;
        }

        #endregion
    }
}
