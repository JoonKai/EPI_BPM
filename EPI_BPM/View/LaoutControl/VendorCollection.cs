using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPI_BPM.View.LaoutControl
{
    public class VendorCollection: ObservableCollection<Vendor>
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - PersonCollection()

        /// <summary>
        /// 생성자
        /// </summary>
        public VendorCollection()
        {
            Add(new Vendor() { VendorCode = "33021", VendorName = "밸류엔지니어링" });
            Add(new Vendor() { VendorCode = "23333", VendorName = "에바라" });
            Add(new Vendor() { VendorCode = "34455", VendorName = "위드텍" });
            Add(new Vendor() { VendorCode = "42222", VendorName = "씨에스텍" });
            Add(new Vendor() { VendorCode = "5552", VendorName = "화인클린" });
        }

        #endregion
    }
}
