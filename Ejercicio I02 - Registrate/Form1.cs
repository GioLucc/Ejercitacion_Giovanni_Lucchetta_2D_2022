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
        string sexo = "No binario";
        string cursos = String.Empty;

        if (chkCSharp.Checked)
        {
            cursos += "\nC#\n";
            //cursos += Environment.NewLine;
        }
        if(chkCplusplus.Checked)
        {
            cursos += "C++\n";
        }
        if(chkJavaScript.Checked)
        {
            cursos += "JavaScript\n";
        }

        if(radFemale.Checked)
        {
            sexo = "Femenino";
        }
        else
        {
            if(radMale.Checked)
            {
                sexo = "Masculino";

            }
        }

        Ingresante ingresante = new Ingresante(txtNombre.Text,txtDireccion.Text,(int)nudEdad.Value,sexo,lstPaises.Text, cursos);

        MessageBox.Show( ingresante.Mostrar());
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}