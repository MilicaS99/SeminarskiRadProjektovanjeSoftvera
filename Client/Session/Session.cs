using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Session
{
   public  class Session
    {

        private Session() { }
        private static Session instance;
        public static Session Instance
        {
            get
            {
                if (Instance == null) instance = new Session();
                return instance;
            }
        }
    }
}
