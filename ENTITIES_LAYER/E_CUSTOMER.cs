using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_LAYER
{
    public class E_CUSTOMER
    {
        private int iDCUSTOMER;
        private String cEDULA;
        private String nAMES;
        private String lASTNAME;
        private String pHONE;
        private String aDRESS;

        public int IDCUSTOMER { get => iDCUSTOMER; set => iDCUSTOMER = value; }
        public string CEDULA { get => cEDULA; set => cEDULA = value; }
        public string NAMES { get => nAMES; set => nAMES = value; }
        public string LASTNAME { get => lASTNAME; set => lASTNAME = value; }
        public string PHONE { get => pHONE; set => pHONE = value; }
        public string ADRESS { get => aDRESS; set => aDRESS = value; }

    }
}
