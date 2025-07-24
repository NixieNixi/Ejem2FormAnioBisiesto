using System;
using System.Windows.Forms;

namespace Ejem2FormAnioBisiesto
{
    //Diseño del formulario para Año Bisiesto.


    //Creado por NixieNixi
    //Motivo: Pratica de ESD115, CICLO II - 2025
    //Fecha de creacion y finalizacion: 24/07/2025
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
               // anio = int.Parse(txtAnioSaber.Text); (Esto es el original pero ami me da error asi que opte por agg otra funcion

            // Funcion agg (Agg aparte)
            if (!int.TryParse(txtAnioSaber.Text, out int anio))
            {
                MessageBox.Show("Ingrese un anio valido");
                return;
            }

            if (EsBisiesto(anio)) //Verificamos si el anio es bisiesto(aqui mandamos a llamar a la funcion
            {
                txtMostrar.Text = "El Anio" + " " + anio + " " + "Si es Bisiesto";

            }
            else
            {
                txtMostrar.Text = "El Anio" + " " + anio + " " + "  No es Bisiesto";
            }

            txtAnioSaber.Focus();
            txtAnioSaber.Clear();
        }

        static bool EsBisiesto(int anio)
        {
            if(anio %4 == 0)
            {
                if(anio %100 == 0)
                {
                    if (anio % 400==0)
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
