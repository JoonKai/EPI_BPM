using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPI_BPM.View.LaoutControl
{
    public class Vendor
    {
        #region 업체코드 - 코드

        /// <summary>
        /// ID
        /// </summary>
        public string VendorCode { get; set; }

        #endregion
        #region 업체명 - Name

        /// <summary>
        /// 성명
        /// </summary>
        public string VendorName { get; set; }

        #endregion
        #region 담당자- 담당자

        /// <summary>
        /// 성명
        /// </summary>
        public string VendorPerson { get; set; }

        #endregion
        #region 연락처 - 연락처

        /// <summary>
        /// 성명
        /// </summary>
        public string VendorPersonCellPhone { get; set; }

        #endregion
        #region 업체취급품목 - 업체취급품목

        /// <summary>
        /// 성명
        /// </summary>
        public string VendorProduct { get; set; }

        #endregion
        #region 기타 - 기타

        /// <summary>
        /// 성명
        /// </summary>
        public string VendorNote { get; set; }

        #endregion
    }
}
