using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_LAYER
{
    public class E_PRICEWORK
    {
        private int iDPRICE;
        private decimal tOTAL;
        private int iDWORKERS;
        private int iDJOB;
        private String sTAR;
        private String fINISH;

        public int IDPRICE { get => iDPRICE; set => iDPRICE = value; }
        public decimal TOTAL { get => tOTAL; set => tOTAL = value; }
        public int IDWORKERS { get => iDWORKERS; set => iDWORKERS = value; }
        public int IDJOB { get => iDJOB; set => iDJOB = value; }
        public string STAR { get => sTAR; set => sTAR = value; }
        public string FINISH { get => fINISH; set => fINISH = value; }
    }
}
