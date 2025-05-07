using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_DJZ.Clases
{
    public class ServSeleccionarComida:EstadoServ
    {
        public override void posicion(SistServicio s)
        {
            s.B1.Location = new Point(s.B1.Location.X, s.Height - 150);
            s.B2.Location = new Point(s.B2.Location.X, s.Height - 60);
            s.B1.Size = new Size(80, 30);
            s.B2.Size = new Size(80, 30);
        }
        public override void interaccionb1(SistServicio s)
        {
            s.B1.Text = "Pedir Comida";
            s.B2.Text = "Calificar";
            s.B2.Visible = true;
            s.B1.Size = new Size(184, 134);
            s.B2.Size = new Size(184, 134);
            s.Compra= null;
            s.ListaPP.Visible = false;
            s.estado = new ServiInicio();
            s.CerrarPagina();
            s.estado.posicion(s);
        }
    }
}
