using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        private  List<Empleado> empleados;
        private  List<Gente> gente;
        private static Bar singleton;

        #region Properties

        public List<Empleado> Empleados
        {
            get => this.empleados;
        }

        public List<Gente> Gente
        {
            get => this.gente;
        }

        #endregion

        #region Builders

        static Bar()
        {
            Bar.singleton = new Bar();
        }

        public Bar()
        {
            this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
        }

        public Bar GetBar()
        {
            if (Bar.singleton is null)
            {
                Bar.singleton = new Bar();
            }

            return Bar.singleton;
        }

        #endregion

        #region Operators

        public static bool operator +(Bar bar, Empleado empleado)
        {
            if(!(bar is null) && !(empleado is null))
            {
                foreach(Empleado empleadoDeBar in bar.empleados)
                {
                    if(empleadoDeBar != empleado)
                    {
                        bar.empleados.Add(empleado);
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator +(Bar bar, Gente gente)
        {
            if (!(bar is null) && !(gente is null))
            {
                foreach(Gente genteEnBar in bar.gente)
                {
                    if (genteEnBar != gente && bar.gente.Count < (bar.empleados.Count *10))
                    {
                        bar.gente.Add(gente);
                        return true;
                    }
                }
            }

            return false;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            foreach(Empleado e in this.empleados)
            {
                data.Append(e.ToString());
            }
            foreach(Gente g in this.gente)
            {
                data.Append(g.ToString());
            }

            return data.ToString();
        }

        #endregion
    }
}
