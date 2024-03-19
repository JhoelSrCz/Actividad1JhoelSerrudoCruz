using Computadora.BSS;
using Computadora.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computadora.VISTA.ComputadoraVistas
{
    public partial class ComputadoraInsertarVista : Form
    {
        public ComputadoraInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdComputadoraSelecionada = 0;
        ComputadoraBss bss = new ComputadoraBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Computadoras computadoras = new Computadoras();
            computadoras.IdComputadora = IdComputadoraSelecionada;
            computadoras.Nombre = txtNombre.Text;
            computadoras.Descripcion = txtDescripcion.Text;
            computadoras.Precio = Convert.ToInt32(txtPrecio.Text);
            computadoras.FechaFabricacion = dateTimePicker1.Value;

            bss.InsertarComputadoraBss(computadoras);

            MessageBox.Show("Se guardo correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComputadoraListarVista fr = new ComputadoraListarVista();
            if(fr.ShowDialog() == DialogResult.OK)
            {
                Computadoras computadoras = bss.ObtenerIdBss(IdComputadoraSelecionada);
                txtIdPers.Text = computadoras.Nombre + " " + computadoras.Descripcion;
            }
        }
    }
}
