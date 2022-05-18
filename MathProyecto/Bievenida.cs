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
    public partial class Bievenida : Form
    {
        public Bievenida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text != "") && (txtPass.Text != ""))
            {
                if (txtUser.Text == "Administrador" && txtPass.Text == "pass")
                {
                    Sistema_A abrir = new Sistema_A();
                    abrir.ShowDialog();
                    this.Close();
                }
                else if (txtUser.Text == "Invitado" && txtPass.Text == "pass")
                {
                    this.Close();
                } else
                {
                    
                    MessageBox.Show("Contraseña incorrecta");
                    txtUser.Text = "";
                    txtPass.Text = "";
                    
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
            }
        }
    }
}
