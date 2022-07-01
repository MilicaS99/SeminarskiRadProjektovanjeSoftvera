using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.GenericRepository
{
    public class GenericDbRepository : IRepository<IDomainObject>
    {
        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Izmeni(IDomainObject obj)
        {
            throw new NotImplementedException();
        }

        public void Obrisi(IDomainObject obj)
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public List<IDomainObject> Pronadji(string kriterijum)
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void Sačuvaj(IDomainObject obj)
        {
            throw new NotImplementedException();
        }

        public List<IDomainObject> VratiSve(IDomainObject obj)
        {
            throw new NotImplementedException();
        }
    }
}
