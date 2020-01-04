using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    //Clase hija heredando métodos de la clase padre(PAN)

    class MasaFermentada : Pan
    {

        public override void MezclarIngredientes()
        {
            Console.WriteLine("Recolección de ingredientes para pan de Masa Fermentada");
        }

        public override void Hornear()
        {
            Console.WriteLine("Hornear el pan de Masa Fermentada. (20 minutos)");
        }

    }
}
