using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab20OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void CheckLinesButton_Click(object sender, EventArgs e)
        {
            double A1 = Convert.ToDouble(Line1ABox.Text);
            double B1 = Convert.ToDouble(Line1BBox.Text);
            double C1 = Convert.ToDouble(Line1CBox.Text);
            double A2 = Convert.ToDouble(Line2ABox.Text);
            double B2 = Convert.ToDouble(Line2BBox.Text);
            double C2 = Convert.ToDouble(Line2CBox.Text);

            if (CheckIfLinesExist(A1, B1, C1, A2, B2, C2))
            {
                MessageBox.Show("Прямі існують");
            }
            else
            {
                MessageBox.Show("Прямі не існують");
            }
        }
        // порожній клас-виключення
        public class LinesException : Exception { }

        // незалежний клас-виключення з полями-параметрами функції
        public class LinesParametersException : Exception
        {
            public double A1 { get; }
            public double B1 { get; }
            public double C1 { get; }
            public double A2 { get; }
            public double B2 { get; }
            public double C2 { get; }

            public LinesParametersException(double a1, double b1, double c1, double a2, double b2, double c2)
            {
                A1 = a1;
                B1 = b1;
                C1 = c1;
                A2 = a2;
                B2 = b2;
                C2 = c2;
            }
        }

        // спадкоємець від стандартного виключення з полями
        public class LinesCustomException : Exception
        {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }

            public LinesCustomException(string message, double a, double b, double c) : base(message)
            {
                A = a;
                B = b;
                C = c;
            }
        }

        public bool CheckIfLinesExist(double A1, double B1, double C1, double A2, double B2, double C2)
        {
            try
            {
                if (A1 == 0 && B1 == 0 && C1 == 0 && A2 == 0 && B2 == 0 && C2 == 0)
                {
                    throw new LinesException(); // порожній клас-виключення
                }
                if (A1 == 0 && B1 == 0 && C1 == 0)
                {
                    throw new LinesParametersException(A1, B1, C1, A2, B2, C2); // незалежний клас-виключення з полями-параметрами функції
                }
                double d = A1 * B2 - A2 * B1;
                if (d == 0)
                {
                    throw new LinesCustomException("Прямі паралельні або збігаються", A1, B1, C1); // спадкоємець від стандартного виключення з полями
                }
                else
                {
                    return true;
                }
            }
            catch (LinesException ex)
            {
                MessageBox.Show("Клас-виключення LinesException: порожній клас-виключення");
                return false;
            }
            catch (LinesParametersException ex)
            {
                MessageBox.Show($"Клас-виключення LinesParametersException: A1={ex.A1}, B1={ex.B1} , C1={ex.C1}, A2={ex.A2}, B2={ex.B2}, C2={ex.C2}");
                return false;
            }
            catch (LinesCustomException ex)
            {
                MessageBox.Show($"Клас-виключення LinesCustomException: {ex.Message}, A={ex.A}, B={ex.B}, C={ex.C}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Стандартний клас-виключення: {ex.Message}");
                return false;
            }
        }
    }
}

