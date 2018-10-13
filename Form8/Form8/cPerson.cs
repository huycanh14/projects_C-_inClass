using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form8
{
    public class cPerson
    {
        #region Các biến lớp
        private string ten;
        private int tuoi;
        private string diachi;
        #endregion

        #region Constructor - Kiểu tham số
        //Hàm tạo không có đối số
        public cPerson()
        {
            ten = "";
            tuoi = 0;
            diachi = "";
        }

        //Hàm tạo có đối số
        public cPerson(string Ten, int Tuoi, string DiaChi)
        {
            this.ten = Ten;
            this.tuoi = Tuoi;
            this.diachi = DiaChi;
        }
        #endregion

        #region Properties  - thuộc tính
        //Phương thức get - set cho thuộc tính
        public string Ten
        {
            get
            { return this.ten; }
            set
            { this.ten = value; }
        }
        public int Tuoi
        {
            get
            { return this.tuoi; }
            set
            { this.tuoi = value; }
        }
        public string DiaChi
        {
            get
            { return this.diachi; }
            set
            { this.diachi = value; }
        }
        #endregion

        #region Phương thưc
        //
        public override string ToString()
        {
            return this.ten + "\t" + this.tuoi + "\t" + this.diachi;
        }
        #endregion
    }
}
