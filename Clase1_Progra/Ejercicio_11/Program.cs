using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max) {
            bool esValido = false;
 
            if ((valor >= min) && (valor <= max))
                esValido = true;
            return esValido;
        }

       
    }

    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool esValido = false;
            if (c == 's')
                esValido = true;

            return esValido;
        }
    }
}
