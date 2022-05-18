namespace MathProyecto
{
    partial class Profesores_a
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.datosAlumnos = new System.Windows.Forms.DataGridView();
            this.profesoresadminaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telcasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telcelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresadminaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnMod);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtDato);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1107, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(112)))), ((int)(((byte)(99)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(984, 35);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 40);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Location = new System.Drawing.Point(864, 35);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(91, 40);
            this.btnMod.TabIndex = 3;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(216)))), ((int)(((byte)(53)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(750, 35);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 40);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(630, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 40);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Actualizar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(24, 42);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(585, 29);
            this.txtDato.TabIndex = 0;
            // 
            // datosAlumnos
            // 
            this.datosAlumnos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.datosAlumnos.AllowUserToAddRows = false;
            this.datosAlumnos.AllowUserToDeleteRows = false;
            this.datosAlumnos.AllowUserToResizeColumns = false;
            this.datosAlumnos.AllowUserToResizeRows = false;
            this.datosAlumnos.AutoGenerateColumns = false;
            this.datosAlumnos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datosAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datosAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(124)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datosAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apaternoDataGridViewTextBoxColumn,
            this.amaternoDataGridViewTextBoxColumn,
            this.telcasaDataGridViewTextBoxColumn,
            this.telcelDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.redDataGridViewTextBoxColumn,
            this.perfilDataGridViewTextBoxColumn});
            this.datosAlumnos.DataSource = this.profesoresadminaBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datosAlumnos.DefaultCellStyle = dataGridViewCellStyle3;
            this.datosAlumnos.EnableHeadersVisualStyles = false;
            this.datosAlumnos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.datosAlumnos.Location = new System.Drawing.Point(45, 156);
            this.datosAlumnos.Name = "datosAlumnos";
            this.datosAlumnos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datosAlumnos.RowHeadersVisible = false;
            this.datosAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosAlumnos.Size = new System.Drawing.Size(1107, 605);
            this.datosAlumnos.TabIndex = 2;
            // 
            // profesoresadminaBindingSource
            // 
            this.profesoresadminaBindingSource.DataSource = typeof(MathProyecto.profesores_admin_a);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // apaternoDataGridViewTextBoxColumn
            // 
            this.apaternoDataGridViewTextBoxColumn.DataPropertyName = "A_paterno";
            this.apaternoDataGridViewTextBoxColumn.HeaderText = "Apellido Paterno";
            this.apaternoDataGridViewTextBoxColumn.Name = "apaternoDataGridViewTextBoxColumn";
            this.apaternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apaternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // amaternoDataGridViewTextBoxColumn
            // 
            this.amaternoDataGridViewTextBoxColumn.DataPropertyName = "A_materno";
            this.amaternoDataGridViewTextBoxColumn.HeaderText = "Aperllido Materno";
            this.amaternoDataGridViewTextBoxColumn.Name = "amaternoDataGridViewTextBoxColumn";
            this.amaternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.amaternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // telcasaDataGridViewTextBoxColumn
            // 
            this.telcasaDataGridViewTextBoxColumn.DataPropertyName = "Tel_casa";
            this.telcasaDataGridViewTextBoxColumn.HeaderText = "Teléfono Casa";
            this.telcasaDataGridViewTextBoxColumn.Name = "telcasaDataGridViewTextBoxColumn";
            this.telcasaDataGridViewTextBoxColumn.ReadOnly = true;
            this.telcasaDataGridViewTextBoxColumn.Width = 130;
            // 
            // telcelDataGridViewTextBoxColumn
            // 
            this.telcelDataGridViewTextBoxColumn.DataPropertyName = "Tel_cel";
            this.telcelDataGridViewTextBoxColumn.HeaderText = "Telefono Celular";
            this.telcelDataGridViewTextBoxColumn.Name = "telcelDataGridViewTextBoxColumn";
            this.telcelDataGridViewTextBoxColumn.ReadOnly = true;
            this.telcelDataGridViewTextBoxColumn.Width = 130;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E_mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Correo Electónico";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 210;
            // 
            // redDataGridViewTextBoxColumn
            // 
            this.redDataGridViewTextBoxColumn.DataPropertyName = "Red";
            this.redDataGridViewTextBoxColumn.HeaderText = "Red Social";
            this.redDataGridViewTextBoxColumn.Name = "redDataGridViewTextBoxColumn";
            this.redDataGridViewTextBoxColumn.ReadOnly = true;
            this.redDataGridViewTextBoxColumn.Width = 150;
            // 
            // perfilDataGridViewTextBoxColumn
            // 
            this.perfilDataGridViewTextBoxColumn.DataPropertyName = "Perfil";
            this.perfilDataGridViewTextBoxColumn.HeaderText = "Perfil";
            this.perfilDataGridViewTextBoxColumn.Name = "perfilDataGridViewTextBoxColumn";
            this.perfilDataGridViewTextBoxColumn.ReadOnly = true;
            this.perfilDataGridViewTextBoxColumn.Width = 150;
            // 
            // Profesores_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.datosAlumnos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profesores_a";
            this.Text = "Profesores_a";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresadminaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.DataGridView datosAlumnos;
        private System.Windows.Forms.BindingSource profesoresadminaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telcasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telcelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn redDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfilDataGridViewTextBoxColumn;
    }
}