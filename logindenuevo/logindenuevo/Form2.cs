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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if (cBCS.Checked == true)
            {
                conteo++;
            }
            if(cBB.Checked==true)
            {
                conteo++;
            }
            if(rBTC.Checked==true)
            {
                seleccion = "Tarjeta de Crédito";
            }
            else
            {
                seleccion = "PayPal";
            }
            MessageBox.Show("Has seleccionado" + conteo + " cursos y tu método de pago es " + seleccion);
        }
    }
}
