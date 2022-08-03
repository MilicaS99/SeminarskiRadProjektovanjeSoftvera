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
        public Grupa nađenagrupa { get; set; }
        //private List<Grupa> nadjenaGrupa { get; set; }
        public List<Pohadjanje> pohadjanja { get; set; }
        public UčitajGrupuSO(Grupa grupa)
        {
            this.grupa = grupa;
        }

        protected override void Execute()
        {
            //nadjenaGrupa = broker.UčitajGrupe(grupa);
            nađenagrupa = (Grupa)repository.VratiSamoJedan(grupa);
            pohadjanja = repository.PronadjiOdredjene(new Pohadjanje(), grupa.GrupaID).OfType<Pohadjanje>().ToList();

            nađenagrupa.listapohadjanja = pohadjanja;
            
            //nadjenaGrupa.Add(nagrupa);
            //nadjenaGrupa.Add(pohadjanja);
        }
    }
}