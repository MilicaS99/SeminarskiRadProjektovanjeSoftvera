using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UčitajGrupuSO : SystemOperationBase
    {
        private Grupa grupa;
        private Grupa nagrupa;
        public List<object> nadjenaGrupa { get; set; } = new List<object>();
        public List<Pohadjanje> pohadjanja { get; set; }
        public UčitajGrupuSO(Grupa grupa)
        {
            this.grupa = grupa;
        }

        protected override void Execute()
        {
            //nadjenaGrupa = broker.UčitajGrupe(grupa);
            nagrupa = (Grupa)repository.VratiSamoJedan(grupa);
            pohadjanja = repository.PronadjiOdredjene(new Pohadjanje(), grupa.GrupaID).OfType<Pohadjanje>().ToList();

            nadjenaGrupa.Add(nagrupa);
            nadjenaGrupa.Add(pohadjanja);
        }
    }
}