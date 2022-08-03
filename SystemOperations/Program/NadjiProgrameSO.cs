using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class NadjiProgrameSO : SystemOperationBase
    {
        private readonly string kriterijum;
        public List<Program> Rezultat { get; set; }
        public NadjiProgrameSO(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }
        protected override void Execute()
        {
            //Rezultat = broker.NadjiPrograme(kriterijum);
            Rezultat = repository.Pronadji(new Program(), kriterijum).OfType<Program>().ToList();
            if (Rezultat.Count == 0)
            {
                Rezultat = null;
            }
        }
    }
}
