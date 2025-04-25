using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AlumnoProfesorLeoCiro
{
    class Alumno:Persona
    {
        string curso;
        int anio;
        int grupo;
        public string Curso { get { return curso; } set { curso = value; } }
        public int Anio { get { return anio; } set { anio = value; } }
        public int Grupo { get { return grupo; } set { grupo = value; } }
    }
}
