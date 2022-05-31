using System;
using System.IO;


namespace WinFormsApp1
{
    public partial class Calculate : Form
    {

        float first_value, second_value;
        int count;
        float temparary_value;
        bool value = true;

        public Calculate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button_zap_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            calculating_result();
            label1.Text = "";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            first_value = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = first_value.ToString() + "+";
            value = true;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            first_value = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = first_value.ToString() + "-";
            value = true;
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            first_value = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = first_value.ToString() + "*";
            value = true;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            first_value = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = first_value.ToString() + "/";
            value = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_quadra_Click(object sender, EventArgs e)
        {
            first_value = float.Parse(textBox1.Text);
            textBox1.Clear();
            second_value = first_value * first_value;
            textBox1.Text = second_value.ToString();
            value = true;
            System.IO.StreamWriter writer7 = new System.IO.StreamWriter(@"C:\Users\SMashokha\Desktop\result_calc.txt", true);
            writer7.Write(DateTime.Now);
            writer7.Write("|");
            writer7.Write(first_value);
            writer7.Write("^2");
            writer7.Write("=");
            writer7.WriteLine(second_value);
            writer7.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            first_value = float.Parse(textBox1.Text);
            textBox1.Clear();
            second_value = first_value / 100;
            textBox1.Text = second_value.ToString();
            value = true;
            System.IO.StreamWriter writer6 = new System.IO.StreamWriter(@"C:\Users\SMashokha\Desktop\result_calc.txt", true);
            writer6.Write(DateTime.Now);
            writer6.Write("|");
            writer6.Write(first_value);
            writer6.Write("%");
            writer6.Write("=");
            writer6.WriteLine(second_value);
            writer6.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculating_result()
        {
            switch (count)
            {
                case 1:
                    temparary_value = float.Parse(textBox1.Text);
                    second_value = first_value + float.Parse(textBox1.Text);
                    textBox1.Text = second_value.ToString();
                    System.IO.StreamWriter writer1 = new System.IO.StreamWriter(@"C:\Users\SMashokha\Desktop\result_calc.txt", true);
                    writer1.Write(DateTime.Now);
                    writer1.Write("|");
                    writer1.Write(first_value);
                    writer1.Write("+");
                    writer1.Write(temparary_value);
                    writer1.Write("=");
                    writer1.WriteLine(second_value);
                    writer1.Close();
                    break;
                case 2:
                    temparary_value = float.Parse(textBox1.Text);
                    second_value = first_value - float.Parse(textBox1.Text);
                    textBox1.Text = second_value.ToString();
                    System.IO.StreamWriter writer2 = new System.IO.StreamWriter(@"C:\Users\SMashokha\Desktop\result_calc.txt", true);
                    writer2.Write(DateTime.Now);
                    writer2.Write("|");
                    writer2.Write(first_value);
                    writer2.Write("-");
                    writer2.Write(temparary_value);
                    writer2.Write("=");
                    writer2.WriteLine(second_value);
                    writer2.Close();
                    break;
                case 3:
                    temparary_value = float.Parse(textBox1.Text);
                    second_value = first_value * float.Parse(textBox1.Text);
                    textBox1.Text = second_value.ToString();
                    System.IO.StreamWriter writer3 = new System.IO.StreamWriter(@"C:\Users\SMashokha\Desktop\result_calc.txt", true);
                    writer3.Write(DateTime.Now);
                    writer3.Write("|");
                    writer3.Write(first_value);
                    writer3.Write("*");
                    writer3.Write(temparary_value);
                    writer3.Write("=");
                    writer3.WriteLine(second_value);
                    writer3.Close();
                    break;
                case 4:
                    temparary_value = float.Parse(textBox1.Text);
                    second_value = first_value / float.Parse(textBox1.Text);
                    textBox1.Text = second_value.ToString();
                    System.IO.StreamWriter writer4 = new System.IO.StreamWriter(@"C:\Users\SMashokha\Desktop\result_calc.txt", true);
                    writer4.Write(DateTime.Now);
                    writer4.Write("|");
                    writer4.Write(first_value);
                    writer4.Write("/");
                    writer4.Write(temparary_value);
                    writer4.Write("=");
                    writer4.WriteLine(second_value);
                    writer4.Close();
                    break;
                
                default:
                    break;
            }

        }


    }
}