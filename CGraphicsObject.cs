using System;
namespace ООП3
{
    public abstract class CGraphicsObject
    {
        public abstract string Lenght();
        public void Info()
        {
            Console.WriteLine($"Длина: {Lenght()}\n");
        }
    }
}