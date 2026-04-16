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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal() //vetnana principal "Padre"
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms) //Foreach es un for , para recorrer colecciones de objetos 
            {
                if (item.GetType() == typeof(Form1)) // aca estamos validando que si el typeof es igual al GetTupe termine la accion con el return.
                {
                    MessageBox.Show("Ya existe una venta abierta termine de trabar alli...");
                    return;
                    //validacion para que nose abran mas de un mismo tipo de ventana en el dentro de la App Padre. 
                }
            }  


            Form1 ventana = new Form1(); //intaciamos el objeto from1 para poder usar la vetana perfil dentro de la ventana "padre"
            ventana.MdiParent = this; // creamos la venta "Padre" done vamos a crear mas ventanas hijas que funcionen a partir de esta
            ventana.Show(); // mostramos la ventana hija 
            // ventana.ShowDialog(); para crear una ventana emergente fuera de la ventana  principal
        }
    }
}
