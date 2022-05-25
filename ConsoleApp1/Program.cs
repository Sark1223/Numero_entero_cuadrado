using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //variable para que evitar que el programa se cierre sin haber cumplido su funcion.
            bool error = true;

            //titulo y descripcion de programa 
            Console.Title = "Numero al cuadrado con excepciones";
            Console.WriteLine("Programa que eleva un numero entero al cuadrado");

            //ciclo con el que se apoya la variable "error"
            do
            {
                Console.Clear();

                //inicio de validadcion de datos
                try
                {
                    //obtencion de datos
                    Console.Write("Ingrese un numero entero: ");
                    int numero = int.Parse(Console.ReadLine());

                    Console.WriteLine(numero + "^2 = " + (numero * numero));

                    //Si se pasa la validacion indicaremos  nuestra variable que no hay errores
                    error = false;
                }
                //seccion que verifica el error
                catch (FormatException e)
                {
                    //Mensaje de error
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error");
                    Console.ResetColor();
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Presione enter para continuar. . .");
                Console.ReadKey();

            //El ciclo se repetira mientras el error sea verdadero
            } while (error == true);
            
        }
    }
}
