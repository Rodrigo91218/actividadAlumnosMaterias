using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadAlumnosMaterias
{
    internal class Materias
    {

        #region Atributos
        private string nombreMateria;
        #endregion

        #region Propiedades
        public string NombreMateria { get { return nombreMateria; } set { nombreMateria = value; } }
        #endregion

        #region Constructor
        public Materias() { nombreMateria = ""; }
        public Materias(string nombreMateria)
        {
            this.nombreMateria = nombreMateria;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Concat(nombreMateria);
        }

        #endregion
    }
}
