using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    interface IServiceStudent
    {
        /*
         * 1. Không thể sử dụng từ khóa private ở đây
         * 2. Không có phương thức có body code
         * 3. Các phương thức sẽ luôn là public
         * 4. Khi sử dụng interface thì nên comment vào từng phương thức
         */
        void addSinhVien();
        public void addSinhVienDungna();
        public void findSinhVien();
        public void removeSinhVien();
        public void getlstSv();

        public Student[] getArrStudents(string idStudent);
    }
}
