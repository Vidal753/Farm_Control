using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_LAYER;
using ENTITIES_LAYER;
namespace BUSINESS_LAYER
{
    public class N_WORKERS
    {
        D_WORKERS data = new D_WORKERS();
        public List<E_WORKERS> WorkerListing(string Search, String LastName, String Cedula)
        {

            return data.WorkersList(Search,LastName,Cedula);
        }
        public void DeletingWorker(int id)
        {
            data.DeleteWorker(id);
        }
        public void UpdatingWorker(E_WORKERS entities)
        {
            data.UpdateWorker(entities);
        }
        public void InsertingWorker(E_WORKERS entities)
        {
            data.InsertWorker(entities);
        }
    }
}
