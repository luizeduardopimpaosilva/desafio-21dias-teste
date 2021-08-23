using System;

namespace desafio_21dias_c
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(" Informe a: ");

            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Informe b: ");
            var b = Convert.ToInt32(Console.ReadLine());

            var soma = a + b;
            Console.WriteLine($" Soma das variáveis é: {soma}");
            Console.WriteLine(" Soma das variáveis é: "+soma);
            Console.WriteLine(" Soma das variáveis é: {0}",soma);
            switch (soma)
            {   
                case < 1:
                    Console.WriteLine($"Measured value is {soma}; too low.");
                    break;

                case > 10:
                    Console.WriteLine($"Measured value is {soma}; too high.");
                    break;

                default:
                    Console.WriteLine($"Measured value is {soma}.");
                    break;
            }
            // loop infinito
            

            while (true)  
            {
                Console.WriteLine("Digite 1 para sair");
                Console.WriteLine("Digite 2 para saltar");
                Console.WriteLine("Digite outros valores imprime");
                var i1 = Convert.ToInt32(Console.ReadLine());

                if (i1==1) break;
                else if (i1==2) continue;
                Console.WriteLine("Passou por aqui");
            }
            
        }
    }
}
