using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadAlumnosMaterias
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Materias> materias = new List<Materias>();
            List<Alumnos> alumnos = new List<Alumnos>();

            int opcion; //acá vamos a guardar la opción elegida
            do
            {
                opcion = Menu();

                switch (opcion)
                {
                    case 1:
                        CargarMaterias(materias);
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                }

            } while (opcion != 0);


            Console.ReadKey();

        }

        private static int Menu()
        {
            int opcion;

            Console.WriteLine("Ingrese el número de la opción y luego enter:\n");
            Console.WriteLine("1 - Cargar materia");
            Console.WriteLine("2 - Cargar alumno");
            Console.WriteLine("3 - Cargar inscripciones");
            Console.WriteLine("4 - Buscar materia");
            Console.WriteLine("5 - Buscar alumno");
            Console.WriteLine("6 - Ver inscripciones");
            Console.WriteLine("7 - Aprobar alumnos");
            Console.WriteLine("8 - Ver materias aprobadas");

            Console.WriteLine("0 - Salir\n");

            opcion = Validaciones.LeerInt(0, 8);
            return opcion;
        }

        private static void CargarMaterias(List<Materias> materias)
        {
            Materias m = new Materias();
            Console.WriteLine("Cargar materias\n");

            Console.WriteLine("Ingrese el nombre de la materia: ");
            m.NombreMateria = Console.ReadLine();
            materias.Add(m);

            Console.WriteLine("La materia se agrego exitosamente!.");
            /*
            foreach (Materias mat in materias)
            {
                Console.WriteLine(mat);
            }*/

        }
        private static void CargarAlumno(List<Alumnos> alumnos)
        {
            Alumnos a = new Alumnos();
            Console.WriteLine("ingresar nombre: ");
            a.Nombre = Console.ReadLine();
            Console.WriteLine("ingresar el apellido: ");
            a.Apellido = Console.ReadLine();
            Console.WriteLine("ingresar fecha de nacimiento: ");
            a.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ingresar documento:");
            a.Documento = ;
        }


    }

}
