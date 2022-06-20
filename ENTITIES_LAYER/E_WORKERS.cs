using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_LAYER
{
    public class E_WORKERS
    {
        private int iDWORKERS;
        private String cEDULA;
        private String nAMES;
        private String lASTNAME;
        private String pHONE;

        public int IDWORKERS { get => iDWORKERS; set => iDWORKERS = value; }
        public string CEDULA { get => cEDULA; set => cEDULA = value; }
        public string NAMES { get => nAMES; set => nAMES = value; }
        public string LASTNAME { get => lASTNAME; set => lASTNAME = value; }
        public string PHONE { get => pHONE; set => pHONE = value; }
    }
}
