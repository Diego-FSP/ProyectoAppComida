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
    public class ModfP: EstadoServ
    {
        public override void posicion(SistServicio s)
        {
            s.B1.Location = new Point(s.B1.Location.X, s.Height - 150);
            s.B2.Location = new Point(s.B2.Location.X, s.Height - 150);
            s.B1.Size = new Size(80, 30);
            s.B2.Size = new Size(80, 30);
        }

        public override void CPedido(SistServicio s, DataGridViewCellEventArgs e)
        {
            s.CambiarPagina(new PagModPedido(s.Compra[e.RowIndex], s.ListaPP));
            
        }
    }
}
