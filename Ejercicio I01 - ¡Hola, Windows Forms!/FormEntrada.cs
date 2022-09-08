namespace Ejercicio_I01____Hola__Windows_Forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string nombreIngresado;
            string apellidoIngresado;

            nombreIngresado = txtNombre.Text;
            apellidoIngresado = txtApellido.Text;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreIngresado;
            string apellidoIngresado;

            nombreIngresado = txtNombre.Text;
            apellidoIngresado = txtApellido.Text;

            FormMensaje form2 = new FormMensaje(nombreIngresado,apellidoIngresado);
            form2.ShowDialog();
        }
    }
}