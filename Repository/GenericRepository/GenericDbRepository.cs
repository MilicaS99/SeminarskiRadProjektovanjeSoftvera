using DataBaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.GenericRepository
{
    public class GenericDbRepository : IRepository<IDomainObject>
    {
        private Broker broker = new Broker();
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Izmeni(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"update {obj.ImeTabele} set {obj.UslovIzmena} where {obj.Uslov}";
            command.ExecuteNonQuery();
        }

        public void Obrisi(IDomainObject obj,int kriterijum)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"delete from {obj.ImeTabele} where ({obj.Uslov} {kriterijum})";
            command.ExecuteNonQuery();
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        

        public void Rollback()
        {
            broker.Rollback();
        }

        public void  Dodaj(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.ImeTabele}  values {obj.VrednostiUnos}";
            command.ExecuteNonQuery();
        }

        public List<IDomainObject> VratiSve(IDomainObject obj)
        {
            List<IDomainObject> lista = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.ImeTabele} {obj.UslovSpajanje} ";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(obj.ProcitajRed(reader));
                }
            }
            return lista;
        }

        public IDomainObject VratiSamoJedan(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.ImeTabele}  {obj.UslovSpajanje}  where {obj.Uslov}";
            IDomainObject  objekatzavracanje;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read())
                {
                    return null;
                }
                objekatzavracanje = obj.ProcitajRed(reader);
            }
            return objekatzavracanje;
        }

        public List<IDomainObject> Pronadji(IDomainObject obj, string kriterijum)
        {
            List<IDomainObject> listaobjekata = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.ImeTabele} {obj.UslovSpajanje} where ({obj.UslovPretraga} '{kriterijum}')";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    listaobjekata.Add(obj.ProcitajRed(reader));
                }
            }
            return listaobjekata;
        }

        public List<IDomainObject> VratiOdredjene(IDomainObject obj, int kriterijum)
        {
            List<IDomainObject> listaobjekata = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.ImeTabele}  {obj.UslovSpajanje}  where ({obj.Uslov} {kriterijum})";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    listaobjekata.Add(obj.ProcitajRed(reader));
                }
            }
            return listaobjekata;
        }

        public int DodajSaVracanjem(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"insert into {obj.ImeTabele} output inserted.{obj.IdUbacenogObjekta} values {obj.VrednostiUnos}";
            return (int)command.ExecuteScalar();
        }

        public void IzmeniOdredjene(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"update {obj.ImeTabele} set {obj.UslovIzmena} where {obj.PomocniUslov}";
            command.ExecuteNonQuery();
        }

       

        public IDomainObject VratiUčitanObjekat(IDomainObject obj)
        {

            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.ImeTabele}  {obj.UslovSpajanje}  where {obj.PomocniUslov}";
            IDomainObject objekatzavracanje;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read())
                {
                    return null;
                }
                objekatzavracanje = obj.ProcitajRed(reader);
            }
            return objekatzavracanje;
        }

        public List<IDomainObject> PronadjiOdredjene(IDomainObject obj, int kriterijum)
        {
            List<IDomainObject> listaobjekata = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"select * from {obj.ImeTabele} {obj.UslovSpajanje}   where ({obj.PomocniUslov} {kriterijum})";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    listaobjekata.Add(obj.ProcitajRed(reader));
                }
            }
            return listaobjekata;
        }
    }
}
