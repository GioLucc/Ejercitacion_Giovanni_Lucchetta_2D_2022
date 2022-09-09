using System.Windows.Forms;

namespace Ejercicio_I01____Hola__Windows_Forms_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(CargaCorrecta())
            {
                FormMensaje form1 = new FormMensaje(txtNombre.Text, txtApellido.Text, cboMaterias.Text);
                form1.ShowDialog();
            }
        }

        private bool CargaCorrecta()
        {
            bool resultado = true;
            string mensaje = "Se deben completar los siguientes campos:";

            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                mensaje += "\n-Nombre";
                resultado = false;
            }
            if (String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                resultado = false;
                mensaje += "\n-Apellido";
            }
            if(cboMaterias.SelectedIndex < 0)
            {
                mensaje += "\n-Materia Favorita";
                resultado = false;
            }


            if(!resultado)
            {
                MessageBox.Show(mensaje,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboMaterias.Text = "Programacion I";

            cboMaterias.Items.Add("Programacion I");
            cboMaterias.Items.Add("Laboratorio I");
            cboMaterias.Items.Add("Programación II");
            cboMaterias.Items.Add("Laboratorio II");
        }

        private bool verificarCarga()
        {
            bool verificar;

            verificar = true;

            foreach (Control item in this.Controls)
            {
                if(item is TextBox && string.IsNullOrEmpty(item.Text))
                {
                    verificar = false;
                    break;
                }
            }

            return verificar;
        }


    }
}