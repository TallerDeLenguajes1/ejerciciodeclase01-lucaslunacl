using System;

namespace EjercicioDeClase01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random rand = new Random();
            int numeroRandom = rand.Next(0, 100);
            int numeroUsu = 0;
            string dato = "";

            
            Console.WriteLine("\n");
            do
            {
                Console.WriteLine("Escribe un número");
                dato = Console.ReadLine();
                numeroUsu = Convert.ToInt32(dato);
                if (numeroUsu > 100) {
                    Console.WriteLine("ERROR, no puede poner ese número");
                }
                if (numeroUsu > numeroRandom)
                {
                    Console.WriteLine($"El numero {numeroUsu} es mayor al numero aleatorio");
                }
                else if (numeroUsu < numeroRandom)
                {
                    Console.WriteLine($"El numero {numeroUsu} es menor al numero aleatorio");
                }

            } while (numeroUsu != numeroRandom);

            Console.WriteLine($"El numero {numeroUsu} es igual  al numero aleatorio ({numeroRandom})");


        }
    }
}
