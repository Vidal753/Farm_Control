using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_LAYER
{
    public class E_JOB
    {
        private int iDJOB;
        private String jOB;
        private String dESCRIP;

        public int IDJOB { get => iDJOB; set => iDJOB = value; }
        public string JOB { get => jOB; set => jOB = value; }
        public string DESCRIP { get => dESCRIP; set => dESCRIP = value; }
    }
}
