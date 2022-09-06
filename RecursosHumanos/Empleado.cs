using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanos
{
    internal class Empleado
    {
        //el salario, el nombre, el género y la cedula
        private double Salario;
        private string Nombre;
        private char Genero;
        private string Cedula;

        public Empleado(double salario, string nombre, char genero, string cedula)
        {
            this.Salario = salario;
            this.Nombre = nombre;
            this.Genero = genero;
            this.Cedula = cedula;
        }

        public double getsalario
        {
            get { return Salario; }
        }

        public string Cedula1 { get => Cedula; set => Cedula = value; }
        public double Salario1 { get => Salario; set => Salario = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public char Genero1 { get => Genero; set => Genero = value; }

        static void Mensaje(double Salario1, string Nombre1, char Genero1, string Cedula1)
        {
            Console.WriteLine("Datos de los empleados: ");
            Console.WriteLine("Cedula : " + Cedula1 + ", Nombre: " + Nombre1 + ", Genero: " + Genero1 + ", Salario: " + Salario1);
        }

        public override bool Equals(object obj)
        {
            return obj is Empleado empleado &&
                   Salario == empleado.Salario &&
                   Nombre == empleado.Nombre &&
                   Genero == empleado.Genero &&
                   Cedula == empleado.Cedula &&
                   Cedula1 == empleado.Cedula1 &&
                   Salario1 == empleado.Salario1 &&
                   Nombre1 == empleado.Nombre1 &&
                   Genero1 == empleado.Genero1;
        }
    }


}
