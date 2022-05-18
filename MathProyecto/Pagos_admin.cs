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
    public partial class Pagos_admin : Form
    {
        public Pagos_admin()
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text;
            cargarTabla(dato);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            regirstro_pago_a dato = new regirstro_pago_a();
            dato.lbNombre.Text = datosAlumnos.CurrentRow.Cells[1].Value.ToString() + " " + datosAlumnos.CurrentRow.Cells[2].Value.ToString() + " " + datosAlumnos.CurrentRow.Cells[3].Value.ToString();
            dato.ShowDialog();
        }
    }
}
