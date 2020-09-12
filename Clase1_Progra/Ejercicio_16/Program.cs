using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Maiin
    {
        static void Main(string[] args)
        {
            Alumno[] estudiantes = new Alumno[2];

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Alumno alu = new Alumno("facu","falcone",123);
                //estudiantes[i] = new Alumno();// implicito
                estudiantes[i] = alu;

            }
            
            
            
            
            
            Alumno alu1 = new Alumno();
            alu1.SetNombre("Facu");
            alu1.SetLegajo(2502);
            alu1.SetNota1(9);
            alu1.SetNota2(9);

           alu1.CalcularFinal();
            Console.ReadKey();
        }


    }

}
