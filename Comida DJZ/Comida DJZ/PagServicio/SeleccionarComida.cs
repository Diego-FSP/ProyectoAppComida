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
using static System.Net.Mime.MediaTypeNames;

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
                IDComida = 2,
                Cantidad = 2,
                precio = 123823.23,
                Descripcion = "aceitoso"
            };
            var c3 = new MenuOBJ()
            {
                Nombre = "Asado",
                IDComida = 3,
                Cantidad = 1,
                precio = 23124.1,
                Descripcion = "es rico"
            };
            var c4 = new MenuOBJ()
            {
                Nombre = "Pollo a la brasa",
                IDComida = 4,
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
            //ListaC.Columns["IMG"].DefaultCellStyle = DataGridViewImageCellLayout.Zoom;
        }

        void MostrarComida()
        {
            foreach(MenuOBJ c in comidas)
            {
                object imagen = @"IMG\Comidas\IDComida "+c.IDComida+".png";
                ListaC.Rows.Add
                    (
                        imagen,
                        c.Nombre,
                        c.Cantidad,
                        c.precio,
                        c.Descripcion
                );
                ListaC.Rows[c.IDComida-1].Height = 200;

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
            for(int t= comidas.Count(); t>0;t--)
            {
                ListaC.Columns[t].Width = ListaC.Width/6;
            }
            ListaC.Columns[0].Width = ListaC.Width / 4;
            float c = ListaC.Width/76;
            ListaC.DefaultCellStyle.Font = new Font(ListaC.DefaultCellStyle.Font.SystemFontName,c);
        }//[Font: Name=Microsoft Sans Serif, Size=8.25, Units=3, GdiCharSet=1, GdiVerticalFont=False]


        private void ImagenC(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.ListaC.Columns[e.ColumnIndex].Name)
            {
                case "Imagen":
                    if(e.Value!=null)
                        try
                        {
                            e.Value = System.Drawing.Image.FromFile(e.Value.ToString());
                            
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
/*
private void CargarPNG(object sender, DataGridViewCellPaintingEventArgs e)
{
    if (e.ColumnIndex >= 0 && this.ListaC.Columns[e.ColumnIndex].Name == "IMG" && e.RowIndex >= 0)
    {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);
        Icon i = new Icon(imagen.ToString());
        e.Graphics.DrawIcon(i, , 30);
    }
}
*/