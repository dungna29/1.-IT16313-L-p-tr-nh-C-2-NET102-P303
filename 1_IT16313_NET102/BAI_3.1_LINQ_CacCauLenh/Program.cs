using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace BAI_3._1_LINQ_CacCauLenh
{
    class Program
    {
        private static ServiceAll sa = new ServiceAll();
        private static List<NhanVien> _lstNhanViens;
        private static List<SanPham> _lstSanPhams;
        private static List<TheLoai> _lsttTheLoais;
        public Program()
        {
            _lstNhanViens = sa.GetListNhanViens();
            _lstSanPhams = sa.GetListSanPhams();
            _lsttTheLoais = sa.GetListTheLoais();
        }
        static void Main(string[] args)
        {
            //Gọi các ví dụ về lý thuyết lên để chạy
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Program program = new Program();
            ViduOfType();
        }

        #region 1. Toán tử Where để lọc theo điều kiện trả về 1 danh sách hoặc 1 giá trị sau khi thỏa mãn điều kiện

        public static void ViDuWhere()
        {
            //Lọc ra 1 danh sách nhân viên số tại HN và quê cũng HN
            var lst =
                from a in _lstNhanViens
                where a.ThanhPho == "HN" && a.QueQuan == "HN"
                select a;
            var lst2 = _lstNhanViens.Where(a => a.ThanhPho == "HN" && a.QueQuan == "HN").Select(c => c);
            foreach (var x in lst)
            {
                x.InRaManHinh();
            }
        }
        #endregion

        #region 2. Toán tử OfType để lọc theo điều kiện lọc một phần tử trong tập hợp thành một kiểu được chỉ định

        public static void ViduOfType()
        {
            ArrayList arr = new ArrayList();
            arr.Add(3);
            arr.Add("Ba");
            arr.Add("Bốn");
            arr.Add(4);

            var lst1 = 
                from a in arr.OfType<int>()
                       select a;
            var lst2 =
                from a in arr.OfType<string>()
                select a;

            Console.WriteLine("arr.OfType<int>()");
            foreach (var x in lst1)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
            Console.WriteLine("arr.OfType<string>()");
            foreach (var x in lst2)
            {
                Console.Write(x + " ");
            }
        }


        #endregion
    }
}
