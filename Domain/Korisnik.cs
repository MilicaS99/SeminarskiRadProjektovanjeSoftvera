using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Korisnik:IDomainObject
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string  KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public string ImeTabele => "Korisnik";

        public string VrednostiUnos => $" '{Ime}', '{Prezime}',  '{KorisnickoIme}',   '{Lozinka}'";

        public string Uslov => $"KorisnickoIme = '{KorisnickoIme}' and Lozinka = '{Lozinka}'";

        public string UslovSpajanje => "";

        public string UslovPretraga => "";

        public string UslovIzmena => "";

        public string IdUbacenogObjekta => "";

        public string PomocniUslov => "";

        public IDomainObject ProcitajRed(SqlDataReader reader)
        {
            Korisnik korisnk = new Korisnik()
            {
               Ime = reader.GetString(1),
               Prezime = reader.GetString(2),
               KorisnickoIme = reader.GetString(3),
              Lozinka = reader.GetString(4),

        };
            return korisnk;
    }

     
    }
}
