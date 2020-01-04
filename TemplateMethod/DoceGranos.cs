using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    //Clase hija heredando métodos de la clase padre(PAN)

    class DoceGranos : Pan
    {

        public override void MezclarIngredientes()
        {
            Console.WriteLine("Recolección de ingredientes para pan de Doce Granos");
        }

        public override void Hornear()
        {
            Console.WriteLine("Hornear el pan de 12 granos. (25 minutos)");
        }
        
    }
}
