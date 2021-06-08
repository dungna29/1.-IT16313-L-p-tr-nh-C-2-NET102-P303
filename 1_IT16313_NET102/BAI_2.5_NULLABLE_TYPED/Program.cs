using System;

namespace BAI_2._5_NULLABLE_TYPED
{

    class Program
    {
        /*
         * 1. Từ khóa null
         *    + null là một giá trị cố định nó biểu thị không có đối tượng nào cả, có nghĩa là biến có giá trị null không có tham chiếu (trỏ) đến đối tượng nào (không có gì).
           
              + null chỉ có thể gán được cho các biến kiểu tham chiếu (biến có kiểu dữ liệu là các lớp), không thể gán null cho những biến có kiểu dữ liệu dạng tham trị như int, float, bool ...
           
           
         */

        /*
         *2. Sử dụng nullable
         *    + Nếu bạn muốn sử dụng các kiểu dữ liệu nguyên tố như int, float, double ... như là một kiểu dữ liệu dạng tham chiếu, có thể gán giá trị null cho nó, có thể sử dụng như đối tượng ... thì khai báo nó có khả năng nullable, khi biến nullable có giá trị thì đọc giá trị bằng truy cập thành viên .Value, cách làm như sau:
         *    + Khi khai báo biến có khả năng nullable thì thêm vào ? sau kiểu dữ liệu      
         */
        class ClassA
        {
            public void method1()
            {
                Console.WriteLine("Method 1 Class A");
            }
        }
        static void Main(string[] args)
        {
            #region Phần 1 null

            ClassA classA1, classA2;
            classA1 = new ClassA();     // classA1 tham chiếu bằng 1 đối tượng

            classA2 = classA1;          // ClassA1, ClassA2 cùng tham chiếu 1 đối tượng

            classA1 = null;             // ClassA1 gán bằng null => không trỏ đến đối tượng nào
            classA2.method1();          //ClassA2 có trỏ đến đối tượng có thể truy cập đến phương thức của đối tượng
            classA1.method1();          //ClassA1 không trỏ đến tượng nên khi truy cập phương thức sẽ lỗi

            // int temp1 = 10;
            // int temp2 = null;//Lỗi

            #endregion

            #region Phần 2 nullable  Khi khai báo biến có khả năng nullable thì thêm vào ? sau kiểu dữ liệu
            //1. Không thể gán trị null chó biến kiểu int đúng theo định nghĩa
            int? temp3;     // Hoặc Nullable<int> temp3;

            temp3 = null;   //Gán giá trị null cho nó
            temp3 = 10;     //Gán giá trị như biến bình thường

            if (temp3!=null)
            {
                int value = temp3.Value; //Láy giá trị trong biến Nullable
            }

            #endregion

            #region Phần 3: Nullable Typed
            /*2.  NULLABLE TYPED
                 + Cú pháp: 
                     - Nullable<T> tên biến;
                     - T? tên biến;
                 + Cần gán gia trị cho biến khi khai báo nếu không sẽ bị lỗi và nên kiểm tra giá tị trước khi dùng bằng HasValue
                 + Dùng phương thức GetValueOrDefault() để lấy giá mặc định của kiểu dữ liệu
                 + Dùng toán tử ?? thực hiện gán Nullable Type cho Non-Nullable Type
            */
            Nullable<int> temp4 = null;
            Nullable<int> temp5 = 10;
            int? temp6 = 100;
            int?[] arr = new int?[5];

            if (temp4.HasValue) //Kiểm tra giá tị trước khi dùng
            {
                //Thực hiện 1 hành động nào đó
            }
            //GetValueOrDefault() phương thức lấy giá trị mặc định của kiểu dữ liệu
            Console.WriteLine(temp4.GetValueOrDefault());//Giá trị mặc định  = 0

            //Toán tử ?? thực hiện gán Nullable Type cho Non-Nullable type
            int? temp7 = null;
            int temp8 = temp7 ?? 0;//Temp8 = Temp7 nếu Temp7 khác null, temp8 = 0 nếu temp7 = null

            #endregion
        }
    }
}
