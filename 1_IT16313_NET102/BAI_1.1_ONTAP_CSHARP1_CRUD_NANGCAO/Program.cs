using System;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khi muốn sử dụng các chức năng của Student
            IServiceStudent iServiceStudent = new ServiceStudent();
            iServiceStudent.addSinhVien();
            iServiceStudent.findSinhVien();
        }
    }
}
