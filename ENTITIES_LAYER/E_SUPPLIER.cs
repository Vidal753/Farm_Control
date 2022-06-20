using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_LAYER
{
     public class E_SUPPLIER
    {
        private int IDSUPPLIER;
        private String CEDULA;
        private String NAMES;
        private String LASTNAME;
        private String PHONE;
        private String ADRESS;

        public int IDSUPPLIER1 { get => IDSUPPLIER; set => IDSUPPLIER = value; }
        public string CEDULA1 { get => CEDULA; set => CEDULA = value; }
        public string NAMES1 { get => NAMES; set => NAMES = value; }
        public string LASTNAME1 { get => LASTNAME; set => LASTNAME = value; }
        public string PHONE1 { get => PHONE; set => PHONE = value; }
        public string ADRESS1 { get => ADRESS; set => ADRESS = value; }
    }
}
