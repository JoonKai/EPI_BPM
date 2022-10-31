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
        public static IniHelper IHelper { get; private set; }
        public static RootHelper RHelper { get; private set; }
        static Helper()
        {
            DGVHelper = new DataGridViewHelper();
            IHelper = new IniHelper();
            RHelper = new RootHelper();

        }
    }
}
