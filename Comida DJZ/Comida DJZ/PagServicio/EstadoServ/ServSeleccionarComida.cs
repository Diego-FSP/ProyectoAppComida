using Comida_DJZ.PagServicio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comida_DJZ.Clases
{
    public class ServSeleccionarComida:EstadoServ
    {
        public override void posicion(SistServicio s)
        {
            s.B1.Location = new Point(s.B1.Location.X, s.Height - 150);
            s.B2.Location = new Point(s.B2.Location.X, s.Height - 150);
            s.B1.Size = new Size(80, 30);
            s.B2.Size = new Size(80, 30);
        }
        public override void interaccionb1(SistServicio s)
        {
            s.Compra = new List<Pedido>();
            s.B1.Text = "Pedir Comida";
            s.B2.Text = "B2";
            s.B2.Visible = false;
            s.B1.Size = new Size(184, 134);
            s.B2.Size = new Size(184, 134);
            s.ListaPP.Visible = false;
            s.estado = new ServiInicio();
            s.CerrarPagina();
            s.estado.posicion(s);
        }

        public override void interaccionb2(SistServicio s)
        {
            s.CambiarPagina(new PagModPedido(s.Compra[0],s.ListaPP));
            s.NEstado.Text = "Seleccion";
            s.B1.Text = "Regresar";
            s.B2.Text = "Pagar";
            s.B2.Visible = true;
            s.estado = new ModfP();
        }

        public override void CPedido(SistServicio s, DataGridViewCellEventArgs e)
        {
            s.Compra.Remove(s.Compra[e.RowIndex]);
            s.MostrarListaP();
        }
    }
}
