using Domain;
using System.Collections.Generic;

namespace SystemOperations
{
    public class ZapamtiNovuGrupuSO : SystemOperationBase
    {
        private List<object> objektiZaCuvanje;
        private List<Pohadjanje> pohadjanja;

        public ZapamtiNovuGrupuSO(List<object> objektiZaCuvanje)
        {
            this.objektiZaCuvanje = objektiZaCuvanje;
        }

        protected override void Execute()
        {
            
            Grupa grupa =(Grupa) objektiZaCuvanje[0];
            //broker.ZapamtiNovuGrupu(grupa);
            repository.Izmeni(grupa);
            repository.Obrisi(new Pohadjanje (),grupa.GrupaID);
            pohadjanja = objektiZaCuvanje[1] as List<Pohadjanje>;
            foreach (Pohadjanje p in pohadjanja)
            {
                p.Grupa = new Grupa();
                p.Grupa.GrupaID = grupa.GrupaID;
                //broker.ZapamtiPohadjanje(p);
                repository.Dodaj(p);
            }
            
        }
    }
}