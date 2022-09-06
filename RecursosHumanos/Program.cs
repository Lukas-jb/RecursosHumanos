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
            • La nómina(total de salarios)
            • El salario promedio
            • Cuál es el menor salario y su nombre
            • Cuál es el mayor salario, su género y la cedula
            • Salario promedio de las mujeres
            • Cuantos empleados ganan menos del salario mínimo, cuantos ganan entre 1 y 2, y cuantos gana más de 2
            salarios mínimos.*/
            int DesitionMenu = 1;


            Empleado empleado1 = new Empleado(3696125, "Joseba Talavera", 'M', "1989243669");
            Empleado empleado2 = new Empleado(1782159, "Jairo Morilla", 'M', "1320356002");
            Empleado empleado3 = new Empleado(2746866, "Raul López", 'M', "1047727899");
            Empleado empleado4 = new Empleado(4774325, "Mohammed Villa", 'M', "1784154842");
            Empleado empleado5 = new Empleado(1019871, "Alvaro Fuente", 'M', "1015180680");
            Empleado empleado6 = new Empleado(2851017, "Maria Eva Sancho", 'F', "1386187632");
            Empleado empleado7 = new Empleado(4126925, "Pilar Espejo", 'F', "1928688233");
            Empleado empleado8 = new Empleado(2396021, "Daniela Machado", 'F', "1760995662");
            Empleado empleado9 = new Empleado(1473767, "Laura Cervantes", 'F', "1322342931");
            Empleado empleado10 = new Empleado(4343256, "Angelica Arnau", 'F', "1161480639");

            Console.WriteLine("*********************** Bienvenido al sistema de Recursos Humanos ***********************");
            Console.WriteLine();
            Console.WriteLine("Aquí podrá obtener información de sus empleados.");
            Console.WriteLine("A continuación se listan las posibles actividades a realizar.");
            do
            {
                DesitionMenu = Menu();

                switch (DesitionMenu)
                {
                    case 1:
                        Console.WriteLine("\n==== Ha seleccionado la opcion imprimir valor total de la nomina. ====");
                        Console.WriteLine("El valor total de la nomina es : " + TotalSalary(empleado1, empleado2, empleado3, empleado4, empleado5, empleado6, empleado7, empleado8, empleado9, empleado10));

                        break;
                    case 2:
                        Console.WriteLine("\n==== Ha seleccionado la opcion imprimir el salario promedio. ====");
                        Console.WriteLine("El valor promedio de la nomina es : " + SalarioPromedio(empleado1, empleado2, empleado3, empleado4, empleado5, empleado6, empleado7, empleado8, empleado9, empleado10));

                        break;
                    case 3:
                        Console.WriteLine("\n==== Ha seleccionado la opcion imprimir el menor salario y nombre del empleado. ====");
                        Console.WriteLine(MenorSalario(empleado1, empleado2, empleado3, empleado4, empleado5, empleado6, empleado7, empleado8, empleado9, empleado10));

                        break;
                    case 4:
                        Console.WriteLine("\n==== Ha seleccionado la opcion imprimir el mayor salario devengado, género y cedula del empleado. ====");

                        break;
                    case 5:
                        Console.WriteLine("\n==== Ha seleccionado la opcion imprimir salario promedio de las mujeres. ====");

                        break;
                    case 6:
                        Console.WriteLine("\n==== Ha seleccionado la opcion imprimir cuantos empleados ganan:" +
                                           "\n\t- menos del salario mínimo," +
                                           "\n\t- entre 1 y 2," +
                                           "\n\t- más de 2 salarios mínimos");

                        break;
                    case 7:
                        Console.WriteLine("\n==== Ha seleccionado la opcion imprimir empleados registrados");
                        break;
                    case 0:
                        Console.WriteLine("Sali\n==== ");

                        break;


                    default:
                        Console.WriteLine("Opcion ingresada no valida, intente de nuevo");
                        break;
                }


            } while (true);
            Console.ReadKey();
        }
        public static int Menu()
        {
            int DesitionMenu = 8;
            Console.WriteLine("\n1.Imprimir valor total de la nomina");
            Console.WriteLine("2.Imprimir el salario promedio");
            Console.WriteLine("3.Imprimir el menor salario y nombre del empleado");
            Console.WriteLine("4.Imprimir el mayor salario devengado, género y cedula del empleado");
            Console.WriteLine("5.Imprimir salario promedio de las mujeres");
            Console.WriteLine("6.Imprimir cuantos empleados ganan:" +
                "\n\t- menos del salario mínimo," +
                "\n\t- entre 1 y 2," +
                "\n\t- más de 2 salarios mínimos");
            Console.WriteLine("7.Imprimir empleados registrados");
            Console.WriteLine("0.Salir del programa");
            DesitionMenu = Convert.ToInt32(Console.ReadLine());
            return DesitionMenu;
        }

        public static double TotalSalary(Empleado empleado1, Empleado empleado2, Empleado empleado3, Empleado empleado4, Empleado empleado5, Empleado empleado6, Empleado empleado7, Empleado empleado8, Empleado empleado9, Empleado empleado10)
        {
            double sum = 0;
            double Total = 0;
            sum = sum + empleado1.Salario1;
            sum = sum + empleado2.Salario1;
            sum = sum + empleado3.Salario1;
            sum = sum + empleado4.Salario1;
            sum = sum + empleado5.Salario1;
            sum = sum + empleado6.Salario1;
            sum = sum + empleado7.Salario1;
            sum = sum + empleado8.Salario1;
            sum = sum + empleado9.Salario1;
            sum = sum + empleado10.Salario1;
            Total = sum;

            return Total;
        }

        public static double SalarioPromedio(Empleado empleado1, Empleado empleado2, Empleado empleado3, Empleado empleado4, Empleado empleado5, Empleado empleado6, Empleado empleado7, Empleado empleado8, Empleado empleado9, Empleado empleado10)
        {
            double Promedio = TotalSalary(empleado1, empleado2, empleado3, empleado4, empleado5, empleado6, empleado7, empleado8, empleado9, empleado10);
            Promedio = Promedio / 10;

            return Promedio;
        }

        public static string MenorSalario(Empleado empleado1, Empleado empleado2, Empleado empleado3, Empleado empleado4, Empleado empleado5, Empleado empleado6, Empleado empleado7, Empleado empleado8, Empleado empleado9, Empleado empleado10)
        {
            double MenorSalario = double.MaxValue;
            var MenorsalarioText = "";
            MenorSalario = empleado1.getsalario < MenorSalario ? empleado1.getsalario : MenorSalario;
            MenorSalario = empleado2.Salario1 < MenorSalario ? empleado2.Salario1 : MenorSalario;
            MenorSalario = empleado3.Salario1 < MenorSalario ? empleado3.Salario1 : MenorSalario;
            MenorSalario = empleado4.Salario1 < MenorSalario ? empleado4.Salario1 : MenorSalario;
            MenorSalario = empleado5.Salario1 < MenorSalario ? empleado5.Salario1 : MenorSalario;
            MenorSalario = empleado6.Salario1 < MenorSalario ? empleado6.Salario1 : MenorSalario;
            MenorSalario = empleado7.Salario1 < MenorSalario ? empleado7.Salario1 : MenorSalario;
            MenorSalario = empleado8.Salario1 < MenorSalario ? empleado8.Salario1 : MenorSalario;
            MenorSalario = empleado9.Salario1 < MenorSalario ? empleado9.Salario1 : MenorSalario;
            MenorSalario = empleado10.Salario1 < MenorSalario ? empleado10.Salario1 : MenorSalario;
            MenorsalarioText = "El menor salario es: " + MenorSalario + " Devengado Por: " + Nombre_Salario(empleado1, empleado2, empleado3, empleado4, empleado5, empleado6, empleado7, empleado8, empleado9, empleado10, MenorSalario);

            return MenorsalarioText;
        }

        public static string Nombre_Salario(Empleado empleado1, Empleado empleado2, Empleado empleado3, Empleado empleado4, Empleado empleado5, Empleado empleado6, Empleado empleado7, Empleado empleado8, Empleado empleado9, Empleado empleado10, double Salario)
        {
            string Nombre = "";

            if (empleado1.Salario1 == Salario)Nombre = empleado1.Nombre1;
            if (empleado1.Salario1 == Salario) Nombre = empleado1.Nombre1;
            if (empleado2.Salario1 == Salario) Nombre = empleado2.Nombre1;
            if (empleado3.Salario1 == Salario) Nombre = empleado3.Nombre1;
            if (empleado4.Salario1 == Salario) Nombre = empleado4.Nombre1;
            if (empleado5.Salario1 == Salario) Nombre = empleado5.Nombre1;
            if (empleado6.Salario1 == Salario) Nombre = empleado6.Nombre1;
            if (empleado7.Salario1 == Salario) Nombre = empleado7.Nombre1;
            if (empleado8.Salario1 == Salario) Nombre = empleado8.Nombre1;
            if (empleado9.Salario1 == Salario) Nombre = empleado9.Nombre1;
            if (empleado10.Salario1 == Salario) Nombre =  empleado10.Nombre1;

            return Nombre;
        }



        static void GetPropertyValue(Type type, string propertyName, object instanceObject)
        {
            Console.WriteLine($"Value of Property:{type.GetProperty(propertyName).GetValue(instanceObject, null)}");

        }

    }
}
