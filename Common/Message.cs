using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum Operation
    {
        LogIN,
        ZapamtiVaspitača,
        PretražiVaspitača,
        UčitajVaspitača,
        ZapamtiUčenika,
        PretražiUčenike,
        UčitajUčenika,
        UčitajListuUčenika,
        ZapamtiGrupu,
        NadjiGrupe,
        UčitajGrupu,
        UčitajProgram,
        ZapamtiProgram,
        NadjiPrograme,
        UčitajListuPrograma,
        UčitajListuVaspitača,
        zapamtiNovogVaspitača,
        UčitajListuUzrasta,
        VratiListuVaspitača,
        ZapamtiNovuGrupu,
        EndCommunication,
        VratiPohadjanja,
        VratiTrazenuGrupu,
        VratiVaspitačeNaProgramu,
        UcitajVaspitaca,
        UcitajUcenika,
        UcitajProgram,
        ObisiVaspitaca
    }
    [Serializable]
    public class Message
    {
        

        public object messageRequest { get; set; }
        public object messageResponse { get; set; }

        public bool isSuccesfull { get; set; } = true;
        public Operation Operation { get; set; }

        public string ClientMessage { get; set; }
    }
}
