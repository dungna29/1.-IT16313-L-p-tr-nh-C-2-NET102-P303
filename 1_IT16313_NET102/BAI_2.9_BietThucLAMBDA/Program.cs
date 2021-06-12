using System;
using System.Security.Cryptography.X509Certificates;

namespace BAI_2._9_BietThucLAMBDA
{
    class Program
    {
        #region Lambda định nghĩa
        /*
                * Biểu thức lambda còn gọi là biểu thức (Anonymous), một biểu thức khai báo giống phương thức nhưng thiếu tên. Cú pháp để khai báo biểu thức lambda là sử dụng toán dử => như sau:

                   Công thức 1:
                       (tham_số) => biểu_thức;

                   Công thức 2:
                   (tham_số) =>
                       {
                          các câu lệnh
                          Sử dụng return nếu có giá trị trả về
                       }            

                */
        //Ví dụ 1: Sử dụng Delegate với lambda
        delegate int TinhTong(int a, int b);

        public static void Vidu1()
        {
            int a = 9, b = 11;
            TinhTong tinhTong = (int x, int y) =>
            {
                return x + y * 2;
            };
            TinhTong tinhTong2 = (int x, int y) => x + y;//Cách viết gọn hơn
            Console.WriteLine(tinhTong2(a, b));//Gọi phương thức để thực thi
        }

        //Ví dụ 2: Viết phương thức kiểu lambda
        static int PhepNhan(int x, int y, int z) => x * y * z;

        //Ví dụ 3:
        public static void ViDu3()
        {
            // Array.ForEeach<T>(T[] array, Action<T> action)
            int[] arrs = { 1, 2, 3, 9 };
            //Cách 1:
            Array.ForEach(arrs, delegate (int x) { Console.WriteLine(x + " "); });

            //Cách 2:
            Array.ForEach(arrs, x => Console.WriteLine(x + " "));

            //Cách 3:
            foreach (var x in arrs) Console.WriteLine(x + " ");

        }

        #endregion

        #region Một số quy tắc khi sử dụng lambda;
        delegate void ChaoBan1(string name);
        delegate void ChaoBan2();
        delegate void ChaoBan3(string name1, string name2, string name3);
        delegate int TinhToan(int a, int b);
        delegate bool Check1(int a, int b);

        static void ViDu4()
        {
            //1. Không quan tâm đến kiểu dữ liệu đầu vào
            ChaoBan1 chaoBan1 = (string temp) => { Console.WriteLine("Chào bạn " + temp); };
            ChaoBan1 chaoBan2 = (temp) => { Console.WriteLine("Chào bạn " + temp); };

            //2. Để trống nếu không có tham số ()
            ChaoBan2 chaoBan3 = () => { Console.WriteLine("Chào bạn "); };

            //3. Nếu chỉ có một tham số bỏ luôn dấu ()
            ChaoBan1 chaoBan4 = temp => { Console.WriteLine("Chào bạn " + temp); };

            //4. Nếu có nhiều tham số ngăn cách bằng dấu ,
            ChaoBan3 chaoBan5 = (x, y, z) => { Console.WriteLine("Chào " + x + y + z); };

            //5. Nếu phương thức chỉ có 1 câu lệnh thực thi bỏ dấu {}
            ChaoBan3 chaoBan6 = (x, y, z) => Console.WriteLine("Chào " + x + y + z);

            //6. Đối với phương thức return
            TinhToan tinhToan = (x, y) => { return x + y; };
            Check1 check1 = (x, y) => { return x > 4 && y < 4; };
        }

        #endregion
        static void Main(string[] args)
        {
            Vidu1();
        }
    }
}
