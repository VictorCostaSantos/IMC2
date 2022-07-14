using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com sua idade");
            string idade = Console.ReadLine();
            

            Console.WriteLine("Entre com peso");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com altura");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            float result = peso / (altura * altura);
            Console.WriteLine(result);


            if (result <= 18.5)
            {
                Console.WriteLine("STATUS sobre vc:");
                Console.WriteLine("Seu nome: " + nome);
                Console.WriteLine("Sua idade : " + idade);

                Console.WriteLine("Seu IMC:" + "Magreza");
            }

            if (result > 18.5 && result <= 24.9) 
                {
                Console.WriteLine("STATUS sobre vc:");
                Console.WriteLine("Seu nome: " + nome);
                Console.WriteLine("Sua idade : " + idade);

                Console.WriteLine("Seu IMC: " + "Normal");
                }

            if (result >= 25.0 && result <= 29.9)
            {
                Console.WriteLine("STATUS sobre vc:");
                Console.WriteLine("Seu nome: " + nome);
                Console.WriteLine("Sua idade : " + idade);

                Console.WriteLine("Seu IMC: " + "Sobrepeso");
            }
             if (result >= 30.0 && result <= 39.9) 
            {
                Console.WriteLine("STATUS sobre vc:");
                Console.WriteLine("Seu nome: " + nome);
                Console.WriteLine("Sua idade : " + idade);

                Console.WriteLine("Seu IMC: " + "Obesidade");
            }
            if (result >= 40.0)
            {
                Console.WriteLine("STATUS sobre vc:");
                Console.WriteLine("Seu nome: " + nome);
                Console.WriteLine("Sua idade : " + idade);

                Console.WriteLine("Seu IMC: "+"Obesidade grave");    
            }

           
            


         }

        
    }
}
