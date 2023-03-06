using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCONController
{
    public class PCONState
    {
        //public bool EMGS = false;  //EMG status 
        //public bool SFTY = false;  //Safety speed enabled status
        //public bool PWR = false;   //Controller ready status 
        public bool SV = false;    //Servo On status
        public bool mov = false;
        /*
        public bool PSFL = false;  //Missed work In push-motion operation 
        public bool ALMH = false;  //Major failure status 
        public bool ALML = false;  //Minor failure status 
        public bool ABER = false;  //Absolute Error status ABER
        public bool BKRL = false;  //Brake forced-release status 
        public bool STP = false;   //Pause status 
        public bool HEND = false;  //Home Return status 
        public bool PEND = false;  //Position complete status 
        public bool LOAD = false;  //Load output judgment status 
        public bool TRQS = false;  //Torque level status 
        public bool MODS = false;  //Teaching mode status 
        public bool TEAC = false;  //Position-data load command status 
        public bool JOGUp = false; //Jog+ status 
        public bool JOGDn = false; //Jog- status
        */

        public double PNOW = 0;         //Current Position Monitor (in mm/s)
        public int PNOW_LO = 0;
        public int PNOW_HI = 0;
        public int ALMC = 0;            //Present alarm code query
        /*
        public double DIPM = 0;         //Input port query
        public double DOPM = 0;         //Ouput port monitor query
        public int DSS1 = 0;            //Device status query 1
        public int DSS2 = 0;            //Device status query 2
        public int DSSE = 0;            //Expansion device status query
        public int STAT = 0;            //System status query (high Byte)
        */
        public double VNOW = 0;         //Current speed monitor (high Byte) (in mm/s)
        public int VNOW_LO = 0;
        public int VNOW_HI = 0;

        public double CNOW = 0;         //Current ampere monitor (high Byte) (in mA)
        public int CNOW_LO = 0;
        public int CNOW_HI = 0;

        //public double DEVI = 0;         //Deviation Monitor (high Byte)
        //public double STIM = 0;         //System timer query (high Byte)
        public int POSS = 0;


        public bool jogUp = false;
        public bool inchUp = false;
        public bool jogDown = false;
        public bool inchDown = false;

        public bool jogOrInch = false;
    }
}
