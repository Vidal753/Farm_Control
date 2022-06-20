using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_LAYER
{
    public class E_MILKSALE
    {
        private int iDMILKSALE;
        private int aMOUNT;
        private decimal pRICE;
        private decimal tOTAL;
        private String dATEPURCHASE;
        private int iDCUSTOMERS;

        private String aMOUNTTOTAL;
        private String tOTALPRICE;
        private String cUSTOMER;
        private String tOTALS;
        private String dATE;
        public int IDMILKSALE { get => iDMILKSALE; set => iDMILKSALE = value; }
        public int AMOUNT { get => aMOUNT; set => aMOUNT = value; }
        public decimal PRICE { get => pRICE; set => pRICE = value; }
        public decimal TOTAL { get => tOTAL; set => tOTAL = value; }
        public string DATEPURCHASE { get => dATEPURCHASE; set => dATEPURCHASE = value; }
        public int IDCUSTOMERS { get => iDCUSTOMERS; set => iDCUSTOMERS = value; }
        public string AMOUNTTOTAL { get => aMOUNTTOTAL; set => aMOUNTTOTAL = value; }
        public string TOTALPRICE { get => tOTALPRICE; set => tOTALPRICE = value; }
        public string CUSTOMER { get => cUSTOMER; set => cUSTOMER = value; }
        public string TOTALS { get => tOTALS; set => tOTALS = value; }
        public string DATE { get => dATE; set => dATE = value; }
    }
}
