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

namespace Comida_DJZ
{
    public partial class Inicio : Form
    {
        ConexionBD BD = new ConexionBD();
        private Form estado;
        bool Cliente = true;
        public Inicio()
        {
            InitializeComponent();
            BD.btnProbarConexion_Click();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Cambiar el estado
            if (Cliente)
                Cliente = false;
            else
                Cliente = true;

            if(Cliente)
            {
                Contraseña.Visible = false;
                Titulo.Text = "Bienvenido";
                BotonAcceso.Text = "Iniciar";
            }
            else
            {
                Contraseña.Visible = true;
                Titulo.Text = "Iniciar Sesion";
                BotonAcceso.Text = "Acceder";
            }
        }

        private void BotonAcceso_Click(object sender, EventArgs e)
        {
            if(Cliente)
            {
                Acceder(new SistServicio("Inicio"));
            }
            else
            {
                if (Contraseña.Text == "admin1230")
                    Acceder(new SistAdministracion());
                else
                    MessageBox.Show("Contraseña Incorrecta");
            }
        }

        public void Ocultar()
        {
            Contraseña.Visible= false;
            Titulo.Visible = false;
            BotonAcceso.Visible = false;
            pictureBox1.Visible = false;
        }

        private void Acceder(Form f)
        {
            Ocultar();
            if (estado != null)
            {
                estado.Close();
            }
            estado = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            this.panel1.Dock = DockStyle.Fill;
            f.BringToFront();
            f.Show();
        }
    }
}
