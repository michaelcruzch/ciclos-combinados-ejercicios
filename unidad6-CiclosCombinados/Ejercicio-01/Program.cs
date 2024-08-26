using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dispone de una lista de 3 grupos de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            //a. El número de grupo con mayor porcentaje de números impares positivos respecto al total de números que forman el grupo.
            //b. Para cada grupo, el último número primo y en qué orden apareció en ese grupo. Si en un grupo no hubiera números primos, 
            //informarlo con un cartel aclaratorio.
            //c. Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int n;

            // LETRA A
            int maxPorcentaje = 0;
            int conNumeros, conImparesPositivos,porcentajeImparesPositivos, max, grupoMaximo = 0;
            //LETRA B
            int conPrimos, primo = 0, posicionPrimo = 0, orden;
            //LETRA C
            int ban, mayor, conOrdenados = 0;

           

            
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine("ingrese un numero:");
                n = int.Parse(Console.ReadLine());

                //Letra a
                conNumeros = 0;
                conImparesPositivos = 0;

                //letra b
                orden = 0;

                //letra c
                mayor = n;
                ban = 0;
                


                while (n != 0)
                {
                    //letra a
                    conNumeros++;
                    //letra b
                    conPrimos = 0;
                    primo = 0;
                    orden++;
                    
                 

                    if(n % 2 != 0 && n > 0)
                    conImparesPositivos++;

                    //letra b
                    for (int y = 1; y <= n; y++)
                    {
                        if(n % y == 0)
                            conPrimos++;
                    }
                    if(conPrimos == 2){
                        primo = n;
                        posicionPrimo = orden;
                    }
                    //letra c
                    if(n < mayor)
                        mayor = n;
                    else    
                        ban = 1;



                    Console.WriteLine("Ingrese un numero:");
                    n = int.Parse(Console.ReadLine());
                }
                //letra a
                porcentajeImparesPositivos = (conImparesPositivos * 100) / conNumeros;

                if(porcentajeImparesPositivos > maxPorcentaje){
                    max = porcentajeImparesPositivos;
                    grupoMaximo = x +1;
                }
                //letra b
                if(primo != 0)
                    Console.WriteLine("el ultimo numero primo que aparecio es: " + primo + "en la posicicion: " + posicionPrimo);
                else    
                    Console.WriteLine("No hay numero primos en este grupo");

                //letra c
                if(ban == 0)
                    conOrdenados++;
                    
                    
                
            }
            //letra a
            Console.WriteLine("El grupo con mas numeros impares positivos es: " + grupoMaximo);
            //letra c
            Console.WriteLine("La cantidad de grupos ordenados de de mayor a menor es: " + conOrdenados);



            
            








        
            
        }
    }
}
 