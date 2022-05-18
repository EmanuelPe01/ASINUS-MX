using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProyecto
{
    public partial class Profesores_a : Form
    {
        public Profesores_a()
        {
            InitializeComponent();
            cargarTabla(null);
        }
        private void cargarTabla(string dato)
        {
            List<profesores_admin_a> lista = new List<profesores_admin_a>();
            CtrlProfesores_admin _ctrlAlumnos = new CtrlProfesores_admin();
            datosAlumnos.DataSource = _ctrlAlumnos.consulta(dato);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text;
            cargarTabla(dato);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            registro_profesor_a _newreg = new registro_profesor_a();
            _newreg.ShowDialog();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            registro_profesor_a mod = new registro_profesor_a();
            mod.txtId.Text = datosAlumnos.CurrentRow.Cells[0].Value.ToString();
            mod.txtNombre.Text = datosAlumnos.CurrentRow.Cells[1].Value.ToString();
            mod.txtPaterno.Text = datosAlumnos.CurrentRow.Cells[2].Value.ToString();
            mod.txtMaterno.Text = datosAlumnos.CurrentRow.Cells[3].Value.ToString();
            mod.txtCasa.Text = datosAlumnos.CurrentRow.Cells[4].Value.ToString();
            mod.txtCelular.Text = datosAlumnos.CurrentRow.Cells[5].Value.ToString();
            mod.txtE_mail.Text = datosAlumnos.CurrentRow.Cells[6].Value.ToString();
            mod.txtRed.Text = datosAlumnos.CurrentRow.Cells[7].Value.ToString();
            mod.txtPerfil.Text = datosAlumnos.CurrentRow.Cells[8].Value.ToString();
            mod.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Salir", MessageBoxButtons.YesNoCancel);

            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(datosAlumnos.CurrentRow.Cells[0].Value.ToString());
                CtrlProfesores_admin _eliminar = new CtrlProfesores_admin();
                bandera = _eliminar.eliminar(id);
                if (bandera)
                {
                    MessageBox.Show("Registro Eliminado");
                    cargarTabla(null);
                }
            }
        }
    }
}
