using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoProfesorLeoCiro
{
    public enum Categoria
    {
        titular,
        suplente,
        provisional
    }
    class Profesor:Persona
    {
        string materia;
        string titulo;
        Categoria tipo;
        public Profesor(string mat, string titu, Categoria tip)
        {
            materia = mat;
            titulo = titu;
            tipo = tip;
        }
    public string Tipo
        {
            get
            {
                switch (tipo)
                {
                    case Categoria.titular:
                        return "Titular";
                    case Categoria.suplente:
                        return "Suplente";
                    case Categoria.provisional:
                        return "Provisional";
                    default:
                        return "";
                }
            }
            private set { }
        }
        public string Materia { get { return materia; } set { materia = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public void SetCategoria (Categoria cat)    
        {
            tipo = cat;
        }
    }
}
