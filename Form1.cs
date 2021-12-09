using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiTask_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void f(double x)
        {
            if ((3 * x) < 0)
            {
                throw new Exception("Логарифм отрицательного числа");
            }
            if ((2 * x * x * x * x * x - 1) < 0)
            {
                throw new Exception("Квадратный корень из отрицательного числа");
            }
            if ((3 * x) == 0)
            {
                throw new Exception("Логарифм нуля - бесконечность");
            }
            double res = Math.Log(3 * x) * Math.Sqrt(2 * x * x * x * x * x - 1);
            labRes.Text += "f(" + x.ToString() + ") = " + res.ToString() + '\n';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                labRes.Text = String.Empty;
                double a = Double.Parse(tbA.Text);
                double b = Double.Parse(tbB.Text);
                double h = Double.Parse(tbH.Text);
                if (h == 0 || h < 0)
                {
                    throw new Exception("h должно быть больше нуля");
                }
                for (double x = a; x <= b; x += h)
                {
                    f(x);
                }
            }
            catch(System.FormatException)
            {
                labRes.Text = "Введено что-то не то";
            }
            catch (Exception exc)
            {
                labRes.Text = exc.Message;
            }
            finally
            {
                labRes.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labRes.Text = String.Empty;
        }
    }
}
