using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form8
{
    public class cStudent:cPerson
    {
        #region Các biến lớp
        private string malop;
        private string masv;
        #endregion

        #region Constructor
        public cStudent()
        {
            malop = "";
            masv = "";
        }
        public cStudent(string MaLop, string MaSV)
        {
            this.malop = MaLop;
            this.masv = MaSV;
        }
        #endregion

        #region Properties
        public string MaLop
        {
            get { return this.malop; }
            set { this.malop = value; }
        }

        public string MaSV
        {
            get { return this.masv; }
            set { this.masv = value; }
        }
        #endregion
    }
}
