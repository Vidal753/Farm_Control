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
    public class N_PRICEWORK
    {
        D_PRICEWORK data = new D_PRICEWORK();
        E_PRICEWORK entities = new E_PRICEWORK();
        public DataTable PriceListing()
        {
            return data.PriceListing();

        }
        public DataTable SerchingPrice(String Cedula, String Names, String LastName)
        {
            E_WORKERS entities = new E_WORKERS();
           
            entities.CEDULA = Cedula;
            entities.NAMES = Names;
            entities.LASTNAME = LastName;
         
            return data.SearchPrice(entities);
        }
        public void DeletingPrice(int id)
        {
            data.DeletePrice(id);
        }
        public void UpdatingPrice(E_PRICEWORK entities)
        {
            data.UpdatePriceWorker(entities);
        }
        public void InsertPrice(E_PRICEWORK entities)

        {
            data.InsertPrice(entities);
        }
    }
}
