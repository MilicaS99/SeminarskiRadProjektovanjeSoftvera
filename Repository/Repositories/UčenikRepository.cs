using DataBaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class UčenikRepository
    {
        private Broker broker = new Broker();

        public bool ZapamtiUčenika(Učenik učenik)
        {
            try
            {
                broker.OpenConnection();
               // broker.SacuvajUcenika(učenik);
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

        public object VratiListuUčenika()
        {
            try
            {
                broker.OpenConnection();
                // return broker.vratiListuUčenika();
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

        public object NadjiUčenike(string v)
        {
            try
            {
                broker.OpenConnection();
                // return broker.NadjiUčenike(v); 
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
