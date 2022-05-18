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
    public partial class Sistema_A : Form
    {
        public Sistema_A()
        {
            InitializeComponent();
        }
        public void abrirform(object fromhija)
        {
            if (this.contenido.Controls.Count > 0)
                this.contenido.Controls.RemoveAt(0);
            Form fh = fromhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenido.Controls.Add(fh);
            this.contenido.Tag = fh;
            fh.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirform(new Alumnos_a());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirform(new Profesores_a());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirform(new Pagos_admin());
        }
    }
}
