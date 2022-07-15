using Domain;

namespace SystemOperations
{
    public class UcitajVaspitacaSO : SystemOperationBase
    {
        private Vaspitač vaspitač;

        public UcitajVaspitacaSO(Vaspitač vaspitač)
        {
            this.vaspitač = vaspitač;
        }

        public Vaspitač Rezultat { get; set; }

        protected override void Execute()
        {
            Rezultat = (Vaspitač)repository.VratiUčitanObjekat(vaspitač);
        }
    }
}