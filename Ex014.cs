using System;

//연산자 오버로드 (185p ~ 188p)
namespace Ex014
{
    class Program
    {
        static void Main(string[] args)
        {
            //186p
            int n1 = 5;
            int n2 = 10;
            int sum = n1 + n2;

            string txt1 = "123";
            string txt2 = "456";
            Console.WriteLine(txt1 + txt2);

            //187p
            Kilogram kg1 = new Kilogram(5);
            Kilogram kg2 = new Kilogram(10);

            Kilogram kg3 = kg1 + kg2;
            Console.WriteLine(kg3);
        }
    }

    public class Kilogram
    {
        double mass;

        public Kilogram(double value)
        {
            this.mass = value;
        }

        public Kilogram Add(Kilogram target)
        {
            return new Kilogram(this.mass + target.mass);
        }

        public override string ToString()
        {
            return mass + "kg";
        }

        public static Kilogram operator +(Kilogram op1, Kilogram op2)
        {
            return new Kilogram(op1.mass + op2.mass);
        }
    }
}
