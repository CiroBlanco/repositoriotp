namespace AlumnoProfesorLeoCiro
{
    partial class FrmAgregarPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrbTipo = new System.Windows.Forms.GroupBox();
            this.RbtAlumno = new System.Windows.Forms.RadioButton();
            this.RbtProfesor = new System.Windows.Forms.RadioButton();
            this.GrbAlumno = new System.Windows.Forms.GroupBox();
            this.GrbProfesor = new System.Windows.Forms.GroupBox();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblMateria = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.TxtCurso = new System.Windows.Forms.TextBox();
            this.TxtAño = new System.Windows.Forms.TextBox();
            this.TxtGrupo = new System.Windows.Forms.TextBox();
            this.LblCurso = new System.Windows.Forms.Label();
            this.LblAño = new System.Windows.Forms.Label();
            this.LblGrupo = new System.Windows.Forms.Label();
            this.GrbPersona = new System.Windows.Forms.GroupBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.GrbTipo.SuspendLayout();
            this.GrbAlumno.SuspendLayout();
            this.GrbProfesor.SuspendLayout();
            this.GrbPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbTipo
            // 
            this.GrbTipo.Controls.Add(this.RbtAlumno);
            this.GrbTipo.Controls.Add(this.RbtProfesor);
            this.GrbTipo.Location = new System.Drawing.Point(53, 51);
            this.GrbTipo.Name = "GrbTipo";
            this.GrbTipo.Size = new System.Drawing.Size(200, 94);
            this.GrbTipo.TabIndex = 0;
            this.GrbTipo.TabStop = false;
            // 
            // RbtAlumno
            // 
            this.RbtAlumno.AutoSize = true;
            this.RbtAlumno.Checked = true;
            this.RbtAlumno.Location = new System.Drawing.Point(46, 21);
            this.RbtAlumno.Name = "RbtAlumno";
            this.RbtAlumno.Size = new System.Drawing.Size(60, 17);
            this.RbtAlumno.TabIndex = 1;
            this.RbtAlumno.TabStop = true;
            this.RbtAlumno.Text = "Alumno";
            this.RbtAlumno.UseVisualStyleBackColor = true;
            this.RbtAlumno.Click += new System.EventHandler(this.RbtAlumno_Click);
            // 
            // RbtProfesor
            // 
            this.RbtProfesor.AutoSize = true;
            this.RbtProfesor.Location = new System.Drawing.Point(46, 44);
            this.RbtProfesor.Name = "RbtProfesor";
            this.RbtProfesor.Size = new System.Drawing.Size(64, 17);
            this.RbtProfesor.TabIndex = 1;
            this.RbtProfesor.Text = "Profesor";
            this.RbtProfesor.UseVisualStyleBackColor = true;
            this.RbtProfesor.Click += new System.EventHandler(this.RbtProfesor_Click);
            // 
            // GrbAlumno
            // 
            this.GrbAlumno.Controls.Add(this.LblGrupo);
            this.GrbAlumno.Controls.Add(this.LblAño);
            this.GrbAlumno.Controls.Add(this.LblCurso);
            this.GrbAlumno.Controls.Add(this.TxtGrupo);
            this.GrbAlumno.Controls.Add(this.TxtAño);
            this.GrbAlumno.Controls.Add(this.TxtCurso);
            this.GrbAlumno.Location = new System.Drawing.Point(569, 85);
            this.GrbAlumno.Name = "GrbAlumno";
            this.GrbAlumno.Size = new System.Drawing.Size(201, 206);
            this.GrbAlumno.TabIndex = 1;
            this.GrbAlumno.TabStop = false;
            // 
            // GrbProfesor
            // 
            this.GrbProfesor.Controls.Add(this.LblTitulo);
            this.GrbProfesor.Controls.Add(this.LblMateria);
            this.GrbProfesor.Controls.Add(this.LblTipo);
            this.GrbProfesor.Controls.Add(this.TxtTitulo);
            this.GrbProfesor.Controls.Add(this.TxtMateria);
            this.GrbProfesor.Controls.Add(this.CmbTipo);
            this.GrbProfesor.Location = new System.Drawing.Point(558, 51);
            this.GrbProfesor.Name = "GrbProfesor";
            this.GrbProfesor.Size = new System.Drawing.Size(206, 262);
            this.GrbProfesor.TabIndex = 0;
            this.GrbProfesor.TabStop = false;
            this.GrbProfesor.Visible = false;
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "Titular",
            "Suplente",
            "Provisional"});
            this.CmbTipo.Location = new System.Drawing.Point(41, 57);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(121, 21);
            this.CmbTipo.TabIndex = 0;
            // 
            // TxtMateria
            // 
            this.TxtMateria.Location = new System.Drawing.Point(44, 143);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(100, 20);
            this.TxtMateria.TabIndex = 1;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(44, 220);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(100, 20);
            this.TxtTitulo.TabIndex = 2;
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(38, 36);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(31, 13);
            this.LblTipo.TabIndex = 3;
            this.LblTipo.Text = "Tipo:";
            // 
            // LblMateria
            // 
            this.LblMateria.AutoSize = true;
            this.LblMateria.Location = new System.Drawing.Point(41, 127);
            this.LblMateria.Name = "LblMateria";
            this.LblMateria.Size = new System.Drawing.Size(45, 13);
            this.LblMateria.TabIndex = 4;
            this.LblMateria.Text = "Materia:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(41, 204);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(36, 13);
            this.LblTitulo.TabIndex = 5;
            this.LblTitulo.Text = "Titulo:";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(326, 329);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviar.TabIndex = 6;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            // 
            // TxtCurso
            // 
            this.TxtCurso.Location = new System.Drawing.Point(43, 38);
            this.TxtCurso.Name = "TxtCurso";
            this.TxtCurso.Size = new System.Drawing.Size(100, 20);
            this.TxtCurso.TabIndex = 0;
            // 
            // TxtAño
            // 
            this.TxtAño.Location = new System.Drawing.Point(43, 92);
            this.TxtAño.Name = "TxtAño";
            this.TxtAño.Size = new System.Drawing.Size(100, 20);
            this.TxtAño.TabIndex = 1;
            // 
            // TxtGrupo
            // 
            this.TxtGrupo.Location = new System.Drawing.Point(43, 151);
            this.TxtGrupo.Name = "TxtGrupo";
            this.TxtGrupo.Size = new System.Drawing.Size(100, 20);
            this.TxtGrupo.TabIndex = 2;
            // 
            // LblCurso
            // 
            this.LblCurso.AutoSize = true;
            this.LblCurso.Location = new System.Drawing.Point(40, 22);
            this.LblCurso.Name = "LblCurso";
            this.LblCurso.Size = new System.Drawing.Size(37, 13);
            this.LblCurso.TabIndex = 3;
            this.LblCurso.Text = "Curso:";
            // 
            // LblAño
            // 
            this.LblAño.AutoSize = true;
            this.LblAño.Location = new System.Drawing.Point(40, 76);
            this.LblAño.Name = "LblAño";
            this.LblAño.Size = new System.Drawing.Size(29, 13);
            this.LblAño.TabIndex = 4;
            this.LblAño.Text = "Año:";
            // 
            // LblGrupo
            // 
            this.LblGrupo.AutoSize = true;
            this.LblGrupo.Location = new System.Drawing.Point(40, 135);
            this.LblGrupo.Name = "LblGrupo";
            this.LblGrupo.Size = new System.Drawing.Size(39, 13);
            this.LblGrupo.TabIndex = 5;
            this.LblGrupo.Text = "Grupo:";
            // 
            // GrbPersona
            // 
            this.GrbPersona.Controls.Add(this.LblDni);
            this.GrbPersona.Controls.Add(this.LblApellido);
            this.GrbPersona.Controls.Add(this.LblNombre);
            this.GrbPersona.Controls.Add(this.TxtDni);
            this.GrbPersona.Controls.Add(this.TxtApellido);
            this.GrbPersona.Controls.Add(this.TxtNombre);
            this.GrbPersona.Location = new System.Drawing.Point(284, 51);
            this.GrbPersona.Name = "GrbPersona";
            this.GrbPersona.Size = new System.Drawing.Size(189, 227);
            this.GrbPersona.TabIndex = 7;
            this.GrbPersona.TabStop = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(37, 74);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 0;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(37, 117);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 1;
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(37, 165);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(100, 20);
            this.TxtDni.TabIndex = 2;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(37, 55);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(37, 100);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(47, 13);
            this.LblApellido.TabIndex = 4;
            this.LblApellido.Text = "Apellido:";
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(37, 146);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(29, 13);
            this.LblDni.TabIndex = 5;
            this.LblDni.Text = "DNI:";
            // 
            // FrmAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrbPersona);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.GrbProfesor);
            this.Controls.Add(this.GrbAlumno);
            this.Controls.Add(this.GrbTipo);
            this.Name = "FrmAgregarPersona";
            this.Text = "FrmAgregarPersona";
            this.GrbTipo.ResumeLayout(false);
            this.GrbTipo.PerformLayout();
            this.GrbAlumno.ResumeLayout(false);
            this.GrbAlumno.PerformLayout();
            this.GrbProfesor.ResumeLayout(false);
            this.GrbProfesor.PerformLayout();
            this.GrbPersona.ResumeLayout(false);
            this.GrbPersona.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbTipo;
        private System.Windows.Forms.RadioButton RbtAlumno;
        private System.Windows.Forms.RadioButton RbtProfesor;
        private System.Windows.Forms.GroupBox GrbAlumno;
        private System.Windows.Forms.GroupBox GrbProfesor;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblMateria;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.TextBox TxtCurso;
        private System.Windows.Forms.Label LblGrupo;
        private System.Windows.Forms.Label LblAño;
        private System.Windows.Forms.Label LblCurso;
        private System.Windows.Forms.TextBox TxtGrupo;
        private System.Windows.Forms.TextBox TxtAño;
        private System.Windows.Forms.GroupBox GrbPersona;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
    }
}