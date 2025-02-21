using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TorresDeHanoi
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Ingresa el número de discos: ");
                int n = int.Parse(Console.ReadLine());

                Pile torreA = new Pile();
                Pile torreB = new Pile();
                Pile torreC = new Pile();

                for (int i = n; i >= 1; i--) //Inicializa la torre de origen con el valor más bajo hasta el fondo
                {
                    torreA.Push(i);
                }

                Console.WriteLine("\n--- Movimientos de las Torres de Hanoi ---");
                TorresDeHanoi(n, torreA, torreC, torreB, 'A', 'C', 'B');
            }


        static void MoverDisco(Pile Origen, Pile Destino, Pile Auxiliar, char NombreOrig, char NombreDest, char NombreAux)
        {
            Console.Clear();
            int disco = Origen.Pop();//Almacena el disco de la torre seleccionada en la variable
            Destino.Push(disco); //Se almacena la variable del disco en la torre destinada
            Console.WriteLine($"Mover disco {disco} de {NombreOrig} a {NombreDest}"); //Se imprime el movimiento
            Console.WriteLine($"\n======Torre {NombreOrig}=========\n");
            Origen.Print();
            Console.WriteLine($"\n======Torre {NombreDest}=========\n");
            Destino.Print();
            Console.WriteLine($"\n======Torre {NombreAux}=========\n");
            Auxiliar.Print();
            Console.WriteLine("\n=====================\n");
            Thread.Sleep(1000);
        }

        static void TorresDeHanoi(int n, Pile origen, Pile destino, Pile auxiliar, char NombreOrig, char NombreDest, char NombreAux)
            {
                if (n == 1)
                {
                    MoverDisco(origen, destino, auxiliar, NombreOrig, NombreDest, NombreAux);
                    return;
                }

            TorresDeHanoi(n - 1, origen, auxiliar, destino, NombreOrig, NombreAux, NombreDest);// Mover n-1 discos al auxiliar
            MoverDisco(origen, destino, auxiliar, NombreOrig, NombreDest,NombreAux); // Se mueve el disco restante al destino
            TorresDeHanoi(n - 1, auxiliar, destino, origen, NombreAux, NombreDest, NombreOrig); //La inversa del paso 1 jaja
            }





    }
    }
