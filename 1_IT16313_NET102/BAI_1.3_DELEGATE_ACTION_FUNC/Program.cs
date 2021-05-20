using System;
using System.Text;

namespace BAI_1._3_DELEGATE_ACTION_FUNC
{
    class Program
    {
        #region  Bài Action, Predicate, Func: Delegate - Generic(Sử dụng sẵn tham số Generic để khai báo)
        static void Info1(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Info2(string s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Info3(string s, int b)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(s + b);
            Console.ResetColor();
        }

        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            #region Phần 1: Action khai báo với phương thức void
            Console.WriteLine("==== Phần 1: Action khai báo với phương thức void ====");
            Action action;// tương đương như delegate void TenDelegate();          
            Action<string, int> action1;// tương đương như delegate void TenDelegate(string a, int b);
            Action<string> action2;// tương đương như delegate void TenDelegate(string a);

            action2 = Info1;
            action2?.Invoke("Đây là phương thức Info1");

            #endregion
        }
    }
}
