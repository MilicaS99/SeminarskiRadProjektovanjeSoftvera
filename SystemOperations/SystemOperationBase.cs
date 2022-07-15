using DataBaseBroker;
using Domain;
using Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
   public abstract class SystemOperationBase
    {
        protected IRepository<IDomainObject> repository = new GenericDbRepository();

      //  protected Broker broker = new Broker();
        public bool Uspesno { get; set; } = true;
        public void  ExecuteTemplate()
        {
            try
            {
               // broker.OpenConnection();
                repository.OpenConnection();
                repository.BeginTransaction();
                Execute();
                repository.Commit();
               

            }catch(Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                Uspesno = false;
              
               
            }
            finally
            {
                //broker.CloseConnection();
                repository.CloseConnection();
            }
        }
        protected abstract void Execute();
    }

    
}
