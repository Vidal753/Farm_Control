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
    public class N_SUPPLIER
    {
        D_SUPPLIER data = new D_SUPPLIER();

        public List<E_SUPPLIER> SupplierListing(String Search,String LastName,String Cedula)
        {
            return data.SupplierList(Search, LastName,Cedula);
        }
        public void DeletingSupplier(int id)
        {
            data.DeleteSupplier(id);
        }
        public void UpdatingSupplier(E_SUPPLIER entities)
        {
            data.UpdateSupplier(entities);
        }
        public void InsertingSupplier(E_SUPPLIER entities)
        {
            data.InsertSupplier(entities);
        }

    }
}
