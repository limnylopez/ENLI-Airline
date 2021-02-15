using BL.Rentas;
using System;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;  //_seguridad es una variable global

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = tbusuario.Text;
            contrasena = tbcontra.Text;

           var resultado= _seguridad.Autorizar(usuario, contrasena);

            if (resultado==true) //Si el resultado es igual a verdadero
               
            {
                MessageBox.Show("Bienvenido");
                FormMenu Form = new FormMenu();
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                
            }
          }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        
    }
