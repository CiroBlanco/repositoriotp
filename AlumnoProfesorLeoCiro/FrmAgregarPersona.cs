using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnoProfesorLeoCiro
{
    public partial class FrmAgregarPersona: Form
    {
        public FrmAgregarPersona()
        {
            InitializeComponent();
        }

        private void RbtAlumno_Click(object sender, EventArgs e)
        {
            GrbProfesor.Visible = false;
            GrbAlumno.Visible = true;
        }

        private void RbtProfesor_Click(object sender, EventArgs e)
        {
            GrbProfesor.Visible = true;
            GrbAlumno.Visible = false;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Persona nuevaPersona;
            if (RbtAlumno.Checked)
                nuevaPersona = new Alumno(TxtCurso.Text, int.Parse(TxtAnio.Text), int.Parse(TxtGrupo.Text));
            else
            {
                Categoria cat;
                switch(CmbTipo.Text)
                {
                    case "Titular":
                        cat = Categoria.titular;
                        break;
                    case "Suplente":
                        cat = Categoria.suplente;
                        break;
                    case "Provisional":
                        cat = Categoria.provisional;
                        break;
                    default:
                        cat = Categoria.titular;
                        break;
                }
                nuevaPersona = new Profesor(TxtMateria.Text, TxtTitulo.Text,cat);
            }
            nuevaPersona.Nombre = TxtNombre.Text;
            nuevaPersona.Apellido = TxtNombre.Text;
            nuevaPersona.Dni = TxtDni.Text;
            nuevaPersona.Telefono = txtTelefono.Text;
            nuevaPersona.Email = TxtEmail.Text;
            nuevaPersona.FechaNacimiento = DtpFechaNacimiento.Value;
        }
    }
}
