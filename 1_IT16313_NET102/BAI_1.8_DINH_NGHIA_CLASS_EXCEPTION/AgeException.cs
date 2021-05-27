using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._8_DINH_NGHIA_CLASS_EXCEPTION
{
    class AgeException:Exception
    {
        public int tuoi { get; set; }

        public AgeException(string? message, int tuoi) : base(message)
        {
            this.tuoi = tuoi;
        }

        public void MessByAgeException()
        {
            Console.WriteLine("Tuôi của của bạn chưa đủ tuổi vào club Csharp nhé");
        }
    }
}
