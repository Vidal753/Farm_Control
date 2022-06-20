using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_LAYER
{
    public class E_SALES
    {
        private int pRICE;
        private int aMOUNT;
        private int iDWON;
        private int iDWONSALE;
        private string dATE;
        private Decimal tOTAL;
        private int iDCUSTOMERS;
        private string pAY;

        private String tOTALCATTLE;
        private String tOTALRACE;
        private String tOTALCATEGORY;
        private String tOTALPURCHASE;
        private String dATE2;
        public int PRICE { get => pRICE; set => pRICE = value; }
        public int AMOUNT { get => aMOUNT; set => aMOUNT = value; }
        public int IDWON { get => iDWON; set => iDWON = value; }
        public int IDWONSALE { get => iDWONSALE; set => iDWONSALE = value; }
        public string DATE { get => dATE; set => dATE = value; }
        public decimal TOTAL { get => tOTAL; set => tOTAL = value; }
        public int IDCUSTOMERS { get => iDCUSTOMERS; set => iDCUSTOMERS = value; }
        public string PAY { get => pAY; set => pAY = value; }
        public string TOTALCATTLE { get => tOTALCATTLE; set => tOTALCATTLE = value; }
        public string TOTALRACE { get => tOTALRACE; set => tOTALRACE = value; }
        public string TOTALCATEGORY { get => tOTALCATEGORY; set => tOTALCATEGORY = value; }
        public string TOTALPURCHASE { get => tOTALPURCHASE; set => tOTALPURCHASE = value; }
        public string DATE2 { get => dATE2; set => dATE2 = value; }
    }
}
