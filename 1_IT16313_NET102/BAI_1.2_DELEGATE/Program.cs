using System;
using System.Text;

namespace BAI_1._2_DELEGATE
{
    //Delegate có thể khai báo bên trong hoặc bên ngoài class
    public delegate void ShowMessage(string mess);
    class Program
    {
        #region Bài về Delegate
        /*
           * Định nghĩa:
               * ❑Delegate là một biến chứa tham chiếu đến phương thức cần thực thi.
                 ❑Một delegate có thể trỏ tới một hoặc nhiều phương thức
                 ❑Delegate có thể gọi bất kỳ phương thức nào nó trỏ tới tại thời điểm thực thi
                 ❑
           * + Có thể khai báo trong namespace hoặc khai báo trong class
           * + Khi khai báo giống như khai báo một phương thức
           * + Công thức:
           *      <phạm vi truy cập> delegate <kiểu phương thức> <tên>(<Tham số>); 
           */
        static void Info1(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Info1 = " + s);
            Console.ResetColor();
        }
        static void Info2(string s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Info2 = " + s);
            Console.ResetColor();
        }


        #endregion
        static void Main(string[] args)
        {
          
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            #region Phần 1: Khởi tạo delegate null
            Console.WriteLine("========Phần 1: Khởi tạo delegate null========");
            ShowMessage showMessage = null;//Khởi tạo delegate = null
            showMessage = Info1;//Gán phương thức và showMessage sẽ trỏ đến phương thức đó
            //Info1("Xin chào các bạn học delegate");//Cách học của C#1 khi chưa biết về delegate
            showMessage("Xin chào các bạn học delegate");
            //Kiểm tra delegate trước khi thực thi
            //if(showMessage==null) return;//Nếu delegate null thì sẽ return
             showMessage?.Invoke("Xin chào các bạn học delegate");//?Kiểm tra xem delegate có null hay không và nếu không null thì sẽ thực thi


            #endregion

            #region Phần 2: Khởi tạo đối tượng Delegate
            Console.WriteLine("========Phần 2: Khởi tạo đối tượng Delegate========");
            ShowMessage showMessage2 = new ShowMessage(Info1);//Tham chiếu phương thức Info1 thông qua contructor
            showMessage2("Chào các bạn POLY .NET học DELEGATE");
            #endregion

            #region Phần 3: C# Multicast Delegates
            Console.WriteLine("========Phần 3: C# Multicast Delegates========");
            ShowMessage showMessage3 = new ShowMessage(Info1);
            ShowMessage showMessage4 = new ShowMessage(Info2);
            ShowMessage multicast;
            multicast = showMessage3 + showMessage4;
            multicast = multicast + showMessage;//cách viết này tương ứng cách +=
            multicast += showMessage3;
            multicast += showMessage4;
            multicast("Các bạn đang học multicast");
            #endregion

            #region Phần 4: Delegate Callback
            Console.WriteLine("========Phần 4: Delegate Callback========");
            DelegateCallback delegateCallback = new DelegateCallback(showMess);
            callBackMethod(delegateCallback);

            #endregion
        }
        #region Phần 4: Delegate Callback
        public delegate void DelegateCallback(string mess);
        public static void showMess(string mess)
        {
            Console.WriteLine("Thông báo: " + mess);
        }
        public static void callBackMethod(DelegateCallback delegateCallback)
        {
            Console.WriteLine("Mời bạn nhập thông báo: ");
            var mess = Console.ReadLine();
            delegateCallback(mess);
        }

        #endregion
    }
}
