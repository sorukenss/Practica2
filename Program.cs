using System;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el numero del mes");
            int numeroDeMes = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(NombreDeMes(numeroDeMes));
            }
            catch (Exception e)
            {
                Console.WriteLine("Mensaje de la exception es :" + e.Message);
            }
            Console.WriteLine("Aqui Continua la ejecucion del programa");
        }

        public static String NombreDeMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                     throw new ArgumentOutOfRangeException();
            }
        }

    }
}

