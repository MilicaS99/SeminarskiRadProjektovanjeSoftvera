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
    public class Vaspitač : IDomainObject
    {
        [Browsable(false)]
        public int VaspitačID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Pol { get; set; }
        public string Kontakt { get; set; }
        public Program Program { get; set; }

        [Browsable(false)]
        public string ImeTabele => "Vaspitač";
        [Browsable(false)]
        public string VrednostiUnos => $" ('{Ime}', '{Prezime}','{Pol}', '{Kontakt}','{Program.ProgramID}')";
        [Browsable(false)]
        public string Uslov => "v.ProgramID = ";
       
        [Browsable(false)]
        public string UslovSpajanje => "v join Program p on p.ProgramID=v.ProgramID";
        [Browsable(false)]
        public string UslovPretraga => "p.Naziv=";
        [Browsable(false)]
        public string UslovIzmena => $"Kontakt = '{Kontakt}', ProgramID = '{Program.ProgramID}' ";
        [Browsable(false)]
        public string IdUbacenogObjekta => "VaspitačID";
        [Browsable(false)]
        public string PomocniUslov => $"VaspitačID =  {VaspitačID }";


        // public string PomocniUslov => $"VaspitačID =  {VaspitačID }";

        public override bool Equals(object obj)
        {
            if (obj is Vaspitač v)
            {
                return v.VaspitačID == VaspitačID;
            }
            return false;
        }

        public IDomainObject ProcitajRed(SqlDataReader reader)
        {

            Vaspitač vaspitac = new Vaspitač {
                VaspitačID = reader.GetInt32(0),
                Ime = reader.GetString(1),
                Prezime = reader.GetString(2),
                Pol = reader.GetString(3),
                Kontakt = reader.GetString(4),
                Program = new Program {
                ProgramID = reader.GetInt32(5),
                 NazivPrograma = reader.GetString(7),
                Opis = reader.GetString(8)
        }
        };
            return vaspitac;
        }

     
        public override string ToString()
        {
            return   $"{Ime} {Prezime}";
        }
    }
}
