using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comida_DJZ.Clases
{
    public abstract class EstadoServ
    {
        public virtual void interaccionb1(SistServicio s)
        { }
        public virtual void interaccionb2(SistServicio s)
        { }
        public virtual void posicion(SistServicio s)
        { }

        public virtual void CPedido(SistServicio s, DataGridViewCellEventArgs e)
        { }
    }
}
