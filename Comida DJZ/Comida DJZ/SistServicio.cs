using Comida_DJZ.Clases;
using Comida_DJZ.PagServicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comida_DJZ
{
    public partial class SistServicio : Form
    {
        public List<Pedido> Compra= new List<Pedido>();
        Form Pag;
        public EstadoServ estado = new ServiInicio();
        public SistServicio(string nombre)
        {
            InitializeComponent();

            this.NEstado.Text = nombre;
            ListaPP.Visible = false;
            estado.posicion(this);
        }

        public void CambiarPagina(Form p)
        {
            if (Pag != null)
            {
                Pag.Close();
            }
            Pag = p;
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            p.Dock = DockStyle.Fill;
            this.Pagina.Controls.Add(p);
            this.Pagina.Tag = p;
            this.Pagina.Dock = DockStyle.Fill;
            p.BringToFront();
            estado.posicion(this);
            Pag.Show();
        }

        public void CerrarPagina()
        {
            if (Pag != null)
            {
                Pag.Close();
            }
        }


        void BNombre()
        {
            switch(this.NEstado.Text)
            {
                case "Inicio":
                    B1.Text = "Pedir Comida";
                    B2.Text = "Calificar";
                    B2.Visible = true;
                    B1.Size = new Size(184, 134);
                    B2.Size = new Size(184, 134);
                    B1.Location = new Point(152, 226);
                    B2.Location = new Point(498, 226);
                    break;
                
                case "Pedido":
                    B1.Text = "Regresar";
                    B2.Text = "Confimar ";
                    B2.Visible = false;
                    break;
                case "Pago":
                    B1.Text = "Regresar;";
                    B2.Text = "Confirmar;";
                    B2.Visible = false;
                    break;
            }

        }

        private void B1_Click(object sender, EventArgs e)
        {
            estado.interaccionb1(this);
            
        }

        private void B2_Click(object sender, EventArgs e)
        {
            estado.interaccionb2(this);
        }

        private void ImagenC(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (this.ListaPP.Columns[e.ColumnIndex].Name)
            {
                case "Imagen":
                    if (e.Value != null)
                        try
                        {
                            e.Value = System.Drawing.Image.FromFile(e.Value.ToString());

                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    break;
            }

        }

        private void SistServicio_Load(object sender, EventArgs e)
        {

        }

        private void Tamaño(object sender, EventArgs e)
        {
            estado.posicion(this);
        }

        private void EleccionP(object sender, DataGridViewCellEventArgs e)
        {
            estado.CPedido(this,e);
        }

        public void MostrarListaP()
        {
            ListaPP.Rows.Clear();
            int d = 1;
            if (Compra != null)
                foreach (Pedido p in Compra)
                {
                    p.dupla = d;
                    ListaPP.Rows.Add(
                        p.Comida.IMG,
                        p.Cantidad
                        );
                    d++;
                    ListaPP.Rows[p.dupla - 1].Height = 100;
                }

        }
    }
}
