using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCONController
{
    public class Preset
    {
        public String name;
        public double position;

        public Preset()
        {
        }
        public Preset(string name, double position)
        {
            this.name = name;
            this.position = position;
        }
    }
}
