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
    public class N_CATTLE
    {
        D_CATTLE data = new D_CATTLE();
        E_CATTLE entities = new E_CATTLE();
        public DataTable CattleList()
        {
            return data.CattleListing();

        }
        public DataTable SerchingCattle(String Chapa,String Sex,String Stat,String category,String race)
        {
            E_CATEGORY Category = new E_CATEGORY();
            E_RACE Race = new E_RACE();
            entities.CHAPA = Chapa;
            entities.SEX = Sex;
            entities.STAT = Stat;
            Category.CATEGORY1 = category;
            Race.RACE1 = race;
            return data.SearchCattle(entities,Category,Race);
        }
        public void DeletingCattle(int id)
        {
            data.DeleteCattle(id);
        }
        public void UpdatingCattle(E_CATTLE entities)
        {
            data.UpdateCattle(entities);
        }
        public void UpdatingPro(E_CATTLE entities)
        {
            data.UpdatePro(entities);
        }
        public void InsertCattle(E_CATTLE entities)

        {
            data.InsertCattle(entities);
        }
        public void ShowingTotals(E_CATTLE entities)
        {
            data.ShowTotals(entities);
        }
    }
}
