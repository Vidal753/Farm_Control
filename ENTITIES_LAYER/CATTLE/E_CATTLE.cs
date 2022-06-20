using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_LAYER
{
    public class E_CATTLE
    {
        private int iDCATTLE;
        private String cHAPA;
        private int wEIGTHS;
        private String cOLOUR;
        private String sTAT;
        private String sEX;
        private String dATEBORN;
        private int iDCATEGORY;
        private int iDRACE;
        private String eSTATUS;
        private String tOTALCATTLE;
        private String tOTALRACE;
        private String tOTALCATEGORY;
        public int IDCATTLE { get => iDCATTLE; set => iDCATTLE = value; }
        public string CHAPA { get => cHAPA; set => cHAPA = value; }
        public int WEIGTHS { get => wEIGTHS; set => wEIGTHS = value; }
        public string COLOUR { get => cOLOUR; set => cOLOUR = value; }
        public string STAT { get => sTAT; set => sTAT = value; }
        public string SEX { get => sEX; set => sEX = value; }
        public String DATEBORN { get => dATEBORN; set => dATEBORN = value; }
        public int IDCATEGORY { get => iDCATEGORY; set => iDCATEGORY = value; }
        public int IDRACE { get => iDRACE; set => iDRACE = value; }
        public string TOTALCATTLE { get => tOTALCATTLE; set => tOTALCATTLE = value; }
        public string TOTALRACE { get => tOTALRACE; set => tOTALRACE = value; }
        public string TOTALCATEGORY { get => tOTALCATEGORY; set => tOTALCATEGORY = value; }
        public string ESTATUS { get => eSTATUS; set => eSTATUS = value; }
    }
}
