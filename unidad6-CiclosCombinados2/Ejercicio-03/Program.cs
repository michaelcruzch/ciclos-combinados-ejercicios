using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            int n, con, numeroGrupo = 0;

            Console.WriteLine("ingrese un numero:");
            n = int.Parse(Console.ReadLine());

            while (n >= 0)
            {
                numeroGrupo++;
                con = 0;

                while (n > 0)
                {
                    con++;

                    Console.WriteLine("Ingrese un numero:");
                    n = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("la cantidad de numeros del grupo " + numeroGrupo + "es :" + con);


                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());

            }

            


        }
    }
}
