using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deducciones
{
    public partial class Form1 : Form
    {

        public Empleado emp;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }


        private void button1_Click(object sender, EventArgs e)
        {

            Boolean conyugue = false;

            //Instanciamos el bojeto.
            emp = new Empleado();

            //Comprobamos si tiene conyuge

            if (radioButton1.Checked == true)
            {
                conyugue = true;
            }
          

               String resultado = Convert.ToString(emp.Calcular(conyugue, int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text)));
               textBox4.Text = resultado;
           
        }
    }
}
