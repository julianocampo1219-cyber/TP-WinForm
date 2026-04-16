using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            lwElementos.Items.Add(elemento);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("ROJO");
            cboColorFavorito.Items.Add("NEGRO");
            cboColorFavorito.Items.Add("AZUL");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            // OPERADOR TERNARIO
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";

            string tipo;
            if (rbtMaggle.Checked)
                tipo = "Muggle";
            else if (rbtWizzard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string perfil = (chocolate  +", es tipo " + tipo + ", color fav "+ colorFavorito + ", numero fav " + numeroFavorito);
            MessageBox.Show("Su nombre es " + nombre +", Fecha nac" + fecha + ", "+ perfil);

        }
    }
}
