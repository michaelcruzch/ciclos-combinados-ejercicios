using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una compañía de turismo aventura registró los paquetes vendidos durante la
            //última temporada vacacional. Para cada venta se ingresó:

            //Número de paquete (4 dígitos no correlativos).
            //Cantidad de personas incluidas.
            //Precio por persona.
            //Horas totales de actividades.
            //Tipo de aventura (“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta.
            //“C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”,Parapente).

            //El lote se encuentra no ordenado y agrupado por tipo de aventura y corta con
            //número de paquete cero. En el lote no se ingresan registros cuyo tipo de aventura no se haya vendido.
            //A partir de dichos datos, se solicita informar:

            //a. La cantidad de paquetes vendidos de cada tipo de aventura..
            //b. La cantidad total de personas que disfrutaron de las aventuras durante la temporada.
            //c. El total recaudado por cada venta.
            //d. La venta con mayor importe de cada tipo de aventura.
            //e. El paquete con menos horas incurridlas y en qué tipo de actividad fue.


            int numeroPaquete, cantidadPersonas, precioPersona, horas = 0, tipoAventura = 0, acuPersonas = 0, min = horas, tipoAventuraMin = tipoAventura, tipoAventuraActual, contadorPaqueteVendido, max, precioVenta;

            Console.WriteLine("ingrese numero de paquete - 4 digitos: ");
            numeroPaquete = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese cantidad de personas incluidas: ");
            cantidadPersonas = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el precio por persona:");
            precioPersona = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese horas totales de actividad:");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tipo de aventura: ");
            tipoAventura = int.Parse(Console.ReadLine());

            while (numeroPaquete != 0)
            {
                tipoAventuraActual = tipoAventura;

                contadorPaqueteVendido = 0;
                max = 0;

                while (tipoAventura == tipoAventuraActual)
                {
                    contadorPaqueteVendido++;
                    acuPersonas+=cantidadPersonas;

                    precioVenta = cantidadPersonas * precioPersona;

                    Console.WriteLine("El totoal recaudado por cada venta es: " + precioVenta);

                    if(precioVenta > max)
                        max = precioVenta;
                    if(horas < min){
                        min = horas;
                        tipoAventuraMin = tipoAventura;
                    }


                    Console.WriteLine("ingrese numero de paquete - 4 digitos: ");
                    numeroPaquete = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese cantidad de personas incluidas: ");
                    cantidadPersonas = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el precio por persona:");
                    precioPersona = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese horas totales de actividad:");
                    horas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese tipo de aventura: ");
                    tipoAventura = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Los paquetes vendidos fueron :" +  contadorPaqueteVendido);
                Console.WriteLine("La venta con mayor importe es: " +  max);

                
            }

            Console.WriteLine("La cantidad de personas que disfrutaron de todas las actividades es: " + acuPersonas);
            Console.WriteLine("El paquete con menos horas fue: " + tipoAventuraMin + " con la cantidad de horas de : " + min);

            





        }
    }
}
