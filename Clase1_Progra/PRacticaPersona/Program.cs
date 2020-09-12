using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRacticaPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar la clase
            //Persona p = new Persona();
            //Galletita galle = new Galletita();
            //Galletita galle2; //reservo espacio en la memoria
            //galle2 = new Galletita(); // creo la instanciacion

            //galle.sabor = "Vainilla";
            //galle.bajasCalorias = true;

            //string saborcito = galle.sabor; // es como un get, asigno el valor
            //galle.SetSabor("Chocolate");
            //Console.WriteLine(galle.GetSabor());
            //Console.ReadKey();
            Personaje[] personajes = new Personaje[3];

            personajes[0] = new Personaje();
            personajes[1] = new Personaje();
            personajes[2] = new Personaje();

            personajes[0].SetNombre("Facu");
            personajes[1].SetNombre("Cata");
            personajes[2].SetNombre("Denu");

            foreach (Personaje pj in personajes)
            {
                Console.WriteLine(Personaje.MostrarMensaje(pj));
            }
            Console.ReadKey();
        }
    }
}
