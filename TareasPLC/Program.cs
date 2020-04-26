using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasPLC
{
    class Program
    {

        
        public static void Main(string[] args)
        {
            Console.WriteLine("Punto 1 - archivo 2");
            int[,] archivo2 = Tarea.obtenerArchivo2();

            Console.WriteLine("Punto 2 ");
            Dictionary<int, int> lista = Tarea.obtenerListaConcatenada(); ;

            Console.WriteLine("Punto 3 ");
            foreach (KeyValuePair<int, int> par in lista)
            {
                int cociente = Tarea.obtenerCociente(par.Value);
                Console.WriteLine("{0}  :  {1}  :  {2}", par.Key, par.Value,cociente);
            }

           
            


            Console.ReadKey();
        }
    }
}
