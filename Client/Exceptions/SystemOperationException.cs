﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Exceptions
{
    class SystemOperationException:Exception
    {
        public SystemOperationException(string message) : base(message)
        {
        }
    }
}
