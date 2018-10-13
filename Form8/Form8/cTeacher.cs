using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form8
{
    public class cTeacher:cPerson
    {
        #region Các biến lớp
        private string makhoa;
        private string chuyennganh;
        #endregion

        #region Constructor
        public cTeacher()
        {
            makhoa = "";
            chuyennganh = "";
        }

        public cTeacher(string MaKhoa, string ChuyenNganh)
        {
            this.makhoa = MaKhoa;
            this.chuyennganh = ChuyenNganh;
        }
        #endregion

        #region Properties
        public string MaKhoa
        {
            get { return this.makhoa; }
            set { this.makhoa = value; }
        }
        public string ChuyenNganh
        {
            get { return this.chuyennganh; }
            set { this.chuyennganh = value; }
        }
        #endregion
    }
}
