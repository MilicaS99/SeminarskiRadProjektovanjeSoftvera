using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.GenericRepository
{
   public interface IRepository<T>where T:class
    {
        List<T> VratiSve(T obj);
     
        T VratiSamoJedan(T obj);
        List<T> VratiOdredjene(T obj, int kriterijum);
        List<T> PronadjiOdredjene(T obj, int kriterijum);
        T VratiUčitanObjekat(T obj);
        void Dodaj(T obj);
        int DodajSaVracanjem(T obj);
        void Obrisi(T obj,int kriterijum);
        void Obrisi(T obj);
        void Izmeni(T obj);
        void IzmeniOdredjene(T obj);
        List<T> Pronadji(T obj,string kriterijum);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
