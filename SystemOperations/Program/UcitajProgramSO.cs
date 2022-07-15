using Domain;

namespace SystemOperations
{
    public class UcitajProgramSO : SystemOperationBase
    {
        private Program program;

        public Program Rezultat { get; set; }
        public UcitajProgramSO(Program program)
        {
            this.program = program;
        }

        protected override void Execute()
        {
            Rezultat = (Program)repository.VratiSamoJedan(program);
        }
    }
}