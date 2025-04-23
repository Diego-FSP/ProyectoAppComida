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
        List<Pedido> Compra;
        Form Pag;
        public SistServicio(string nombre)
        {
            InitializeComponent();

            this.NEstado.Text = nombre;
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
            Pag.Show();
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
                case "Menu":
                    B1.Text = "Regresar";
                    B2.Text = "Siguiente";
                    B2.Visible = false;
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
            switch(NEstado.Text)
            {
                case "Inicio":
                    CambiarPagina(new SeleccionarComida(this));
                    NEstado.Text = "Menu";
                    BNombre();
                    break;
                case "Menu":
                    Pag.Close();
                    NEstado.Text = "Inicio";
                    BNombre();
                    break;
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            switch (NEstado.Text)
            {
                case "Inicio":
                    break;
                case "Menu":
                    if(Compra.Count>0)
                    {
                        Pag.Close();

                    }
                    break;
            }
        }
    }
}
