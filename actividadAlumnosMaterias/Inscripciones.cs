using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadAlumnosMaterias
{
    internal class Inscripciones
    {
        #region Atributos
        private int añoLectivo;
        private List<Materias> materia;
        private List<Alumnos> alumnos;
        private bool aprobado;
        #endregion

        #region Propiedades
        public int AñoLectivo { get { return añoLectivo; } set { añoLectivo = value; } }
        public List<Materias> Materias { get { return materia; } set { materia = value; } }
        public List<Alumnos> Alumnos { get { return alumnos; } set { alumnos = value; } }
        public bool Aprobado { get { return aprobado; } set { aprobado = value; } }
        #endregion

        #region Constructor
        public Inscripciones(int añoLectivo, List<Materias> materia, List<Alumnos> alumnos, bool aprobado)
        {
            this.añoLectivo = añoLectivo;
            this.materia = materia;
            this.alumnos = alumnos;
            this.aprobado = aprobado;
        }
        #endregion
    }
}
