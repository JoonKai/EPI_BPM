using EPI_BPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPI_BPM.Helpers
{
    public class DataGridViewHelper
    {
        public int GetCostCategoryCount()
        {
            int count = 0;
            count = System.Enum.GetValues(typeof(CostCategoryEnum)).Length;
            return count;
        }
        public List<string> GetCostCotegoryList()
        {
            List<string> result = new List<string>();
            result = System.Enum.GetNames(typeof(CostCategoryEnum)).ToList();
            return result;
        }
    }
}
