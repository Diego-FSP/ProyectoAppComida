using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_DJZ.Clases
{
    public class Pedido
    {
        public int IDPedido;
        public string Nombre;
        public string Apellido;
        public int IDComida;
        public int Cantidad=0;
        public bool Llevar=false;
        public string Descripcion;
    }
}
