using System;
namespace ООП3
{
    public class CPoint : CGraphicsObject
    {
        public static int a,a1,b,b1;
        public CPoint(int SideA1, int SideR1, int SideA3, int SideR3)
        {
            SideA = SideA1;
            SideR = SideR1;
            SideA2 = SideA3;
            SideR2 = SideR3;
        }
        public int SideA
        {
            get { return a; }
            set { a = value < 0 ? -value : value; }
        }

        public int SideR
        {
            get { return a1; }
            set { a1 = value < 0 ? -value : value; }
        }
        public int SideA2
        {
            get { return b; }
            set { b = value < 0 ? -value : value; }
        }

        public int SideR2
        {
            get { return b1; }
            set { b1 = value < 0 ? -value : value; }
        }
        public override string Lenght()
        {
            return (a + a1 + b +b1).ToString();
        }

        public static void Method()
        {
            Console.WriteLine("Введите длину отрезков: ");
            a = int.Parse( Console.ReadLine());
            a1 = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            b1 = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}