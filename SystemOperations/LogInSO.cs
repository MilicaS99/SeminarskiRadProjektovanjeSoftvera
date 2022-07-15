using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
   public class LoginSO : SystemOperationBase
    {
        private Korisnik korisnik;

        public Korisnik Rezultat { get; set; }

        public LoginSO(Korisnik korisnik)
        {
            this.korisnik = korisnik;
        }
        protected override void Execute()
        {
            Rezultat = (Korisnik)repository.VratiSamoJedan(korisnik);
        }
    }
}
