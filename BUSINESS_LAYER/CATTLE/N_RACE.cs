using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ENTITIES_LAYER;
using DATA_LAYER;

namespace BUSINESS_LAYER
{
     public class N_RACE
    {
        D_RACE data = new D_RACE();

        public List<E_RACE>ListingRace(String Search){
            return data.ListRace(Search);
        }
        public void DeletingRace(E_RACE entities)
        {
            data.DeleteRace(entities);
        }
        public void UpdatingRace(E_RACE entities)
        {
            data.UpdateRace(entities);
        }
        public void InsertingRace(E_RACE entities)
        {
            data.InsertRace(entities);
        }
    }
}
