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

        

        private void B1_Click(object sender, EventArgs e)
        {
            switch(NEstado.Text)
            {
                case "Inicio":
                    CambiarPagina(new SeleccionarComida(this));
                    NEstado.Text = "Lista de Comidas";
                    break;
            }
        }
    }
}
