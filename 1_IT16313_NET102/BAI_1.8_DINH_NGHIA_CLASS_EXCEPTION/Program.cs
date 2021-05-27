using System;
using System.Text;

namespace BAI_1._8_DINH_NGHIA_CLASS_EXCEPTION
{
    class Program
    {
        #region Phần 1: Định nghĩa ra 1 EXCEPTION bên trong 1 phương thức

        static string dangKyVaoClubCsharp(string ten, int tuoi)
        {
            if (string.IsNullOrEmpty(ten))
            {
                Exception exception = new Exception("Tên không được null");
                throw exception;
            }

            if (tuoi < 18)
            {
                throw new Exception("Bạn cần trên 18 tuổi nhé!");
            }
            return "Chào mừng bạn đến với Club: " + ten + tuoi;
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            #region Phần 1 
            try
            {
                Console.WriteLine(dangKyVaoClubCsharp("123", 17));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            #region Phần 2: Định nghĩa 1 class Exception

            try
            {
                Console.WriteLine(dangKyVaoClubCsharp1("123", 17));
            }
            catch (NameException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
                e.MessByAgeException(); //Phương riêng của Age
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
        }

        #region Phần 2: Định nghĩa 1 class Exception
        static string dangKyVaoClubCsharp1(string ten, int tuoi)
        {
            if (string.IsNullOrEmpty(ten))
            {
                throw new NameException("Tên ko được Null hoặc Empty");
            }

            if (tuoi < 18)
            {
                throw new AgeException("Bạn cần trên 18 tuổi nhé!", tuoi);
            }
            return "Chào mừng bạn đến với Club: " + ten + tuoi;
        }
        #endregion
    }
}
