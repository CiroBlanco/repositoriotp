using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
