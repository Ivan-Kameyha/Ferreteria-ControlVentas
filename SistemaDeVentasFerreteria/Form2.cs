using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentasFerreteria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
                MessageBox.Show("Por favor coloque un usuario");
            else if (txtContraseña.Text == "")
                MessageBox.Show("Por favor coloque una contraseña");
            else
            {
                Form1 miFormulario1 = new Form1();

                miFormulario1.Show();
            }
        }
    }
}
