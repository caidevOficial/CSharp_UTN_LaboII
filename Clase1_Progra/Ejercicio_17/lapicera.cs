using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {
        short cantidadTintaMaxima = 100; // constante
        ConsoleColor color;
        short tinta;

        

        public Boligrafo(short tinta, ConsoleColor color) {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor() {
            return this.color;
        }

        public short GetTinta() {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = null;
            short tingaGastar = (short)(this.tinta - gasto);
           
                if (tingaGastar >= 0)
                {
                    for (int i = 0; i < tingaGastar; i++)
                    {
                        dibujo += "*";

                    }
                    return true;
                }else if (tingaGastar<0)
                {
                    for (int i = 0; i < this.tinta; i++)
                    {
                        dibujo = "*";
                    }
                    return true;
                }
                 SetTinta((short)(gasto * (-1)));

            return false;
        }

        void SetTinta(short tinta) {
            short calcularNivel = (short)(this.tinta + (tinta));
            
            if (calcularNivel < 0) // si resto mas de lo que tengo, pongo 0
            {
                this.tinta = 0;
            }
            else if (calcularNivel > 100) // si sumo mas del maximo, pongo maximo
            {
                this.tinta = 100;
            }
            else {// pongo la suma o resta de la tinta.
                this.tinta += tinta;
            }
        }

        public void Recargar() {
            short nivelFull = (short)(this.cantidadTintaMaxima - this.tinta);
            this.SetTinta(nivelFull);
        }
    }
}
