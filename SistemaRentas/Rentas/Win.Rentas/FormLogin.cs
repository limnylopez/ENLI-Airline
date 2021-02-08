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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido, usuario de J&J Fashion Store");
            //var frm = new FormMenu();
            //frm.Show();

            if ((tbusuario.Text != "" && tbcontra.Text != ""))
            {
                if ((tbusuario.Text == "Limny") && (tbcontra.Text == "1234"))
                {
                    var frm = new FormMenu();
                    frm.Show();
                }
               // {
                  // if ((tbusuario.Text == "Dixee") && (tbcontra.Text == "123"))
                   // {
                       // var frm = new FormMenu();
                      //  frm.Show();
                  //  }

                   else MessageBox.Show("Acceso denegado");
                }

            }
      //  }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
