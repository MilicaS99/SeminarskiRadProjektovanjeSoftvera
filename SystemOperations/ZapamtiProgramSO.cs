using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class ZapamtiProgramSO : SystemOperationBase
    {
        private readonly Program program;
        public ZapamtiProgramSO(Program program)
        {
            this.program = program;
        }
        protected override void Execute()
        {
            broker.SacuvajProgram(program);
        }
    }
}
