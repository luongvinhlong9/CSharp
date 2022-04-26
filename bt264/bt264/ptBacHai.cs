using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ptBacHai
{
    private int a, b, c;
    public ptBacHai()
    {

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
    }
    public ptBacHai(int a1, int b1, int c1)
    {
        a = a1;
        b = b1;
        c = c1;
    }
    ~ptBacHai() { }
    public int gsa
    {
        get { return this.a; }
        set { this.a = value; }
    }
    public int gsb
    {
        get { return this.b; }
        set { this.b = value; }
    }
    public int gsc
    {
        get { return this.c; }
        set { this.c = value; }
    }
    public double delta() {
        double delt;
        delt = Math.Pow(b, 2) - 4 * a * c;
        return delt;
    }
    public void nghiem()
    {
        
        if (delta() < 0)
        {
            Console.WriteLine("Vo nghiem");
        }
        else if(delta() == 0)
        {
            double x = (-b) / (2 * a);
        }
        else
        {
            double x1= (-b-Math.Sqrt(delta())) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta())) / (2 * a);
        }
    }
    
}
