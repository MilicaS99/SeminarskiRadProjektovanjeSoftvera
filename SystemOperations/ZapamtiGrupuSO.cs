using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class ZapamtiGrupuSO : SystemOperationBase
    {
       // private Grupa grupa;
       private List<object> objekti;
      List<  Pohadjanje> pohadjanja = new List<Pohadjanje>();
        public ZapamtiGrupuSO(List<object> objekti)
        {
            this.objekti = objekti;
        }

        protected override void Execute()
        {
            broker.SacuvajGrupu(objekti[0] as Grupa);
            int id = broker.VratiIdPoslednjeUneteGrupe();
            pohadjanja = objekti[1] as List<Pohadjanje>;
            foreach (Pohadjanje p in pohadjanja)
            {
                p.Grupa = new Grupa();
                p.Grupa.GrupaID = id;
                broker.ZapamtiPohadjanje(p);
            }
      
        }
    }
}
