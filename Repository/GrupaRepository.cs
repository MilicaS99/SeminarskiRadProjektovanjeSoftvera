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
    public class GrupaRepository
    {
        private Broker broker = new Broker();

        public bool ZapamtiGrupu(Grupa grupa)
        {
            try
            {
                broker.OpenConnection();
                broker.SacuvajGrupu(grupa);
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

        public object VratiSveGrupe()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiSveGrupe();
             
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

        public object NadjiGrupe(string kriterijum)
        {
            try
            {
                broker.OpenConnection();
                return broker.NadjiGrupe(kriterijum);

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

        public bool ZapamtiNovuGrupu(Grupa grupa)
        {
            try
            {
                broker.OpenConnection();
                broker.ZapamtiNovuGrupu(grupa);
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
