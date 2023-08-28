using System;


namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Obteniendo datos desde la terminal
            Console.WriteLine("\n------INICIAMOS CON EL PROGRAMA------\n");
            Console.WriteLine("Ingresa un numero para mostrar el mes:\n");
            int numero_Mes = Convert.ToInt32(Console.ReadLine());

            //Creando la estructura selectiva SWITCH.
            switch (numero_Mes)
            {
                case 1:
                    Console.WriteLine("\nEl numero ingresado " + numero_Mes + " corresponde a el mes de Enero");
                    Console.WriteLine("\n------Terminacion del programa------\n");
                    break;
                case 2:
                    Console.WriteLine("\nEl numero ingresado " + numero_Mes + " corresponde a el mes de Febrero");
                    Console.WriteLine("\n------Terminacion del programa------\n");
                    break;
                case 3:
                    Console.WriteLine("\nEl numero ingresado " + numero_Mes + " corresponde a el mes de Marzo");
                    Console.WriteLine("\n------Terminacion del programa------\n");
                    break;
                case 4:
                    Console.WriteLine("\nEl numero ingresado " + numero_Mes + " corresponde a el mes de Abril");
                    Console.WriteLine("\n------Terminacion del programa------\n");
                    break;
                case 5:
                    Console.WriteLine("\nEl numero ingresado " + numero_Mes + " corresponde a el mes de Mayo");
                    Console.WriteLine("\n------Terminacion del programa------\n");
                    break;
                case 6:
                    Console.WriteLine("\nEl numero ingresado " + numero_Mes + " corresponde a el mes de Junio");
                    Console.WriteLine("\n------Terminacion del programa------\n");
                    break;
                default:
                    Console.WriteLine("\nEl número ingresado no corresponde a un mes del primer semestre.");
                    Console.WriteLine("\n------Terminacion del programa------\n");
                    break;
            }
            Console.ReadLine(); 
            

        }
    }
}