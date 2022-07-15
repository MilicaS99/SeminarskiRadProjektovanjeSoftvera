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
   public  class VaspitačRepository
    {
        private Broker broker = new Broker();

        public bool ZapamtiVaspitaca(Vaspitač vaspitač)
        {
            try
            {
                broker.OpenConnection();
               // broker.SacuvajVaspitaca(vaspitač);
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

        public object VratiListuVaspitaca()
        {
            try
            {
                broker.OpenConnection();
                //return broker.vratiListuVaspitaca();
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

        public object vratiVaspitacePoKriterijumu(string v)
        {

            try
            {
                broker.OpenConnection();
                // return broker.VratiVaspitačePoKriterijumu(v);
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

        public bool sacuvajIzmenjenogVaspitača(Vaspitač vaspitač)
        {
            try
            {
                broker.OpenConnection();
               // broker.SacuvajIzmenjenogVaspitaca(vaspitač);
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
    }
}
