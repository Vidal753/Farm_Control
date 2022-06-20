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
    public class N_MILKSALE
    {
        D_MILKSALE data = new  D_MILKSALE();
        E_MILKSALE entities = new E_MILKSALE();
        public DataTable MilkListing()
        {
            return data.MilkList();

        }
        public DataTable SerchingCattle(String Date, String Name, String Lastname, String category, String race)
        {
            E_CUSTOMER customers = new E_CUSTOMER();
          
            entities.DATEPURCHASE = Date;
            customers.NAMES = Name;
            customers.LASTNAME = Lastname;
          
            return data.SearchMilkSale(entities, customers);
        }
        public void DeletingMilkSale(int id)
        {
            data.DeleteMilkSale(id);
        }
        public void UpdatingMilkSale(E_MILKSALE entities)
        {
            data.UpdateMilkSale(entities);
        }
        public void InsertingMilkSale(E_MILKSALE entities)

        {
            data.InsertMilkSale(entities);
        }
        public void ShowingTotal(E_MILKSALE entities)
        {
            data.ShowTotals(entities);
        }
    }
}
