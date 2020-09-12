using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        string nombre = string.Empty;
        string apellido = string.Empty;
        int legajo;
        byte nota1;
        byte nota2;
        float notaFinal;

        public Alumno(string nombre, string apellido, int legajo) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public Alumno()
        {

        }

        // setters
        public void SetNombre(string name)
        {
            this.nombre = name;
        }

        public void SetLegajo(int legajo)
        {
            this.legajo = legajo;
        }

       public void SetNota1(byte note1)
        {
            this.nota1 = note1;
        }

        public void SetNota2(byte note2)
        {
            this.nota2 = note2;
        }

        //getters
        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public byte GetNota1()
        {
            return this.nota1;
        }

        public byte GetNota2()
        {
            return this.nota2;
        }

        public void Estudiar(byte nota1, byte nota2)
        {
            this.SetNota1(nota1);
            this.SetNota2(nota2);
        }

        public void CalcularFinal()
        {
            byte nota1 = this.GetNota1();
            byte nota2 = this.GetNota2();

            double final = -1;
            if (nota1 >= 4 && nota2 >= 4)
            {
                Random random = new Random();
                final = random.Next(0, 10);
            }
            this.notaFinal = (float)final;
            //Console.WriteLine("Nota final: " + final);
        }

        public void Mostrar() {
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Apellido: " + this.apellido);
            Console.WriteLine("Nota1: " + this.nota1);
            Console.WriteLine("Nota2: " + this.nota2);
            if (this.notaFinal != -1)
                Console.WriteLine("Final: " + this.notaFinal);
            else
                Console.WriteLine("Final: Alumno desaprovado");
        }
    }
}
