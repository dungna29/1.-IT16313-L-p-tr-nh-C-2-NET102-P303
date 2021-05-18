using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    //Lớp cha: Đưa các thuộc tính chung và phương thức chung lên lớp cha
    //Lớp cha abstract: giống như lớp cha bình thường chỉ khác là phải có phương thức abstract trong class
    abstract class Person
    {
        private int id;
        private string ten;
        private string sdt;
        private int gioiTinh;

        public Person()
        {
            
        }

        public Person(int id, string ten, string sdt, int gioiTinh)
        {
            this.id = id;
            this.ten = ten;
            this.sdt = sdt;
            this.gioiTinh = gioiTinh;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public int GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public virtual void inRaManHinh1()
        {

        }

        //Phương thức abstract: Không có body code
        public abstract void inRaManHinh2();
        public abstract void inRaManHinh3();
        public abstract void inRaManHinh4(string name, string year);
    }
}
