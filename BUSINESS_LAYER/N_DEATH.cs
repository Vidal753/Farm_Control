using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATA_LAYER;
using ENTITIES_LAYER;
namespace BUSINESS_LAYER
{
    public class N_DEATH
    {
        D_DEATH data = new D_DEATH();
        public DataTable DeathListing()
        {
            return data.DeathList();

        }
        public void InsertingDeath(E_DEATH entities)
        {
            data.InsertDeath(entities);
        }
    }
}
