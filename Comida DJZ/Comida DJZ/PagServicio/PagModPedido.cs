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
        DataGridView ListaP;
        public PagModPedido(Pedido p, DataGridView Lista)
        {
            InitializeComponent();
            pedido = p;
            ListaP = Lista;
            Comida.Text = pedido.Comida.Nombre;
            Descripcion.Text = pedido.Comida.Descripcion;
            Cantidad.Text = pedido.Cantidad.ToString();
            IMG.Image = Image.FromFile(p.Comida.IMG.ToString());
            Precio();
        }

        private void Precio()
        {
            pedido.PrecioF = pedido.Comida.precio * pedido.Cantidad;
            PrecioT.Text = "$" + pedido.PrecioF.ToString();
        }

        private void MasC_Click(object sender, EventArgs e)
        {
            if(pedido.Cantidad<pedido.Comida.Cantidad)
            { 
                pedido.Cantidad++;
                Cantidad.Text = pedido.Cantidad.ToString();
                ListaP[1, pedido.dupla - 1].Value =pedido.Cantidad;
                MenosC.Visible = true;
                Precio();
            }
            if (pedido.Cantidad == pedido.Comida.Cantidad)
                MasC.Visible = false;
        }

        private void MenosC_Click(object sender, EventArgs e)
        {
            MasC.Visible = true;
            if (pedido.Cantidad > 0)
            {
                pedido.Cantidad--;
                if (pedido.Cantidad == 0)
                    MenosC.Visible = false;
                Cantidad.Text = pedido.Cantidad.ToString();
                ListaP[1, pedido.dupla - 1].Value = pedido.Cantidad;
            }
            Precio();
        }

        private void Tamaño(object sender, EventArgs e)
        {
            IMG.Width =this.Width/2;
            Descripcion.Width = this.Width / 2;
            Descripcion.Height = this.Height / 4;

            TX2.Location = new Point(TX2.Location.X, Descripcion.Location.Y + Descripcion.Height + this.Height / 10);
            PrecioT.Location= new Point(PrecioT.Location.X, Descripcion.Location.Y + Descripcion.Height + this.Height / 10);

            TX1.Location = new Point(TX1.Location.X, TX2.Location.Y + TX2.Height + this.Height / 10);
            MasC.Location = new Point(MasC.Location.X, TX2.Location.Y + TX2.Height + this.Height / 10);
            MenosC.Location = new Point(MenosC.Location.X, TX2.Location.Y + TX2.Height + this.Height / 10);
            Cantidad.Location = new Point(Cantidad.Location.X, TX2.Location.Y + TX2.Height + this.Height / 10);
        }
    }
}
