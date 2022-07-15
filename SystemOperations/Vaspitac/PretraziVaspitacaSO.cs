using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class PretraziVaspitacaSO:SystemOperationBase
    {
        private readonly string kriterijum;
        
        public List<Vaspitač> Rezultat { get; set; }
        public PretraziVaspitacaSO(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }

        protected override void Execute()
        {
            // Rezultat = broker.VratiVaspitačePoKriterijumu(kriterijum);
            Rezultat = repository.Pronadji(new Vaspitač(), kriterijum).OfType<Vaspitač>().ToList();
        }
    }
}
