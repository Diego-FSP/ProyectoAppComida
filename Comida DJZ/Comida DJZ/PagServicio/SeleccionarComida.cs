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
        
        public SeleccionarComida(SistServicio p)
        {
            InitializeComponent();
            Padre = p;
            p.estado = new ServSeleccionarComida();
            BD();
            MostrarComida();
            MostrarListaP();
            //ListaC.Columns["IMG"].DefaultCellStyle = DataGridViewImageCellLayout.Zoom;

        }

        void MostrarComida()
        {
            foreach(MenuOBJ c in comidas)
            {
                c.IMG= @"IMG\Comidas\IDComida " + c.IDComida + ".png";
                ListaC.Rows.Add
                    (
                        c.IDComida,
                        c.IMG,
                        c.Nombre,
                        c.Cantidad,
                        "$" + c.precio,
                        c.Descripcion
                );
                ListaC.Rows[c.IDComida-1].Height = 200;

            }
        }

        private void MostrarListaP()
        {
            int d = 1;
            if (Padre.Compra != null)
                foreach (Pedido p in Padre.Compra)
                {
                    p.dupla = d;
                    Padre.ListaPP.Rows.Add(
                        p.Comida.IMG,
                        p.Cantidad
                        );
                    d++;
                    Padre.ListaPP.Rows[p.dupla - 1].Height = 100;
                }
            
        }

        Form Pagina;
        private void ListaCOP()
        {
            for (int t = 5; t > 1; t--)
            {
                ListaC.Columns[t].Width = (ListaC.Width - 70) / 6;
            }
            ListaC.Columns[1].Width = (ListaC.Width-70) / 3;

            float c = (ListaC.Width / 76) ;
            if(c>0)
            ListaC.RowsDefaultCellStyle.Font = new System.Drawing.Font(ListaC.RowsDefaultCellStyle.Font.Name, c, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
        }

        
        private void SeleccionarComida_SizeChanged(object sender, EventArgs e)
        {
            ListaCOP();
        }//DataGridViewCellStyle { BackColor=Color [Beige], ForeColor=Color [A=255, R=192, G=64, B=0], SelectionBackColor=Color [A=255, R=243, G=198, B=35], Font=[Font: Name=Lucida Handwriting, Size=8.25, Units=3, GdiCharSet=0, GdiVerticalFont=False], Alignment=MiddleCenter } Microsoft YaHei


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

        private void ListaC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (MenuOBJ c in comidas)
                if (c.IDComida == Convert.ToInt32(ListaC[0, e.RowIndex].Value) )
                {
                    Pedido p = new Pedido();
                    p.Comida = c;
                    p.IDPedido = 1;
                    p.PrecioF = c.precio;
                    p.dupla = 0;
                    byte condicion = 0;
                    if (Padre.Compra != null)
                        foreach (var co in Padre.Compra)
                            if (co.Comida.IDComida == c.IDComida)
                                condicion++;

                    if (condicion==0)
                                Padre.Compra.Add(p);
                }
            
            Padre.ListaPP.Rows.Clear();
            Padre.ListaPP.ClearSelection();
            Padre.ListaPP.Visible = true;
            MostrarListaP();
            Padre.B1.Visible = true;
            Padre.B2.Visible = true;
        }
        void BD()
        {
            var c1 = new MenuOBJ()
            {
                Nombre = "Empanadas",
                IDComida = 1,
                Cantidad = 30,
                precio = 10000.00,
                Descripcion = "Carne cortada"
            };
            var c2 = new MenuOBJ()
            {
                Nombre = "Pollo Broster",
                IDComida = 2,
                Cantidad = 2,
                precio = 123823.23,
                Descripcion = "Crujiente y jugoso"
            };
            var c3 = new MenuOBJ()
            {
                Nombre = "Hamburguesa",
                IDComida = 3,
                Cantidad = 1,
                precio = 23124.1,
                Descripcion = "Clásica con queso"
            };
            var c4 = new MenuOBJ()
            {
                Nombre = "Salchipapa",
                IDComida = 4,
                Cantidad = 4,
                precio = 21431.32,
                Descripcion = "Con salsa o sin salsa"
            };
            var c5 = new MenuOBJ()
            {
                Nombre = "Milanesa con pure",
                IDComida = 5,
                Cantidad = 4,
                precio = 21431.32,
                Descripcion = "Con salsa o sin salsa"
            };

            comidas.Add(c1);
            comidas.Add(c2);
            comidas.Add(c3);
            comidas.Add(c4);
            comidas.Add(c5);
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