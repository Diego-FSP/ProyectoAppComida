using Comida_DJZ.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comida_DJZ.PagServicio
{
    public partial class SeleccionarComida : Form
    {
        public SistServicio Padre;
        List<Pedido> Compra;
        public SeleccionarComida(SistServicio padre)
        {
            InitializeComponent();
            Padre = padre;
            BotonO();
            //Padre.B1.Visible = false;
            //Padre.B2.Visible = false;
        }
        private void BotonO()
        {
            Padre.B1.Size = new Size(80, 30);
            Padre.B2.Size = new Size(80, 30);
            Padre.B1.Location= new Point(Padre.B1.Location.X, Padre.Height-60);
            Padre.B2.Location = new Point(Padre.B2.Location.X, Padre.Height-60);
            //B1.= new Point(21);
        }
        Form Pagina;

        private void SeleccionarComida_SizeChanged(object sender, EventArgs e)
        {
            BotonO();
        }
    }
}
