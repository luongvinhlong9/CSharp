using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array35= new int[10];
            Console.WriteLine("Nhap 10 phan tu cua day: ");
            for(int i35=0; i35 < 10; i35++)
            {
                array35[i35] = int.Parse(Console.ReadLine());
            }
            Library lib35 = new Library();
            Console.WriteLine("Gia tri lon nhat la: {0}", lib35.findMax(array35));
            Console.WriteLine("Gia tri be nhat la: {0}", lib35.findMax(array35));
        }
    }
}
