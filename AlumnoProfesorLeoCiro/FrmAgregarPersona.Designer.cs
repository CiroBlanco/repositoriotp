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
            this.RbtProfesor = new System.Windows.Forms.RadioButton();
            this.RbtAlumno = new System.Windows.Forms.RadioButton();
            this.GrbAlumno = new System.Windows.Forms.GroupBox();
            this.GrbProfesor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GrbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbTipo
            // 
            this.GrbTipo.Controls.Add(this.RbtAlumno);
            this.GrbTipo.Controls.Add(this.RbtProfesor);
            this.GrbTipo.Location = new System.Drawing.Point(78, 51);
            this.GrbTipo.Name = "GrbTipo";
            this.GrbTipo.Size = new System.Drawing.Size(200, 100);
            this.GrbTipo.TabIndex = 0;
            this.GrbTipo.TabStop = false;
            this.GrbTipo.Text = "groupBox1";
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
            // GrbAlumno
            // 
            this.GrbAlumno.Location = new System.Drawing.Point(488, 72);
            this.GrbAlumno.Name = "GrbAlumno";
            this.GrbAlumno.Size = new System.Drawing.Size(201, 206);
            this.GrbAlumno.TabIndex = 1;
            this.GrbAlumno.TabStop = false;
            // 
            // GrbProfesor
            // 
            this.GrbProfesor.Location = new System.Drawing.Point(467, 38);
            this.GrbProfesor.Name = "GrbProfesor";
            this.GrbProfesor.Size = new System.Drawing.Size(206, 277);
            this.GrbProfesor.TabIndex = 0;
            this.GrbProfesor.TabStop = false;
            this.GrbProfesor.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 269);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // FrmAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrbProfesor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrbAlumno);
            this.Controls.Add(this.GrbTipo);
            this.Name = "FrmAgregarPersona";
            this.Text = "FrmAgregarPersona";
            this.GrbTipo.ResumeLayout(false);
            this.GrbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbTipo;
        private System.Windows.Forms.RadioButton RbtAlumno;
        private System.Windows.Forms.RadioButton RbtProfesor;
        private System.Windows.Forms.GroupBox GrbAlumno;
        private System.Windows.Forms.GroupBox GrbProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}