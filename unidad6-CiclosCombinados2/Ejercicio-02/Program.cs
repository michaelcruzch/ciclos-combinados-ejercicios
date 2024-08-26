using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int n, conOrdenados = 0, grupoImparesMaximo = 0, conNumeros, conImapares, min;
            double porcentajeImpares, porcentajeMaximo;
            bool banderaOrdenados;

            Console.WriteLine("ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            porcentajeMaximo = -1;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());

                conNumeros = 0;
                conImapares = 0;
                min = n;
                banderaOrdenados = true;

                while (n != 0)
                {
                    conNumeros++;

                    if(n % 2 != 0)
                        conImapares++;
                    
                    if(n <= min)
                        min = n;
                    else    
                        banderaOrdenados = false;

                    Console.WriteLine("Ingrese un numero:");
                    n = int.Parse(Console.ReadLine());

                }

                porcentajeImpares = (conImapares * 100) / conNumeros;

                if(porcentajeImpares > porcentajeMaximo){
                    porcentajeMaximo = porcentajeImpares;
                    grupoImparesMaximo = x + 1;
                }

                if(banderaOrdenados == true)
                    conOrdenados++;



            }
            Console.WriteLine("El grupo con mayor numero de impares es: " + grupoImparesMaximo);
            Console.WriteLine("El numero de grupos ordenados es: " + conOrdenados);



            
        }
    }
}
