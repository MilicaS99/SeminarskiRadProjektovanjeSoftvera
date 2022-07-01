using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class NadjiUčenikeSO : SystemOperationBase
    {
        private readonly string kriterijum;
        public List<Učenik> Rezultat { get; set; }
        public NadjiUčenikeSO(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }
        protected override void Execute()
        {
            Rezultat = broker.NadjiUčenike(kriterijum);
        }
    }
}
