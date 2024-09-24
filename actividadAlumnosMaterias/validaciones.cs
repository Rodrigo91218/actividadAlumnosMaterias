using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadAlumnosMaterias
{
    class Validaciones
    {
        public static int LeerInt(int min, int max)
        {
            bool pudo = false;
            int val = 0;
            while (!pudo)
            {
                pudo = int.TryParse(Console.ReadLine(), out val);
                if (!pudo || val < min || val > max)
                {
                    pudo = false; /*si bien es un INT, no está en el rango esperado*/
                    Console.WriteLine(string.Concat("Valor incorrecto, solo números enteros entre ", min, " y ", max, ".\nIntente nuevamente: "));
                }
            }
            return val;
        }
    }
}
