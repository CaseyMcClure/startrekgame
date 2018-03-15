using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperStarTrek
{
    public class Subsystem
    {
        int integrity = 10;
        public int maxIntegrity = 10;

        public int GetIntegrity()
        {
            return maxIntegrity;
        }
    }
}
