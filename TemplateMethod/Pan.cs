using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    //Clase abstracta que contiene el método de la plantilla(Template Method).

    abstract class Pan
    {

        public abstract void MezclarIngredientes();      //Método Mezclar Ingredientes
        public abstract void Hornear();                  //Método Hornear Pan


        public virtual void Rebanada()                   //Método virtual(probable que no cambie) cortar el pan sobrante
        {
            Console.WriteLine("¡Cortando el pan " + GetType().Name + "!");      //GetType().Name -> Muestra el pan actualmente seleccionado
        }



        // Método de la plantilla

        public void Hacer()                              //Método de instrucciones generales a realizar por tipo de pan seleccionado
        {
            MezclarIngredientes();
            Hornear();
            Rebanada();
        }
    }
}
