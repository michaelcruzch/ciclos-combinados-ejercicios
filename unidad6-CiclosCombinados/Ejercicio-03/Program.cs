﻿using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar los valores de los pesos de distintas
            //encomiendas que se deben enviar a distintos clientes y que finaliza cuando se
            //ingresa un peso negativo. Se deben agrupar las encomiendas en camiones que
            //pueden transportar hasta 200 kilos en total.

            //10, 20, 140,   70, 100,   40, 10, 50, 80,    90, 30, 40,      50,        -10.
            //Camión 1.      Camión 2     Camión 3           Camión 4      Camión 5

            //Se pide determinar e informar:
            //a. El número de camión y peso total de encomiendas (Camión 1: 170kg, Camión 2: 170kg, etc.).
            //b. El número de camión que transporta mayor cantidad de encomiendas
            //(en el ejemplo anterior sería el camión 3 con 4 encomiendas).
            //c. La cantidad de camiones que se terminaron cargando.


            int peso, encomienda, maxEncocomienda = 0, pesoCamion, camion = 0, camionMaximo = 0;

            Console.WriteLine("Ingrese el peso: ");
            peso = int.Parse(Console.ReadLine());

            while (peso > 0)
            {
                encomienda = 0;
                pesoCamion = 0;
                camion++;

                while (peso + pesoCamion <= 200)
                {
                    pesoCamion+=peso;
                    encomienda++;

                    Console.WriteLine("Ingrese el peso: ");
                    peso = int.Parse(Console.ReadLine());

                }

                Console.WriteLine("el camion numero: " + camion + "Tiene un peso de: " + pesoCamion);

                if(encomienda > maxEncocomienda){
                    maxEncocomienda = encomienda;
                    camionMaximo = camion;
                    
                }
                


            }
            Console.WriteLine("El camion que transpote mayor cantidad de encomienda es: " + camionMaximo + "con peso de: " + maxEncocomienda);
            Console.WriteLine("La cantidad de camiones que se cargaron es: " + camion);







        }
    }
}
