using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        {

            double weight = string.IsNullOrEmpty(textBox2.Text) ? 1 : double.Parse(textBox2.Text);

            double height = string.IsNullOrEmpty(textBox1.Text) ? 1 : double.Parse(textBox1.Text);

 

            if (weight == 0)

            {

                MessageBox.Show("Results will be inaccurate. Weight is not a valid number.");

            }

            if (height == 0)

            {

                MessageBox.Show("Results will be inaccurate.  Height is not a valid number.");

            }


 

            double BMI = ( weight / (height*height) ) *10000 ;

 

 

            string BMI_description = string.Empty;

            if (BMI < 16.5)

                BMI_description = "severely underweight";

            else if (BMI >= 16.5 && BMI < 18.5)

                BMI_description = "underweight";

            else if (BMI >= 18.5 && BMI < 25)

                BMI_description = "normal";

            else if (BMI >= 25 && BMI <= 30)

                BMI_description = "overweight";

            else if (BMI > 30 && BMI <= 35)

                BMI_description = "obese";

            else if (BMI > 35 && BMI <= 40)

                BMI_description = "clinically obese";

            else

                BMI_description = "morbidly obese";

 

 

          //  textBox3.Text = string.Format("{0}.{1}.", BMI, BMI_description);
          // chi khai bao bmi
            textBox3.Text = string.Format("{0}", BMI);

        }


        }
    }
}
