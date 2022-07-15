using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public  class Grupa:IDomainObject
    {
        [Browsable(false)]
        public int GrupaID { get; set; }
        public string NazivGrupe { get; set; }
        public Uzrast Uzrast { get; set; }
        public Program Program { get; set; } 
        public Vaspitač Vaspitač { get; set; }
        [Browsable(false)]
        public string ImeTabele => "Grupa";
        [Browsable(false)]
        public string VrednostiUnos => $" ('{NazivGrupe}', '{(int)Uzrast}','{Program.ProgramID}','{Vaspitač.VaspitačID}')";
        [Browsable(false)]
        public string Uslov => $"GrupaID= {GrupaID}";
        [Browsable(false)]
        public string UslovSpajanje => "g join Program p  on p.ProgramID=g.ProgramID join Vaspitač v on v.VaspitačID=g.VaspitačID";
        [Browsable(false)]
        public string UslovPretraga => "";
        [Browsable(false)]
        public string UslovIzmena => $"NazivGrupe='{NazivGrupe}', Uzrast = '{(int)Uzrast}',ProgramID='{Program.ProgramID}' ,VaspitačID = '{Vaspitač.VaspitačID}'";
        [Browsable(false)]
        public string IdUbacenogObjekta => "GrupaID";

        [Browsable(false)]
        public string PomocniUslov => "";

        public IDomainObject ProcitajRed(SqlDataReader reader)
        {
            Grupa grupa = new Grupa
            {
                GrupaID = reader.GetInt32(0),
                NazivGrupe = reader.GetString(1),
                Uzrast = (Uzrast)reader.GetInt32(2),
                Program = new Program {
                      ProgramID = reader.GetInt32(3),
                      NazivPrograma = reader.GetString(6),
                       Opis = reader.GetString(7)
                },
                       Vaspitač = new Vaspitač {
                        VaspitačID = reader.GetInt32(4),
                        Ime = reader.GetString(9),
                        Prezime = reader.GetString(10),
                        Pol = reader.GetString(11),
                         Kontakt = reader.GetString(12) }

        };

            return grupa;
        }

        public override string ToString()
        {
            return NazivGrupe ;
        }
     
       
    }
}
