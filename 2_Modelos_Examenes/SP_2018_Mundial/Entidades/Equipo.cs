using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private int id;
        private string nombre;

        private short puntos;
        private short golesHechos;
        private short golesRecibidos;

        public Equipo(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public short Puntos
        {
            get
            {
                return this.puntos;
            }
            set
            {
                this.puntos = value;
            }
        }

        public short GolesRecibidos
        {
            get
            {
                return this.golesRecibidos;
            }
            set
            {
                this.golesRecibidos = value;
            }
        }

        public short GolesHechos
        {
            get
            {
                return this.golesHechos;
            }
            set
            {
                this.golesHechos = value;
            }
        }
    }
}
