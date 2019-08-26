using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logindenuevo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra el formulario
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="juancho"&& txtPassword.Text=="123tamarindo")
            {
                MessageBox.Show("Bienvenido Sr Don Juancho");
                this.Hide();//Escondemos ventana login
                Form2 CursosVentana = new Form2();
                CursosVentana.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Te la pelaste puto, usuario o contraseña no valido");
                txtUsuario.Text = "";
                txtPassword.Text = "";
                txtUsuario.Focus();
            }
            
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar==(int)Keys.Enter)
            {
                if (txtUsuario.Text=="juancho"&&txtPassword.Text=="123tamarindo")
                {

                }
            }
        }
    }
}
