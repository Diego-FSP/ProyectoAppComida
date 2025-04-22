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
            Comida.Text = pedido.Nombre;
            Descripcion.Text = pedido.Descripcion;
            Cantidad.Text= pedido.Cantidad.ToString();
            padre = s;
        }
        public PagModPedido(Pedido p)
        {
            InitializeComponent();
            pedido = p;
            Comida.Text = pedido.Nombre;
            Descripcion.Text = pedido.Descripcion;
            Cantidad.Text = pedido.Cantidad.ToString();
        }
        public void Guardar()
        {
            if (Llevar.Text == "Si")
                pedido.Llevar = true;
            else
                pedido.Llevar = false;
        }

        private void MasC_Click(object sender, EventArgs e)
        {
            pedido.Cantidad++;
            Cantidad.Text = pedido.Cantidad.ToString();
        }

        private void MenosC_Click(object sender, EventArgs e)
        {
            pedido.Cantidad--;
            Cantidad.Text = pedido.Cantidad.ToString();
        }

        private void Llevar_Click(object sender, EventArgs e)
        {
            if(pedido.Llevar)
            {
                Llevar.Text = "No";
                pedido.Llevar = false;
            }
            else
            {
                Llevar.Text = "Si";
                pedido.Llevar = true;
            }
        }
    }
}
