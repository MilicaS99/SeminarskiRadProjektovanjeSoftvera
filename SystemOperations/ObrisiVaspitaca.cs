using Domain;

namespace SystemOperations
{
    public class ObrisiVaspitaca : SystemOperationBase
    {
        private object vaspitac;

        public ObrisiVaspitaca(Vaspitač vaspitac)
        {
            this.vaspitac = vaspitac;
        }

        protected override void Execute()
        {
            repository.Obrisi(vaspitac as Vaspitač);
        }
    }
}