using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t- - - - - - - - - - - - - - - - - - - -" +
                            "\n\t|    PANADERIA 'EL RICO PAN DE CASA'   |\n" +
                              "\t- - - - - - - - - - - - - - - - - - - -\n");


            DoceGranos doceGranos = new DoceGranos();                       // Instancia de la clase Doce Granos
            doceGranos.MezclarIngredientes();
            doceGranos.Hornear();
            Console.WriteLine();

            MasaFermentada masaFermentada = new MasaFermentada();           // Instancia de la clase Masa Fermentada
            masaFermentada.Hornear();
            masaFermentada.Rebanada();
            Console.WriteLine();

            Integral integral = new Integral();                             // Instancia de la clase Integral
            integral.Hacer();

            Console.ReadKey();
        }
    }
}
