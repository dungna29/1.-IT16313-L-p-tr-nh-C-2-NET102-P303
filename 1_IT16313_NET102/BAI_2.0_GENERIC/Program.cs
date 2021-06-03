using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BAI_2._0_GENERIC
{
    class Program
    {
        #region Tham trị và Tham chiếu
        /*
         * Có hai hình thức truyền tham số cho phương thức khi nó được gọi là tham trị và tham chiếu:    
            + Tham trị là cách thức mặc định khi tham số đó là kiểu giá trị. Có nghĩa là gán tham số bằng một biến, thì giá trị của biến được copy và sử dụng trong phương thức như biến cục bộ, còn bản thân biến bên ngoài không hề ảnh hưởng.

            + Tham chiếu là cách thức mặc định khi tham số đó là kiểu tham chiếu, thì bản thân biến ở tham số sẽ được hàm sử dụng trực tiếp (tham chiếu) chứ không tạo ra một biến cục bộ trong hàm, nên nó có tác động trực tiếp đến biến này bên ngoài.
                - Trong phần này mở rộng thêm, nếu muốn biến kiểu giá trị nhưng được truyền vào phương thức dạng tham chiếu (giống cách thức biến tham chiếu) thì khai báo tham số ở phương thức, cũng như khi gọi cần cho thêm từ khóa ref
         */

        #endregion

        #region GENERIC
        /*
        * ❑ Generic trong C# cho phép định nghĩa một phương thức,một lớp mà không cần chỉ ra đối số kiểu dữ liệu là gì.
          ❑ Generic cũng là một kiểu dữ liệu trong C# như int, string, bool,… nhưng nó là một kiểu dữ liệu “tự do”, tùy vào mục đích sử dụng mà nó có thể đại diện cho tất cả các kiểu dữ liệu còn lại.
          ❑ Có thể định nghĩa lớp, interface, phương thức, delegate như là kiểu generic
        */

        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            int x = 99, y = 88;
            Console.WriteLine($"x = {x}  và y = {y}");
            thamTri(x,y);
            Console.WriteLine($"Sau khi tham trị: x = {x}  và y = {y}");
            thamChieu(ref x, ref y);
            Console.WriteLine($"Sau khi tham chiếu: x = {x}  và y = {y}");

            double a = 9.9, b = 2.1;
            //thamChieuGeneric(ref a, ref b);
            thamChieuGeneric<double>(ref a, ref b);//Viết theo kiểu tường minh hơn
            Console.WriteLine($"Sau khi tham chiếu: a = {a}  và b = {b}");
            long l1 = 11, l2 = 3;
            thamChieuGeneric(ref l1, ref l2);
            Console.WriteLine($"Sau khi tham chiếu: l1 = {l1}  và l2 = {l2}");
        }

        static void thamTri(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void thamChieu(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        /*
         * Phương thức Generic
         */
        static void thamChieuGeneric<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
