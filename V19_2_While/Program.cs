using System;

namespace V19_2_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Numero = new Random();

            int NumeroRandom = Numero.Next(0, 100);

            int Intentos = 0;

            Console.WriteLine("¡Intente adivinar el número entre 0 y 100!");

            int Intento = Int32.Parse(Console.ReadLine());

            while(Intento != NumeroRandom)
            {
                Intentos++;
                if(Intento > NumeroRandom)
                {
                    Console.WriteLine("El número ingresado es mayor.");
                }
                if(Intento < NumeroRandom)
                {
                    Console.WriteLine("El número ingresado es menor.");
                }
                Console.WriteLine("¡Intente nuevamente adivinar el número entre 0 y 100!");

                Intento = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine($"¡Felicitaciones! El número era {NumeroRandom}. Usted tuvo {Intentos} intentos fallidos.");
        }
    }
}
