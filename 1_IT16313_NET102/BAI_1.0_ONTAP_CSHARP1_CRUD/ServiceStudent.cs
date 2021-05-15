using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    class ServiceStudent
    {
        //Khai báo biến toàn cục ở trên cùng
        private string _input;
        private List<SinhVien> _lstSinhViens;
        private SinhVien _sinhVien;
        public ServiceStudent()
        {
            _lstSinhViens = new List<SinhVien>();
            //Khởi tạo đối tượng ảo và add sẵn vào trong danh sách
            _sinhVien = new SinhVien(0, "Nguyên", "123", 1);
            _lstSinhViens.Add(_sinhVien);
            _sinhVien = new SinhVien(1, "Trang", "123", 0);
            _lstSinhViens.Add(_sinhVien);
            _sinhVien = new SinhVien(2, "Phương", "123", 0);
            _lstSinhViens.Add(_sinhVien);
        }

        public void addSinhVien()
        {
            do
            {
                Console.WriteLine("Mời bạn nhập số lượng muốn thêm: ");
                _input = Console.ReadLine();
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    _sinhVien = new SinhVien();//Phải khởi tạo đối tượng mới dùng được
                    //Lấy id cuối cùng của người trong danh sách trừ 1 và +1 với ID để tạo ra mã tự tăng cho đối tượng mới thêm
                    // _sinhVien.Id = _lstSinhViens[_lstSinhViens.Count-1].Id + 1;
                    _sinhVien.Id = _lstSinhViens.Count;
                    Console.WriteLine("Mời bạn nhập tên: ");
                    _sinhVien.Ten = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập sdt: ");
                    _sinhVien.Sdt = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập giới tính: ");
                    _sinhVien.GioiTinh = Convert.ToInt32(Console.ReadLine());
                    _lstSinhViens.Add(_sinhVien);//Thêm đối tượng vào danh sách
                }
                Console.WriteLine("Bạn có muốn thêm sinh viên nữa hay không? y/n: ");
                _input = Console.ReadLine(); 
            } while (!(_input=="n"));
        }
        public void addSinhVienDungna()
        {
            do
            {
                _input = getInputValue("số lượng muốn thêm: ");
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    _sinhVien = new SinhVien();//Phải khởi tạo đối tượng mới dùng được
                    //Lấy id cuối cùng của người trong danh sách trừ 1 và +1 với ID để tạo ra mã tự tăng cho đối tượng mới thêm
                    // _sinhVien.Id = _lstSinhViens[_lstSinhViens.Count-1].Id + 1;
                    _sinhVien.Id = _lstSinhViens.Count;
                    _sinhVien.Ten = getInputValue("tên: ");
                    _sinhVien.Sdt = getInputValue("sdt: ");
                    _sinhVien.GioiTinh = Convert.ToInt32(getInputValue("giới tính: "));
                    _lstSinhViens.Add(_sinhVien);//Thêm đối tượng vào danh sách
                }
                _input = getInputValue("nhập tiếp hay không? y/n: ");
            } while (!(_input == "n"));
        }

        public void findSinhVien()
        {
            //Cách 1: Thông thường
            // Console.WriteLine("Mời bạn nhập mã sinh viên: ");
            // _input = Console.ReadLine();
            // for (int i = 0; i < _lstSinhViens.Count; i++)
            // {
            //     if (_lstSinhViens[i].Id == Convert.ToInt32(_input))
            //     {
            //         Console.WriteLine("Đã tìm thấy");
            //         _lstSinhViens[i].inRaManHinh();
            //         Console.WriteLine("============");
            //         return;
            //     }
            // }
            // Console.WriteLine("Mã sinh viên bạn tìm không tồn tại");

            //Cách 2: Nâng cao
            // int temp = getIndex(getInputValue("mã sinh viên: "));
            // if (temp == -1) return;
            // _lstSinhViens[temp].inRaManHinh();
            // Console.WriteLine("==============");

            //Cách 3: Dùng linq
            Console.WriteLine("Mời bạn nhập mã sinh viên: ");
            _input = Console.ReadLine();
            _lstSinhViens.Where(c=>c.Id == Convert.ToInt32(_input)).FirstOrDefault().inRaManHinh();
        }
        public void removeSinhVien()
        {
            //Cách 1: Thông thường
            // Console.WriteLine("Mời bạn nhập mã sinh viên: ");
            // _input = Console.ReadLine();
            // for (int i = 0; i < _lstSinhViens.Count; i++)
            // {
            //     if (_lstSinhViens[i].Id == Convert.ToInt32(_input))
            //     {
            //       
            //         _lstSinhViens.RemoveAt(i);
            //         Console.WriteLine("Đã xóa thành công");
            //         Console.WriteLine("============");
            //         return;
            //     }
            // }
            // Console.WriteLine("Mã sinh viên bạn tìm không tồn tại");


            //Cách 2: Nâng cao
            int temp = getIndex(getInputValue("mã sinh viên: "));
            if (temp == -1) return;
            _lstSinhViens.RemoveAt(temp);
            Console.WriteLine("==============");
        }

        public void getlstSv()
        {
            foreach (var x in _lstSinhViens)
            {
                x.inRaManHinh();
            }
        }

        //Viết 1 phương thức lấy gia trị trả về do người dùng nhập vào
        private string getInputValue(string mess)
        {
            Console.WriteLine("Mời bạn nhập " + mess);
            return Console.ReadLine();
        }

        //Phương thức lấy ra vị trí của đối tượng trong danh sách theo id
        private int getIndex(string id)
        {
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Id == Convert.ToInt32(id))
                {
                    return i;//Khi tìm thấy thì trả về vị trí 
                }
            }
            return -1;//Khi không tìm thấy thì trả về -1
        }
    }
}
