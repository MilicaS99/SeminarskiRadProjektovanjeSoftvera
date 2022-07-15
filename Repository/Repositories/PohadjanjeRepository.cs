using DataBaseBroker;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public  class PohadjanjeRepository
    {
        private Broker broker = new Broker();

        public bool ZapamtiPohadjanje(Domain.Pohadjanje pohadjanje)
        {
            try
            {
                broker.OpenConnection();
               // broker.ZapamtiPohadjanje(pohadjanje);
                return true;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                return false;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public object VratiPohadjanja()
        {
            try
            {
                broker.OpenConnection();
                //return broker.VratiPohadjanja();
                return null;
               

            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                return false;
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
