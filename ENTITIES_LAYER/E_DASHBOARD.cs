using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_LAYER
{
    public class E_DASHBOARD
    {
        private string tOTALSALE;
        private string tOTALPURCHASE;
        private string tOTALMILKSALE;
        private string tOTALPAY;
        private string tOTALWOKERS;
        private string tOTALCUSTOMERS;
        private string tOTALSUPPLIER;
        private string tOTALCATTLE;
        private string mONEY;
        private string dATE1;
        private string dATE2;

        public string TOTALSALE { get => tOTALSALE; set => tOTALSALE = value; }
        public string TOTALPURCHASE { get => tOTALPURCHASE; set => tOTALPURCHASE = value; }
        public string TOTALMILKSALE { get => tOTALMILKSALE; set => tOTALMILKSALE = value; }
        public string TOTALPAY { get => tOTALPAY; set => tOTALPAY = value; }
        public string DATE1 { get => dATE1; set => dATE1 = value; }
        public string DATE2 { get => dATE2; set => dATE2 = value; }
        public string TOTALWOKERS { get => tOTALWOKERS; set => tOTALWOKERS = value; }
        public string TOTALCUSTOMERS { get => tOTALCUSTOMERS; set => tOTALCUSTOMERS = value; }
        public string TOTALSUPPLIER { get => tOTALSUPPLIER; set => tOTALSUPPLIER = value; }
        public string TOTALCATTLE { get => tOTALCATTLE; set => tOTALCATTLE = value; }
        public string MONEY { get => mONEY; set => mONEY = value; }
    }
}
