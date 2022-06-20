using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_LAYER
{
    public class E_DEATH
    {
        private int iDEATH;
        private String dATEDIE;
        private String dESCRIPTION;
        private int iDCATTLE;

        public int IDEATH { get => iDEATH; set => iDEATH = value; }
        public string DATEDIE { get => dATEDIE; set => dATEDIE = value; }
        public string DESCRIPTION { get => dESCRIPTION; set => dESCRIPTION = value; }
        public int IDCATTLE { get => iDCATTLE; set => iDCATTLE = value; }
    }
}
