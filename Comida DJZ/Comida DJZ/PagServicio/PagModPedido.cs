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
    public partial class PagModPedido : Form
    {
        Pedido pedido;
        SistServicio padre;
        public PagModPedido(Pedido p, SistServicio s)
        {
            InitializeComponent();
            pedido = p;
            Comida.Text = pedido.Comida.Nombre;
            Descripcion.Text = pedido.Comida.Descripcion;
            Cantidad.Text= pedido.Cantidad.ToString();
            padre = s;
        }
        public PagModPedido(Pedido p)
        {
            InitializeComponent();
            pedido = p;
            Comida.Text = pedido.Comida.Nombre;
            Descripcion.Text = pedido.Comida.Descripcion;
            Cantidad.Text = pedido.Cantidad.ToString();
        }

        private void MasC_Click(object sender, EventArgs e)
        {
            pedido.Cantidad++;
            Cantidad.Text = pedido.Cantidad.ToString();
        }

        private void MenosC_Click(object sender, EventArgs e)
        {
            if (pedido.Cantidad > 0)
            {
                pedido.Cantidad--;
                if (pedido.Cantidad == 0)
                    MenosC.Visible = false;
                Cantidad.Text = pedido.Cantidad.ToString();
            }
        }

    }
}
