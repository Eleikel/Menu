using System;

namespace PRACTICA_DE_ALGORITMO
{
    class Program
    {
        static int Captura;
        static int Opcion;


        static void Main(string[] args)
        {

            Menu();

        }

        public static void Menu()

        {
            //int Opcion;

            do
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.WriteLine("|****************************************************************************************|");
                Console.WriteLine("|--------------------------->|  MENU DE SELECCION  |<------------------------------------|");
                Console.WriteLine("|****************************************************************************************|");
                Console.WriteLine("|*                                                                                      *|");
                Console.WriteLine("|*                      1 - Capturar Valor                                              *|");
                Console.WriteLine("|*                      2 - Generar Tabla de Multiplicar                                *|");
                Console.WriteLine("|*                      3 - Determinar Si es Primo o No Primo                           *|");
                Console.WriteLine("|*     4 - Capturar una Matriz 4 x 4 Desplegar la Diagonal Principal y Secundaria       *|");
                Console.WriteLine("|*                      5 - Salir de Programa                                           *|");
                Console.WriteLine("|*                                                                                      *|");
                Console.WriteLine("|****************************************************************************************|");

                Console.WriteLine("Digite su opcion: ");
                Opcion = int.Parse(Console.ReadLine());



                switch (Opcion)
                {

                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Digite su numero a capturar: ");
                        int Capturado = int.Parse(Console.ReadLine());
                        Captura = Capturado;
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para ir al menu principal");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 2:
                        Console.Clear();
                        ProcedimientoTablaMultiplicar(Captura);
                        Console.WriteLine("Presione cualquier tecla para ir al menu principal");
                        Console.ReadKey();

                        break;


                    case 3:
                        Console.Clear();
                        ProcedimientoMostrarEvaluacionPrimo(Captura);
                        Console.WriteLine();
                        Console.WriteLine("Presione cualquier tecla para ir al menu principal");
                        Console.ReadKey();

                        break;


                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        ProcedimientoDiagonalesMatriz();
                        Console.WriteLine();
                        Console.WriteLine("Presione cualquier tecla para ir al menu principal");
                        Console.ReadKey();

                        break;


                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fin del Programa");
                        break;


                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opcion no disponible");
                        Console.WriteLine();
                        Console.WriteLine("Presione cualquier tecla para ir al menu principal");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                }
                // Console.Read();
            } while (Opcion != 5);

        }



        public static void ProcedimientoTablaMultiplicar(int Captura)
        {
            Console.WriteLine("El numero a multiplicar es " + Captura);
            Console.WriteLine();
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(Captura + " X " + i + " = " + (i * Captura) + "\n");
            }
        }

        public static void ProcedimientoMostrarEvaluacionPrimo(int Captura)
        {

            // Creamos un booleano para esPrimo
            bool esPrimo = true;

            //se divide el numero n entre todos los numeros anteriores
            for (int i = 2; i < Captura; i++)
            {
                //si el modulo de la division es 0 entonces el numero no es primo
                //se marca la variable esPrimo como false y se termina el for
                if (Captura % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            // si la variable esPrimo es true entonces es un numero primo
            if (esPrimo)
            {
                Console.WriteLine("El numero " + Captura + " Es primo");

            }
            else
            {
                Console.WriteLine("El numero " + Captura + " No Es primo");
            }

        }


        public static void ProcedimientoDiagonalesMatriz()
        {
            int x, y;

            int[,] matriz = new int[4, 4];
            Console.WriteLine("Ingresa elementos de Matriz:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Diagonal Principal");
            for (int i = 0; i < 4; i++)
            {
                x = i % 4;
                y = x;
                Console.WriteLine(matriz[y, x] + " ");
            }

            Console.WriteLine("Diagonal Secundaria");
            for (int i = 0; i < 4; i++)
            {
                x = i % 4;
                y = 3 - x;
                Console.Write(matriz[y, x] + " ");

            }
        }
    }
}