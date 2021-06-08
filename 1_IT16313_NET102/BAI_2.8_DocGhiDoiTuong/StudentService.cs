using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._8_DocGhiDoiTuong
{
    class StudentService
    {
        private List<Student> _lstStudents;
        private FileStream _fs;
        private BinaryFormatter _bf;

        public StudentService()
        {
            _lstStudents = new List<Student>
            {
                new Student(1,"PH1","A"),
                new Student(2,"PH2","B"),
                new Student(3,"PH3","C"),
                new Student(4,"PH4","D")
            };
        }

        public void GhiFile(List<Student> lsStudents,string path)
        {
            _fs = new FileStream(path, FileMode.Create);
            _bf = new BinaryFormatter();
            _bf.Serialize(_fs, lsStudents);//Serialize Tuần tự hóa hoặc tuần tự hóa là quá trình dịch cấu trúc dữ liệu hoặc trạng thái đối tượng sang định dạng có thể được lưu trữ hoặc truyền và tái tạo lại sau này.
            _fs.Close();
            Console.WriteLine("Ghi file thành công");
        }

        public void DocFile(string path)
        {
            _lstStudents = new List<Student>();
            _fs = new FileStream(path, FileMode.Open);
            _bf = new BinaryFormatter();
            var data = _bf.Deserialize(_fs);//Đọc đối tượng lên
            _lstStudents = (List<Student>) data;//Gán lại List object cho List Student
            _fs.Close();
        }

        public List<Student> GetListStudents()
        {
            return _lstStudents;
        }
    }
}
