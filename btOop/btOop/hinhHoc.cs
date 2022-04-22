using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btOop
{
    class hinhHoc
    {
        public virtual void thuocTinh()
        {            
        }
        public virtual void tinhTien() { }
    }
    class chuNhat : hinhHoc
    {
        private double a { get; set; }
        private double b { get; set; }

        public chuNhat(double a1,double b1)
        {
            a = a1;
            b = b1;            
        }

        public override void thuocTinh()
        {            
            Console.WriteLine("So canh chu nhat la: 4");
            Console.WriteLine("So goc vuong chu nhat la: 4");
            Console.WriteLine("Tong 4 goc tam giac la: 360");            
            double S =a,b;
            Console.WriteLine("Dien tich chu nhat la: ",S);
        }
        public override void tinhTien()
        {
            
        }
    }
    
}
