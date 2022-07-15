using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class VratiPohadjanjaSO : SystemOperationBase
    {

        public List<Pohadjanje> Rezultat { get; set; }
        protected override void Execute()
        {
            Rezultat = repository.VratiSve(new Pohadjanje()).OfType<Pohadjanje>().ToList();
        }
    }
}