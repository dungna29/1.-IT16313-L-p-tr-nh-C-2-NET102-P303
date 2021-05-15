using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    class SinhVien
    {
        //Phần 1: Liệt kê tất cả các thuộc tính mà đối tượng phải có
        private int id;
        private string ten;
        private string sdt;
        private int gioiTinh;

        //Phần 2: Khởi tạo contructor không tham số gõ: ctor + tab
        public SinhVien()
        {
            //Console.WriteLine("Đây là text in ra từ contructor không tham số");
        }
        
        /*
         Nếu bạn nào dùng resharper ctorf + tab
         Đối với các bạn không cài resharper muốn gọi contructor có tham số:
            1. Chuột phải vào Class đối tượng chọn Quick Actions....
            2. Generate Contructor
         */
        public SinhVien(int id1, string ten, string sdt, int gioiTinh)
        {
            id = id1;
            this.ten = ten;
            this.sdt = sdt;
            this.gioiTinh = gioiTinh;
        }

        //Phần 3: Triển khai property của thuộc tính
        /*
         * Bôi đen vào các thuộc tính đang có hiện tại của lớp sau đó chuột phải --> Quick Actions....
         * Chọn Encapsulate fields
         *
         */
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public int GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        //Phần 4: Triển khai cá phương thức của đối tượng
        public void inRaManHinh()
        {
            Console.WriteLine("Id: {0} | Tên: {1} | Sdt: {2} | Giới  Tính: {3}",id,Ten,sdt,gioiTinh == 1?"Nam":"Nữ");
        }
    }
}
