using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {

        public Gente(short edad)
            :base("", edad){}

        protected override string Mostrar()
        {
            StringBuilder data = new StringBuilder();
            data.Append(base.Mostrar());

            return data.ToString();
        }

        public override bool Validar()
        {
            if (this.Edad > 18)
            {
                return true;
            }

            return false;
        }
    }
}
