namespace Ejercicio_I02___Registrate;
using BibliotecaRegistrate;
using System.Collections;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        lstPaises.Items.Add("Argentina");
        lstPaises.Items.Add("Chile");
        lstPaises.Items.Add("Uruguay");
    }

    private void btnIngresar_Click(object sender, EventArgs e)
    {
        if(VerificarTextBox())
        {
            Ingresante ingresante = new Ingresante(txtNombre.Text, txtDireccion.Text, (int)nudEdad.Value, VerificarGenero(), lstPaises.Text, VerificarCursos());

            MessageBox.Show(ingresante.Mostrar());
        }
        else
        {
            MessageBox.Show("Carga erronea de datos, verifique.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }

    private string[] VerificarCursos()
    {
        string[] cursos = new string[gbCursos.Controls.Count];
        int index = 0;

        foreach (CheckBox item in gbCursos.Controls)
        {
            if(item.Checked)
            {
                cursos[index] = item.Text;
                index++;
            }
        }

        return cursos;
    }

    private string VerificarGenero()
    {
        string genero = string.Empty;

        foreach (RadioButton item in gbGenero.Controls)
        {
            if(item.Checked)
            {
                genero = item.Text;
            }
        }
        return genero;
    }

    private bool verificarCarga()
    {
        bool verificar;

        verificar = true;

        foreach (Control item in this.Controls)
        {
            if (item is TextBox && string.IsNullOrEmpty(item.Text))
            {
                verificar = false;
                break;
            }
        }

        return verificar;
    }

    private bool VerificarTextBox()
    {
        bool verificar;

        verificar = true;

        foreach (Control item in gbDatos.Controls)
        {
            if (item is TextBox && string.IsNullOrEmpty(item.Text))
            {
                verificar = false;
                break;
            }
        }

        return verificar;
    }


}