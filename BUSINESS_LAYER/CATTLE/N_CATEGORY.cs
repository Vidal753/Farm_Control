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
    public class N_CATEGORY
    {
        D_CATEGORY data = new D_CATEGORY();
        public List<E_CATEGORY> CategoryListing(string Search)
        {
            return data.CategoryList(Search);
        }
        public void DeletingCategory(E_CATEGORY entities)
        {
            data.DeleteCategory(entities);
        }
        public void EditingCategory(E_CATEGORY entities)
        {
            data.EditCategory(entities);
        }
        public void SavingCategory(E_CATEGORY entities)
        {
            data.SaveCategory(entities);
        }
    }
}
