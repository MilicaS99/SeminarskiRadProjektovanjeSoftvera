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
        private Grupa grupa;

       

        public ZapamtiGrupuSO(Grupa grupa)
        {
            this.grupa = grupa;
        }

        protected override void Execute()
        {
           // broker.SacuvajGrupu(objekti[0] as Grupa);
            //int id = broker.VratiIdPoslednjeUneteGrupe();
            int id = repository.DodajSaVracanjem(grupa);
            pohadjanja = grupa.listapohadjanja as List<Pohadjanje>;
            foreach (Pohadjanje p in pohadjanja)
            {
                p.Grupa = new Grupa();
                p.Grupa.GrupaID = id;
                //broker.ZapamtiPohadjanje(p);
                // repository.Dodaj(p);
                int idzavracanje = repository.DodajSaVracanjem(p);
            }
      
        }
    }
}
