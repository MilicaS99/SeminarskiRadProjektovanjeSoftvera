using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class PretraziUcenikeSO : SystemOperationBase
    {
        private readonly string kriterijum;
        public List<Učenik> Rezultat { get; set; }
        public PretraziUcenikeSO(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }
        protected override void Execute()
        {
            Rezultat = repository.Pronadji(new Učenik(), kriterijum).OfType<Učenik>().ToList();
        }
    }
}
