using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MathProyecto
{
    public partial class Alumnos_a : Form
    {
        public Alumnos_a()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void cargarTabla(string dato)
        {
            List<alumnos_admin> lista = new List<alumnos_admin>();
            CtrlAlumnos_admin _ctrlAlumnos = new CtrlAlumnos_admin();
            datosAlumnos.DataSource = _ctrlAlumnos.consulta(dato);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Salir", MessageBoxButtons.YesNoCancel);

            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(datosAlumnos.CurrentRow.Cells[0].Value.ToString());
                CtrlAlumnos_admin _eliminar = new CtrlAlumnos_admin();
                bandera = _eliminar.eliminar(id);
                if (bandera)
                {
                    MessageBox.Show("Registro Eliminado");
                    cargarTabla(null);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro_alumnos_a newreg_a = new registro_alumnos_a();
            newreg_a.ShowDialog();
        }


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string dato = txtDato.Text;
            cargarTabla(dato);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registro_alumnos_a mod = new registro_alumnos_a();
            mod.txtId.Text = datosAlumnos.CurrentRow.Cells[0].Value.ToString();
            mod.txtNombre.Text = datosAlumnos.CurrentRow.Cells[1].Value.ToString();
            mod.txtPaterno.Text = datosAlumnos.CurrentRow.Cells[2].Value.ToString();
            mod.txtMaterno.Text = datosAlumnos.CurrentRow.Cells[3].Value.ToString();
            mod.txtCasa.Text = datosAlumnos.CurrentRow.Cells[4].Value.ToString();
            mod.txtCelular.Text = datosAlumnos.CurrentRow.Cells[5].Value.ToString();
            mod.txtE_mail.Text = datosAlumnos.CurrentRow.Cells[6].Value.ToString();
            mod.txtRed.Text = datosAlumnos.CurrentRow.Cells[7].Value.ToString();
            mod.txtPerfil.Text = datosAlumnos.CurrentRow.Cells[8].Value.ToString();
            mod.txtComentario.Text = datosAlumnos.CurrentRow.Cells[9].Value.ToString();
            mod.ShowDialog();
        }
    }
}
