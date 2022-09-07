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
        private string Genero;
        private string Cedula;

        public Empleado(double salario, string nombre, string genero, string cedula)
        {
            this.Salario = salario;
            this.Nombre = nombre;
            this.Genero = genero;
            this.Cedula = cedula;
        }

        public Empleado()
        {
        }

        public double getsalario
        {
            get { return Salario; }
        }

        public string Cedula1 { get => Cedula; set => Cedula = value; }
        public double Salario1 { get => Salario; set => Salario = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Genero1 { get => Genero; set => Genero = value; }

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

        public static Empleado MenorSalario(Empleado empleado1,Empleado empleado2, double Salario)//cloanr el objeto (se usa empleado1 como pibote)
        {
            if (empleado1.Salario1 < Salario)
            {
                Empleado empleadoAux = new Empleado(empleado1.Salario1, empleado1.Nombre1, empleado1.Genero1, empleado1.Cedula1);
                return empleadoAux;
            }
            return empleado2;
        }

        public static Empleado MayorSalario(Empleado empleado1, Empleado empleado3, double Salario)//cloanr el objeto (se usa empleado1 como pibote)
        {
            if (empleado1.Salario1 > Salario)
            {
                Empleado empleadoAux = new Empleado(empleado1.Salario1, empleado1.Nombre1, empleado1.Genero1, empleado1.Cedula1);
                return empleadoAux;
            }
            return empleado3;
        }
    }


}
