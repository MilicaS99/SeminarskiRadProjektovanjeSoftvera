using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.GenericRepository
{
    interface IRepository<T>where T:class
    {
        List<T> VratiSve(IDomainObject obj);
        void Sačuvaj(T obj);
        void Obrisi(T obj);
        void Izmeni(T obj);
        List<T> Pronadji(string kriterijum);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
