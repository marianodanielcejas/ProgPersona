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
            persona = new Persona(txtNombre.Text,Convert.ToInt64(txtDNI.Text),DateTime.Parse(txtFechaNac.Text));

            MessageBox.Show("La persona a sido instanciada");
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            lblEdad.Text = persona.DevolucionEdad().ToString();
        }
    }
}
