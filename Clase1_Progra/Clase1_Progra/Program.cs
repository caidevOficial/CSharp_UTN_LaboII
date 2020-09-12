using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Progra{
    class Program{
        
        static void Main(string[] args){
            
            byte escalar = 0;
            String a;
            
            Console.Write("Ingrese un numero: ");
            a = Console.ReadLine();
           escalar = byte.Parse(a);
            Console.Write(escalar);
            Console.ReadKey();
        }
    }
}
