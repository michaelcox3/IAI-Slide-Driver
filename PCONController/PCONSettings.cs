using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCONController
{
    public class PCONSettings
    {
        public int VSETLO = 2000;
        public int VSETHI = 0;
        public int ampDownLimit = 100; // Amp Limit (milliamps) when slide is moving down
        public int ampUpLimit = 300;   // Amp Limit (milliamps) when slide is moving up
    }
}
