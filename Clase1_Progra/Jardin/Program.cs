using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardin
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alu = new Alumno("facu","falcone",2502);
            JardinInfantes.AgregarAlumnos(alu);
            Console.WriteLine(alu);
            Console.ReadKey();
        }
    }
}
