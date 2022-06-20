using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_LAYER
{
     public class E_PURCHASE
    {
        private int iDPURCHASE;
        private string dATE;
        private decimal tOTAL;
        private int iDSUPPLIER;
        private string pAY;
        private string cODE;

        private int aMOUNT;
        private int iDPURCHASEF;
        private int iDCATTLE;
        private int pRICEKG;

        private string tOTALCATTLE;
        private string tOTALRACE;
        private string tOTALCATEGORY;
        private string tOTALPURCHASE;

        public int IDPURCHASE { get => iDPURCHASE; set => iDPURCHASE = value; }
        public string DATE { get => dATE; set => dATE = value; }
        public decimal TOTAL { get => tOTAL; set => tOTAL = value; }
        public int IDSUPPLIER { get => iDSUPPLIER; set => iDSUPPLIER = value; }
        public string PAY { get => pAY; set => pAY = value; }
        public string CODE { get => cODE; set => cODE = value; }
        public int AMOUNT { get => aMOUNT; set => aMOUNT = value; }
        public int IDPURCHASEF { get => iDPURCHASEF; set => iDPURCHASEF = value; }
        public int IDCATTLE { get => iDCATTLE; set => iDCATTLE = value; }
        public int PRICEKG { get => pRICEKG; set => pRICEKG = value; }
        public string TOTALCATTLE { get => tOTALCATTLE; set => tOTALCATTLE = value; }
        public string TOTALRACE { get => tOTALRACE; set => tOTALRACE = value; }
        public string TOTALCATEGORY { get => tOTALCATEGORY; set => tOTALCATEGORY = value; }
        public string TOTALPURCHASE { get => tOTALPURCHASE; set => tOTALPURCHASE = value; }
    }
}
