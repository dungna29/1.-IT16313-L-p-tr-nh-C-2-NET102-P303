using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    interface Interface1
    {
        void method1();
    }

    interface Interface2
    {
        void method2();
    }

    class Service:Interface1,Interface2
    {
        public void method1()
        {
            throw new NotImplementedException();
        }

        public void method2()
        {
            throw new NotImplementedException();
        }
    } 
}
