using System;

namespace ImcUsandoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
             IMC obj = new IMC();

            
            obj.Kg = double.Parse(Console.ReadLine());
            obj.Alt = double.Parse(Console.ReadLine());

            obj.mensagem();
        }
    }
}
