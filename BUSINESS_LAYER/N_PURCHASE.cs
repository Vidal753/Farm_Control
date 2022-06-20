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
    public class N_PURCHASE
    {
        D_PURCHASE data = new D_PURCHASE();
        E_PURCHASE entities = new E_PURCHASE();
        public DataTable PurchaseListing()
        {
            return data.PurchaseList();

        }
        public DataTable SearchingPurchase(String name, String code, String pay)
        {
            E_SUPPLIER supplier = new E_SUPPLIER();

            entities.CODE = code;
            entities.PAY = pay;
          
            supplier.NAMES1 = name;
          

            return data.SearchPurchase(entities, supplier);
        }
        public void DeletingPurchase(int id)
        {
            data.DeletePurchase(id);
        }
        public void UpdatingPruchase(E_PURCHASE entities)
        {
            data.UpdatePurchase(entities);
        }
        public void InsertingPruchase(E_PURCHASE entities)

        {
            data.InsertPurchase(entities);
        }
        public void ShowingTotals(E_PURCHASE entities)
        {
            data.ShowTotals(entities);
        }
        //public void ShowingTotal(E_MILKSALE entities)
        //{
        //    data.ShowTotals(entities);
        //}
    }
}
