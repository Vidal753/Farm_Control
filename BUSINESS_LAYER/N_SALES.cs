using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_LAYER;
using ENTITIES_LAYER;
using System.Data;
namespace BUSINESS_LAYER
{
     public class N_SALES
    {
        D_SALES data = new D_SALES();
        E_SALES entities = new E_SALES();
        public DataTable SalesListing()
        {
            return data.SaleList();

        }
        public void DeletingWonsale(int id)
        {
            data.DeleteWonSale(id);
        }
        public void InsertingWonsale(E_SALES entities)

        {
            data.InsertWonsale(entities);
        }
        public void ShowingTotals(E_SALES entities)
        {
            data.ShowTotals(entities);
        }
    }
}
