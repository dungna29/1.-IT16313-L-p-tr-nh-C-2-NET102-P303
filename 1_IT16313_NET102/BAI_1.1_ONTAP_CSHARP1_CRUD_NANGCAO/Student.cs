using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    //Lớp con khi kế thừa chỉ cần khai báo các thuộc tính đặng trưng riêng của đối tượng
    //Khi kế thừa 1 lớp abstract class thì sẽ phải kế thừa đủ các phương thức abstract có bên lớp cha
    class Student : Person
    {
        private string msv;
        private double lop;

        public Student()
        {
            
        }

        public Student(string msv, double lop)
        {
            this.msv = msv;
            this.lop = lop;
        }
        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public double Lop
        {
            get => lop;
            set => lop = value;
        }

        //Đây là phương thức mà lớp con muốn hoặc ko muốn kế thừa từ lớp cha
        public override void inRaManHinh1()
        {
            base.inRaManHinh1();
        }

        //Dưới đây là 3 phương phước abstract của lớp cha đã có body code - các bạn hoàn toàn có thể code bình thường ở bên trong như 1 phương thức.
        public override void inRaManHinh2()
        {
            
        }

        public override void inRaManHinh3()
        {
            
        }

        public override void inRaManHinh4(string name, string year)
        {
            
        }
    }
}
