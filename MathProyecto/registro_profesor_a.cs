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
    public partial class registro_profesor_a : Form
    {
        public registro_profesor_a()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            profesores_admin_a _newreg = new profesores_admin_a();
            _newreg.Nombre = txtNombre.Text;
            _newreg.A_paterno = txtPaterno.Text;
            _newreg.A_materno = txtMaterno.Text;
            _newreg.Tel_casa = txtCasa.Text;
            _newreg.Tel_cel = txtCelular.Text;
            _newreg.E_mail = txtE_mail.Text;
            _newreg.Red = txtRed.Text;
            _newreg.Perfil = txtPerfil.Text;

            CtrlProfesores_admin reg = new CtrlProfesores_admin();

            if (txtId.Text != "")
            {
                _newreg.Id = int.Parse(txtId.Text);
                bandera = reg.actualizar(_newreg);
            }
            else
            {
                bandera = reg.insertar(_newreg);
            }
            if (bandera)
            {
                MessageBox.Show("Registro guardado");
                limpiar();
            }
        }
        private void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtCasa.Text = "";
            txtCelular.Text = "";
            txtE_mail.Text = "";
            txtRed.Text = "";
            txtPerfil.Text = "";
        }
    }
}
