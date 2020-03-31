using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redNeuronal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Inicio();
        }

        List<And> Lista = new List<And>();
        And and;
        double w1, w2, w3, u;
        int y, a = 0;

        public void Inicio()
        {
            and = new And(-1, -1, -1, -1);
            Lista.Add(and);
            and = new And(-1, -1, 1, -1);
            Lista.Add(and);
            and = new And(-1, 1, -1, -1);
            Lista.Add(and);
            and = new And(-1, 1, 1, -1);
            Lista.Add(and);
            and = new And(1, -1, -1, -1);
            Lista.Add(and);
            and = new And(1, -1, 1, -1);
            Lista.Add(and);
            and = new And(1, 1, -1, -1);
            Lista.Add(and);
            and = new And(1, 1, 1, 1);
            Lista.Add(and);
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            w1 = double.Parse(txt1.Text);
            w2 = double.Parse(txt2.Text);
            w3 = double.Parse(txt3.Text);
            u = double.Parse(txt4.Text);

            do
            {

                foreach (And a in Lista)
                {
                    y = (a.x1 * w1 + a.x2 * w2 + a.x3 * w3) + u > 0 ? 1 : -1;
                    if (y != a.dx)
                    {

                        w1 = w1 + (a.dx * a.x1);
                        w2 = w2 + (a.dx * a.x2);
                        w3 = w3 + (a.dx * a.x3);
                        u = u + a.dx;
                        this.a = 0;

                    }
                    else
                        this.a++;
                }
            } while (a == Lista.Count);
            txt1.Text = w1.ToString();
            txt2.Text = w2.ToString();
            txt3.Text = w3.ToString();
            txt4.Text = u.ToString();
            MessageBox.Show("Se ha realizado el calculo, los valores correctos se mostraran en la caja de texto de forma automatica.");
        }
    }
}
