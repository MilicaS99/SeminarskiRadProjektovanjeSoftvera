using DataBaseBroker;
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
        protected Broker broker = new Broker();

        public bool Uspesno { get; set; } = true;
        public void  ExecuteTemplate()
        {
            try
            {
                broker.OpenConnection();
                Execute();
               

            }catch(Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                Uspesno = false;
              
               
            }
            finally
            {
                broker.CloseConnection();
            }
        }
        protected abstract void Execute();
    }
}
