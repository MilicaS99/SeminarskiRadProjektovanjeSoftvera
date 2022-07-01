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
    public class ProgramRepository
    {
        private Broker broker = new Broker();
        public bool SacuvajProgram(Program program)
        {
            try
            {
                broker.OpenConnection();
                broker.SacuvajProgram(program);
                return true;

            }catch(Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                return false;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public object NadjiPrograme(string v)
        {
            try
            {
                broker.OpenConnection();
               return broker.NadjiPrograme(v);
               

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

        public object VratiListuPrograma()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiListuPrograma();


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
