using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_estructura_de_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var datosA = Arreglo1();
            var datosB = Arreglo2();
            var combinacion = Arreglo3(datosA, datosB);
            Array.Sort(combinacion);

            Console.WriteLine("COMBINACION DE ARREGLOS");
            for(int i = 0; i<combinacion.Length; i++)
            {
                Console.Write(combinacion[i] + " ");


            }
            Array.Reverse(combinacion);
            Console.ReadLine();

            
            



        }// cierre de main

        static int[] Arreglo1() {

            int[] primerArreglo = new int[5];
            for (int i = 0; i < primerArreglo.Length; i++)
            {

                Console.Write("Ingrese un numero del primer arreglo: ");
                primerArreglo[i] = int.Parse(Console.ReadLine());
               
            }// cierre de for

          

            return primerArreglo;

        }//cierre de MetodoArreglo1

        static int[] Arreglo2()  {

            int[] SegundoArreglo = new int[5];
            for (int i = 0; i < SegundoArreglo.Length; i++)
            {


                Console.Write("Ingrese un numero del segundo arreglo ");
                SegundoArreglo[i] = int.Parse(Console.ReadLine());

            }// cierre de for

            
            return SegundoArreglo;

        }//cierre de MetodoArreglo2

        static int[] Arreglo3(int[] primerArreglo, int[] SegundoArreglo)
        {
            int[] TercerArreglo = new int[10];
            int indice = 0; 
             for(int i = 0; i<5; i++)
            {
                TercerArreglo[indice] = primerArreglo[i];
                indice++;
                TercerArreglo[indice] = SegundoArreglo[i];
                indice++;
                
            }
            return TercerArreglo;


        }//cierre de metodoArreglo3


    }// Cierre de clase
}//Cierre de namespace
