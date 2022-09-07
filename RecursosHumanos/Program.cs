using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Una compañía requiere analizar las condiciones laborares de sus trabajadores, por cada empleado se tiene los
            siguientes datos: el salario, el nombre, el género y la cedula.Se solita hallar las siguientes estadísticas:
            //• La nómina(total de salarios)
            //• El salario promedio
            //• Cuál es el menor salario y su nombre
            //• Cuál es el mayor salario, su género y la cedula
            //•Salario promedio de las mujeres
            • Cuantos empleados ganan menos del salario mínimo, cuantos ganan entre 1 y 2, y cuantos gana más de 2
            salarios mínimos.*/

            string IngresoEmpleado = string.Empty;
            double TotalSAlarios = 0;
            int ContTotal = 0;
            double SalarioMax = double.MaxValue;
            double SalarioMin = double.MinValue;
            double SalarioMujeres = 0;
            string Genero;
            int ContMujeres = 0;
            double SMMLV = 1000000;
            int Salario1 = 0;
            int Salario2 = 0;
            int Salario3 = 0;

            Empleado empleado1 = new Empleado();
            Empleado empleado2 = new Empleado();
            Empleado empleado3 = new Empleado();

            Console.WriteLine("*********************** Bienvenido al sistema de Recursos Humanos ***********************");
            Console.WriteLine();
            Console.WriteLine("Aquí podrá ingresar informacion de sus empleados y optendra algunas metricas.");

            do
            {
                Console.WriteLine("Acontinuacion debe ingrear los datos del empleado: ");
                Console.WriteLine("Ingrese la cedula del empleado: ");
                empleado1.Cedula1 = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del empleado: ");
                empleado1.Nombre1 = Console.ReadLine();
                do
                {
                    Console.WriteLine("Ingrese el Genero del empleado: ");
                    Console.WriteLine("(HOMBRE) - (MUJER)\n");
                    Genero = Console.ReadLine().ToUpper();
                    empleado1.Genero1 = Genero;
                    if (Genero != "HOMBRE" && Genero != "MUJER") Mensaje("Opcion ingresada no valida, intente de nuevo");
                } while (Genero != "HOMBRE" && Genero != "MUJER");

                Console.WriteLine("Ingrese el salario del empleado: ");
                empleado1.Salario1 = Int32.Parse(Console.ReadLine());

                TotalSAlarios = TotalSAlarios + empleado1.Salario1;
                ContTotal = ContTotal + 1;
                empleado2 = Empleado.MenorSalario(empleado1, empleado2, SalarioMax);
                empleado3 = Empleado.MayorSalario(empleado1, empleado3, SalarioMin);
                SalarioMin = empleado2.Salario1;
                SalarioMax = empleado3.Salario1;
                Salario1 = empleado1.Salario1 <= SMMLV ? Salario1 + 1 : Salario1 + 0;
                Salario2 = (empleado1.Salario1 > SMMLV && empleado1.Salario1 <= (2 * SMMLV)) ? Salario2 + 1 : Salario2 + 0;
                Salario3 = (empleado1.Salario1 > (2 * SMMLV)) ? Salario3 + 1 : Salario3 + 0;

                if (empleado1.Genero1 == "MUJER") ContMujeres++;
                if (empleado1.Genero1 == "MUJER") SalarioMujeres = SalarioMujeres + SalarioMujeres;
                do
                {
                    Console.WriteLine("¿Desea ingresar otro empleado?\n");
                    Console.WriteLine("(Si) - (No)\n");
                    IngresoEmpleado = Console.ReadLine().ToUpper();
                    if (IngresoEmpleado != "SI" && IngresoEmpleado != "NO") Mensaje("Opcion ingresada no valida, intente de nuevo");
                } while (IngresoEmpleado != "SI" && IngresoEmpleado != "NO");

            } while (IngresoEmpleado == "SI");

            Mensaje("\tEl valor total de la nomina es: $" + TotalSAlarios);
            Mensaje("\tEl valor Promedio de la nomina es: $" + Promedio(TotalSAlarios, ContTotal));
            Mensaje("\tEl menor salario devengado es: $" + empleado2.Salario1 + ", por: " + empleado2.Nombre1);
            Mensaje("\tEl Mayor salario devengado es: $" + empleado3.Salario1 + ", cedula del empleado: " + empleado3.Cedula1 + ", genero del empleado: " + empleado3.Genero1);//• Cuál es el mayor salario, su género y la cedula
            Mensaje("\tEl salario Promedio de las mujeres es: $" + Promedio(TotalSAlarios, ContTotal, Genero));
            Mensaje("\tEmpleados que ganan menos de un SMMLV: " + Salario1 +
                "\n\tEmpleados que ganan entre un SMMLV y dos SMMLV: " + Salario2+
                "\n\tEmpleados que ganan mas de dos SMMLV: " + Salario3);

            Console.WriteLine("\n***************** Proceso realizado con exito *****************\n (\\__/)\r\n(>’.’<)\r\n(\")_(\")");
            Console.ReadKey();
        }

        public static void Mensaje(string Cadena)
        {
            Console.WriteLine(Cadena);

        }

        public static double Promedio(double SalarioMujeres, int ContMujeres, string genero)
        {
            double promedio = SalarioMujeres / ContMujeres;
            return promedio;

        }

        public static double Promedio(double totalsalario, int contTotal)
        {
            double promedio = totalsalario / contTotal;
            return promedio;
        }
               
    }
}
