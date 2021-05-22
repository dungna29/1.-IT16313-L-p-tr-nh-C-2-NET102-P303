using System;
using System.Text;

namespace BAI_1._5_DELEGATE_EVENT2
{
    class Program
    {
        public delegate void SuKienNhapSo(int x, int y);

        class UserInput
        {
            public event SuKienNhapSo suKienNhapSo;
            public void getInputValue()
            {
                do
                {
                    Console.WriteLine("Mời bạn nhập số 1: ");
                    int a = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Mời bạn nhập số 2: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    suKienNhapSo.Invoke(a,b);
                } while (true);
            }
        }

        class TinhTong//Lớp này nhận sự kiện
        {
            public void thiHanh(UserInput userInput)
            {
                //Không thực hiện phép gán mà phải thực hiện toán tử += hoặc -=
                userInput.suKienNhapSo += tinhTong;//Khi sự kiện nhập số xảy ra thì thi thành tính tổng
            }

            public void tinhTong(int a, int b)
            {
                Console.WriteLine("Tổng 2 số: {0} + {1} = {2}",a,b,a+b);
            }
        }
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
