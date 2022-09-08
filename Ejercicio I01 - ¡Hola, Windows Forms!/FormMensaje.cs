using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I01____Hola__Windows_Forms_
{
    public partial class FormMensaje : Form
    {
        public FormMensaje(string nombre, string apellido)
        {
            InitializeComponent();

            lblBienvenida.Text = "¡Hola, Windows Form!";

            lblMensaje.Text = $"Soy {nombre} {apellido}";

        }

    }
}
