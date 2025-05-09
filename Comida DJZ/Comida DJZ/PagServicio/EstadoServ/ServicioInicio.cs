using Comida_DJZ.PagServicio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_DJZ.Clases
{
    public class ServiInicio:EstadoServ
    {
        public override void posicion(SistServicio s)
        {
            s.B1.Location = new System.Drawing.Point((s.Width / 2) - 200,(s.Height / 2) - 100);
            s.B2.Location = new System.Drawing.Point((s.Width / 2) + 40, (s.Height / 2) - 100);
        }

        public override void interaccionb1(SistServicio s)
        {
            s.CambiarPagina(new SeleccionarComida(s));
            s.NEstado.Text = "Menu";
            s.B1.Text = "Regresar";
            s.B2.Text = "Realizar Pedido";
            s.B2.Visible = false;
        }
    }
}
