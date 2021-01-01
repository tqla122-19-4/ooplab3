using System;
namespace ООП3
{
    public class Class1 : CPoint
    {
        public Class1(int SideA1, int SideR1, int SideA3, int SideR3) : base(SideA1, SideR1, SideA3,  SideR3)
        {
            throw new System.NotImplementedException();
        }

        ~Class1()
        {
            throw new System.NotImplementedException();
        }

        public static void funсtion()
        {
            CPoint.Method();
            CGraphicsObject figure = new CPoint(CPoint.a, CPoint.a1, CPoint.b, CPoint.b1);
            figure.Info();
        }
    }
}