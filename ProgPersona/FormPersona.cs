using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ProgPersona
{
    public partial class FormPersona : Form
    {
        public FormPersona()
        {
            InitializeComponent();
        }
        Persona persona;
        private void btnPersona_Click(object sender, EventArgs e)
        {

            try
            {
                persona = new Persona(txtNombre.Text, Convert.ToInt32(txtDNI.Text), DateTime.Parse(txtFechaNac.Text));

                int dni = persona.P_DNI;

                if (dni.ToString().Length == 8)
                {
                    lbldni.Text = dni.ToString();
                }
                else
                {
                    MessageBox.Show("Documento debe tener 8 caracteres");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pueden ingresar letras");
            }
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            lblEdad.Text = persona.DevolucionEdad().ToString();
        }
    }
}
