using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_LAYER;
using ENTITIES_LAYER;
namespace BUSINESS_LAYER
{
    public class N_CUSTOMER
    {
        D_CUSTOMER data = new D_CUSTOMER();

        public List<E_CUSTOMER> CustomerListing(String Search, String LastName, String Cedula)
        {
            return data.CustomerList(Search, LastName, Cedula);
        }
        public void DeletingCustomer(int id)
        {
            data.DeleteCustomer(id);
        }
        public void UpdateCustomer(E_CUSTOMER entities)
        {
            data.UpdateCustomer(entities);
        }
        public void InsertingCustomer(E_CUSTOMER entities)
        {
            data.InsertCustomer(entities);
        }
    }
}
