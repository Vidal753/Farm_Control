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
    public class N_DASHBOARD
    {
        D_DASHBOARD data = new D_DASHBOARD();
        E_DASHBOARD entities = new E_DASHBOARD();

        public void ShowingTotal(E_DASHBOARD entities)
        {
            data.ShowTotals(entities);
        }
    }
}
