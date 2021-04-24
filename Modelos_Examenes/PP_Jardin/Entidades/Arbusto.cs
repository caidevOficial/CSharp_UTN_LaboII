using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arbusto : Planta
    {

        #region Builders

        public Arbusto(string nombre, int tamanio)
            : base(nombre, tamanio) { }

        #endregion

        #region Properties

        public override bool TieneFlores
        {
            get => false;
        }

        public override bool TieneFruto
        {
            get => false;
        }
        
        #endregion
        
    }
}
