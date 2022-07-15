using Domain;
using System.Collections.Generic;

namespace SystemOperations
{
    public class ObrisiUcenikaIzGrupe : SystemOperationBase
    {
        
        private Pohadjanje pohadjanje;

     

        public ObrisiUcenikaIzGrupe(Pohadjanje pohadjanje)
        {
            this.pohadjanje = pohadjanje;
        }

        protected override void Execute()
        {
            //broker.ObisiUcenikaIzGrupe(pohadjanje);
           // repository.Obrisi(pohadjanje);
        }
    }
}