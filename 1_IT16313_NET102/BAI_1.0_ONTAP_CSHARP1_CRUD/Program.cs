using System;
using System.Text;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    class Program
    {
        /*
         * Quản lý sinh viên
         */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ServiceStudent service = new ServiceStudent();
            do
            {
                service.getlstSv();
                service.findSinhVien();
            } while (true);
        }
    }
}
