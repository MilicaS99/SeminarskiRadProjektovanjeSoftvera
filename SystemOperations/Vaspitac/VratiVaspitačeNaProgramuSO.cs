using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class VratiVaspitačeNaProgramuSO : SystemOperationBase
    {
        //private Program program;
        int ProgramId;
        private Program program;

        public List<Vaspitač> Rezultat { get; set; }
        /*public VratiVaspitačeNaProgramuSO(Program program)
        {
            this.program = program;
            ProgramId = program.ProgramID;
        }*/

        public VratiVaspitačeNaProgramuSO(int programID)
        {
            ProgramId = programID;
        }

        public VratiVaspitačeNaProgramuSO(Program program)
        {
            this.program = program;
        }

        protected override void Execute()
        {
            // Rezultat = broker.vratiVaspitačeNaProgramu(program);
          Rezultat = repository.VratiOdredjene(new Vaspitač(), program.ProgramID).OfType<Vaspitač>().ToList();
           
        }
    }
}