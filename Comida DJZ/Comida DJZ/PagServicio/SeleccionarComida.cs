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
    public partial class SeleccionarComida : Form
    {
        public SistServicio Padre;
        public List<MenuOBJ> comidas = new List<MenuOBJ>();
        public SeleccionarComida(SistServicio padre)
        {
            InitializeComponent();
            Padre = padre;
            BotonO();
            var c1 = new MenuOBJ()
            {
                Nombre = "Pollo",
                IDComida = 1,
                Cantidad = 2,
                precio = 10000.00,
                Descripcion="es rico"
            };
            var c2 = new MenuOBJ()
            {
                Nombre = "Fideos",
                IDComida = 1,
                Cantidad = 2,
                precio = 123823.23,
                Descripcion = "aceitoso"
            };
            var c3 = new MenuOBJ()
            {
                Nombre = "Asado",
                IDComida = 1,
                Cantidad = 1,
                precio = 23124.1,
                Descripcion = "es rico"
            };
            var c4 = new MenuOBJ()
            {
                Nombre = "Pollo a la brasa",
                IDComida = 1,
                Cantidad = 4,
                precio = 21431.32,
                Descripcion = "es rico"
            };

            
            comidas.Add(c1);
            comidas.Add(c2);
            comidas.Add(c3);
            comidas.Add(c4);
            //Padre.B1.Visible = false;
            //Padre.B2.Visible = false;
            MostrarComida();
        }

        void MostrarComida()
        {
            foreach(MenuOBJ c in comidas)
            {
                object imagen = @"IMG\Comidas\IDComida 2.png";
                ListaC.Rows.Add
                    (
                        imagen,
                        c.Nombre,
                        c.Cantidad,
                        c.precio,
                        c.Descripcion
                );
                
            }
        }

        private void BotonO()
        {
            Padre.B1.Size = new Size(80, 30);
            Padre.B2.Size = new Size(80, 30);
            Padre.B1.Location= new Point(Padre.B1.Location.X, Padre.Height-60);
            Padre.B2.Location = new Point(Padre.B2.Location.X, Padre.Height-60);
            //B1.= new Point(21);
        }
        Form Pagina;

        private void SeleccionarComida_SizeChanged(object sender, EventArgs e)
        {
            BotonO();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ImagenC(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.ListaC.Columns[e.ColumnIndex].Name)
            {
                case "Imagen":
                    if(e.Value!=null)
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch(System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    break;
            }
                
        }
    }
}
