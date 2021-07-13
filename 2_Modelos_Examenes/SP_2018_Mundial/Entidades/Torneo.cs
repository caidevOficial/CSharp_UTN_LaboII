using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo
    {


        private List<Grupo> grupos;
        private string nombre;
        
        public Torneo(string nombre)
        {
            this.grupos = new List<Grupo>();
            this.nombre = nombre;
        }
    }
}
