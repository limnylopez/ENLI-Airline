using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormLogin : Form
    {
        string usuario = "Limny";
        string contra = "123";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tbusuario.Text != usuario || tbcontra.Text != contra))
            {
                if (tbusuario.Text != usuario)
                {
                    MessageBox.Show("Usuario Incorrecto");
                    tbusuario.Clear();
                    tbusuario.Focus();
                    return;
                }
                if (tbcontra.Text != contra)
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    tbcontra.Clear();
                    tbcontra.Focus();
                    return;
                }
            }
            else
            {
                tbusuario.Clear();
                tbcontra.Clear();
                MessageBox.Show("Bienvenido, usuario de J&J Fashion Store");
                FormMenu Form = new FormMenu();
                Form.ShowDialog();

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
