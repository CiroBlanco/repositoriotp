using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoProfesorLeoCiro
{
    abstract class Persona
    {
        DateTime fechaNacimiento;
        int dni;
        string email;
        string nombre;
        string apellido;
        int telefono;
        public string Nombre{ get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string  Email { get { return email; } set { email = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public int Telefono { get { return telefono; } set { telefono = value; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
    }
}
