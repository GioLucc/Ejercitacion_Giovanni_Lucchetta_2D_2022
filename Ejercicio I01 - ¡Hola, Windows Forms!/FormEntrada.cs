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
            string nombreIngresado;
            string apellidoIngresado;
            string materiaFavorita;
            string mensaje;

            nombreIngresado = txtNombre.Text;
            apellidoIngresado = txtApellido.Text;
            materiaFavorita = cboMaterias.Text;
            

            //TOP TIER GOD GODEANO GOD
            if(String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                mensaje = "Se deben completar los siguientes campos:\nNombre";

                if(String.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    mensaje += "\nApellido";
                }
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(String.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    mensaje = "Se deben completar los siguientes campos:\nApellido";

                    if (String.IsNullOrWhiteSpace(txtNombre.Text))
                    {
                        mensaje += "\nNombre";
                    }
                    MessageBox.Show(mensaje,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    FormMensaje form2 = new FormMensaje(nombreIngresado, apellidoIngresado, materiaFavorita);
                    form2.ShowDialog();
                }
            }


            //if(String.IsNullOrWhiteSpace(txtNombre.Text) && String.IsNullOrWhiteSpace(txtApellido.Text))
            //{
            //    string mensaje;

            //    mensaje = "Se deben completar los siguientes campos:\nNombre";
            //}
            //else
            //{
            //    if
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboMaterias.Text = "Programacion I";

            cboMaterias.Items.Add("Programacion I");
            cboMaterias.Items.Add("Laboratorio I");
            cboMaterias.Items.Add("Programación II");
            cboMaterias.Items.Add("Laboratorio II");
        }
    }
}