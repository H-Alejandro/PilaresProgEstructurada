using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaresProgEstructurada
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void frmDatosPersonales_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Estructura secuencial
            String saludo = " "; //cadena de caracteres
            saludo = this.txtNombres.Text + " " + this.txtApellidos.Text;
            MessageBox.Show("Hola: " + this.txtApellidos.Text + " " + this.txtNombres.Text);

            //Estructura repetitiva 
            string aux = "";
            for (int i=1; i<=10; i++)
            {

                aux = aux + saludo + System.Environment.NewLine;

            }

            this.txtResultados.Text = aux;

            //Estructura selectiva (condicional)

            int a = 100;
            int b = 20;
            if (a > b)

                aux = aux + "a mayor b";
            else
                aux = aux + "b mayor a";

            this.txtResultados.Text = aux;
            this.getSaludos(saludo); // Llamada a la función
            this.lblNombres.Text = lblNombres.Text + " --> " + this.getCalculos(a, b).ToString();
        }

        // Procedimientos - Funciones
        //Las funciones devuelve valores.
        //El procedimiento es una función que no devuelve valores.
        void getSaludos(string nombres)
        {
            this.lblNombres.Text = "Uso de función que no vuelve valor (" + nombres + ")";

        }

        //Función que vuelve el valor

        double getCalculos(int a, int b)
        {

            double resul = 0;
            resul = (a * 10) / (b * 2.5);

            return resul;


        }

    }
}
