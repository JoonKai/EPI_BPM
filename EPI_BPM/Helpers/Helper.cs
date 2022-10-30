using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPI_BPM.Helpers
{
    public static class Helper
    {
        public static DataGridViewHelper DGVHelper { get; private set; }
        static Helper()
        {
            DGVHelper = new DataGridViewHelper();
        }
    }
}
