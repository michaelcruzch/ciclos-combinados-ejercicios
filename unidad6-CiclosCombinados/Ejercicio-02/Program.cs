using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una compañía de electricidad necesita calcular anualmente el consumo que ha
            //registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos.
            //Para ello tiene un lote de registros por cada uno de los usuarios con los
            //siguientes datos:

            //-Zona (numérico entero).
            //-Número de cliente (número de cuatro dígitos no correlativos).
            //-Cantidad de kilovatios consumidos en el periodo.

            //El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro
            //con zona igual a cero.
            //Se pide generar un listado con el siguiente formato:

            //Zona: XX
            //Cantidad de usuarios de la zona: XX
            //Total facturado en la zona: XX
           // Zona: XX
            //Cantidad de usuarios de la zona: XX
            //Total facturado en la zona: XX

            //El precio es escalonado según la siguiente escala:
            //$ 0.10 por kv por los primeros 100 kv de consumo.
            //$ 0.12 por kv por el consumo de 101 a 200 kvs.
            //$ 0.15 por kv por el consumo de 201 kvs en adelante.

            int zona, numeroCliente, zonaActual, conUsuarios = 0;
            float cantidadKilovatios, montoTotal= 0, monto;

            Console.WriteLine("ingrese la zona:");
            zona = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de cliente:");
            numeroCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de kilovatios");
            cantidadKilovatios = float.Parse(Console.ReadLine());


            while (zona != 0)
            {
                zonaActual = zona;
            

                conUsuarios = 0;
                montoTotal = 0;

                while (zona == zonaActual)
                {
                    conUsuarios++;

                    if(cantidadKilovatios > 200)
                        monto = 0.15F *cantidadKilovatios;
                    else if(cantidadKilovatios > 100)
                        monto = 0.12F * cantidadKilovatios;
                    else    
                        monto = 0.10F * cantidadKilovatios;

                    montoTotal+=monto;

                    Console.WriteLine("ingrese la zona:");
                    zona = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el numero de cliente:");
                    numeroCliente = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la cantidad de kilovatios");
                    cantidadKilovatios = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("zona: " + zonaActual);
                Console.WriteLine("Cantidad de usuarios de la zona: " + conUsuarios);
                Console.WriteLine("Total facturado de la zona: " + montoTotal);



                
            }
            


        }
    }
}
