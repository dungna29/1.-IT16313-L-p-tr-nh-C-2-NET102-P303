using System;
using System.Text;

namespace BAI_1._6_DELEGATE_EVENT3
{
    class Program
    {
        /*
      * Ngoài ra trong C# có sẵn chuẩn tạo ra sẵn sự kiện Delegate
      */

        #region EventHandler bổ sung kiến thức có sẵn trong C#
        class UserInput
        {
            public event EventHandler suKienNhapSo;// Tương đương delegate void ten(object sender, EventArgs args)
            public void getInputValue()
            {
                do
                {
                    Console.WriteLine("Mời bạn nhập số 1: ");
                    int a = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Mời bạn nhập số 2: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    suKienNhapSo.Invoke(this,new UserInput1(a,b));
                } while (true);
            }
        }

        class UserInput1: EventArgs
        {
            public int a { get; set; }//prop + tab
            public int b { get; set; }//prop + tab

            public UserInput1(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        class TinhTong//Lớp này nhận sự kiện
        {
            public void thiHanh(UserInput userInput)
            {
                //Không thực hiện phép gán mà phải thực hiện toán tử += hoặc -=
                userInput.suKienNhapSo += tinhTong;//Khi sự kiện nhập số xảy ra thì thi thành tính tổng
            }

            public void tinhTong(object sender,EventArgs e)
            {
                UserInput1 userInput1 = (UserInput1) e;
                var a = userInput1.a;
                var b = userInput1.b;
                Console.WriteLine("Tổng 2 số: {0} + {1} = {2}", a, b, a + b);
            }
        }


        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phát đi sự kiện
            UserInput userInput = new UserInput();

            //Nhận sự kiện
            TinhTong tinhTong = new TinhTong();
            tinhTong.thiHanh(userInput);//Khởi tạo sự kiện

            //Thực thi khi người dùng nhập vào dủ 2 tham số nó sẽ thi hành sự kiện tính tổng
            userInput.getInputValue();
        }
    }
}
