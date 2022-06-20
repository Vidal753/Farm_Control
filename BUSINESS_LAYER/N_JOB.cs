using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_LAYER;
using ENTITIES_LAYER;

namespace BUSINESS_LAYER
{
    public class N_JOB
    {
        D_JOB  data = new D_JOB();
        public List<E_JOB> JobListing(string Search)
        {
            return data.JobList(Search);
        }
        public void DeletingJob(E_JOB entities)
        {
            data.DeleteJob(entities);
        }
        public void EditingJob(E_JOB entities)
        {
            data.UpdateJob(entities);
        }
        public void InsertingJob(E_JOB entities)
        {
            data.InsertJob(entities);
        }
    }
}
