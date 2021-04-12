using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Instances

            Competencia granTurismo = new Competencia(5, 20, Competencia.TipoCompetencia.F1);
            Competencia motoDakar = new Competencia(8, 10, Competencia.TipoCompetencia.MotoCross);

            AutoF1 f1 = new AutoF1(1, "Ferrari");
            AutoF1 f2 = new AutoF1(1, "Ferrari");
            AutoF1 f3 = new AutoF1(7, "McLaren");

            MotoCross m1 = new MotoCross(1, "Honda");
            MotoCross m2 = new MotoCross(1, "Honda");
            MotoCross m3 = new MotoCross(69, "Yamaha");

            string status;

            #endregion

            #region CompareCars

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Car in F1 Competence -----------");
            //New Car into a car competence
            if (granTurismo + f1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Auto agregado";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Vehiculo no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f1.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Car in F1 Competence -----------");
            //New Car into a car competence
            if (granTurismo + f3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Auto agregado";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Vehiculo no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f3.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert Same Car in F1 Competence -----------");
            //Same Car into a car competence
            if (granTurismo + f2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Auto agregado";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Vehiculo no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f2.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert Motorcycle in F1 Competence -----------");
            
            if (granTurismo + m1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Moto agregada";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m1.MostrarDatos());

            #endregion

            # region ComparerMotorcycles

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Moto in MotoCross Competence -----------");
            if (motoDakar + m1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Moto agregada";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m1.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert New Moto in MotoCross Competence -----------");
            if (motoDakar + m3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Moto agregada";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m3.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert Same Moto in MotoCross Competence -----------");
            if (motoDakar + m2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Moto agregada";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m2.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insert Car in MotoCross Competence -----------");
            if (motoDakar + f1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Auto agregado";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Auto no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f1.MostrarDatos());

            #endregion

            #region ShowCompetencesData

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Data of Competences -----------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Turismo Carretera:");
            Console.WriteLine(granTurismo.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Dakar MotoCross:");
            Console.WriteLine(motoDakar.MostrarDatos());

            #endregion

            Console.ReadKey();
        }
    }
}
