using System;

namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            double pago, metros, la, lb,  lc, precio, total;

            Console.WriteLine("digite el lado ancho de la alberca");
            la=double.Parse(Console.ReadLine());

            Console.WriteLine("digite largo de la alberca");
            lb = double.Parse(Console.ReadLine());

            Console.WriteLine("digite la altura de la alberca");
            lc = double.Parse(Console.ReadLine());

            Console.WriteLine("digite el precio del agua para llenar la alberca por metro cubico ");
            precio = double.Parse(Console.ReadLine());

            metros = la * lb * lc;
            total = metros * precio;

            Console.WriteLine($"la cantidad de metros cubicos sera {metros}");
            Console.WriteLine($"el total sera de  {total}");
        }

    }
}
