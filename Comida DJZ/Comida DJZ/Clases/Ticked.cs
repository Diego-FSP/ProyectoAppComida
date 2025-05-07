using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_DJZ.Clases
{
    internal class Ticked
    {
        int IDTicked;
        int IDPedido;
        List<Pedido> Compra;
        double PrecioTotal;
        public string Nombre;
        public string Apellido;
        public bool Llevar = false;
        DateTime DetalleC;
    }
}
