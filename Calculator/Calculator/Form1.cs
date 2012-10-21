using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            //Проверяем TextBox1.Text на отсутствие данных и выдаем ошибку
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Убедитесь в корректности введенных данных!");
            }
            else
            {
                CalcRez += Double.Parse(TextBox1.Text);
                oper = Plus.Text;
                TextBox1.Text = "";
                TextBox2.Text += " " + Plus.Text + " ";
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            //Проверяем TextBox1.Text на отсутствие данных и выдаем ошибку
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Убедитесь в корректности введенных данных!");
            }
            else
            {
                CalcRez += Double.Parse(TextBox1.Text);
                oper = Minus.Text;
                TextBox1.Text = "";
                TextBox2.Text += " " + Minus.Text + " ";
            }
        }    
        
        private void Umn_Click(object sender, EventArgs e)
        {
            //Проверяем TextBox1.Text на отсутствие данных и выдаем ошибку
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Убедитесь в корректности введенных данных!");
            }
            else
            {
                CalcRez += Double.Parse(TextBox1.Text);
                oper = Umn.Text;
                TextBox1.Text = "";
                TextBox2.Text += " " + Umn.Text + " ";
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            //Проверяем TextBox1.Text на отсутствие данных и выдаем ошибку
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Убедитесь в корректности введенных данных!");
            }
            else
            {
                CalcRez += Double.Parse(TextBox1.Text);
                oper = Del.Text;
                TextBox1.Text = "";
                TextBox2.Text += " " + Del.Text + " ";
            }
        }

        private void Ravno_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Убедитесь в корректности введенных данных!");
            }
            else
            {
                if (oper == Plus.Text)
                {
                    CalcRez += Double.Parse(TextBox1.Text);
                }
                else if (oper == Minus.Text)
                {
                    CalcRez -= Double.Parse(TextBox1.Text);
                }
                else if (oper == Umn.Text)
                {
                    CalcRez *= Double.Parse(TextBox1.Text);
                }
                else if (oper == Del.Text)
                {
                    CalcRez /= Double.Parse(TextBox1.Text);
                }
                TextBox1.Text = CalcRez.ToString();
                TextBox2.Text += " = " + CalcRez.ToString();
                oper = "";
            }
        }

        private void Null_Click(object sender, EventArgs e)
        {
            CalcRez = 0;
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += 1;
                TextBox2.Text += 1;
            }
            else
            {
                TextBox1.Text = "1";
                TextBox2.Text = "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += 2;
                TextBox2.Text += 2;
            }
            else
            {
                TextBox1.Text = "2";
                TextBox2.Text = "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += 3;
                TextBox2.Text += 3;
            }
            else
            {
                TextBox1.Text = "3";
                TextBox2.Text = "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += 4;
                TextBox2.Text += 4;
            }
            else
            {
                TextBox1.Text = "4";
                TextBox2.Text = "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += 5;
                TextBox2.Text += 5;
            }
            else
            {
                TextBox1.Text = "5";
                TextBox2.Text = "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += 6;
                TextBox2.Text += 6;
            }
            else
            {
                TextBox1.Text = "6";
                TextBox2.Text = "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += 7;
                TextBox2.Text += 7;
            }
            else
            {
                TextBox1.Text = "7";
                TextBox2.Text = "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += 8;
                TextBox2.Text += 8;
            }
            else
            {
                TextBox1.Text = "8";
                TextBox2.Text = "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += 9;
                TextBox2.Text += 9;
            }
            else
            {
                TextBox1.Text = "9";
                TextBox2.Text = "9";
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            TextBox1.Text += ",";
            TextBox2.Text += ",";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += 0;
                TextBox2.Text += 0;
            }
        }

        private void button000_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "0")
            {
                TextBox1.Text += "000";
                TextBox2.Text += "000";
            }
        }

        private void Pred_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1);
                TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.Length - 1, 1);
            }
            else
            {
                MessageBox.Show("В этой версии программы кнопка может использоваться только для удаления цифр из числа. Следите за обновлениями!");
            }
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Убедитесь в корректности введенных данных!");
            }
            else if (Double.Parse(TextBox1.Text) < 0)
            {
                MessageBox.Show("Выражение под знаком радикала должно быть неотрицательным!");
            }
            else
            {
                TextBox2.Text = Sqrt.Text + TextBox2.Text;
                CalcRez = Math.Sqrt(Double.Parse(TextBox1.Text));
                TextBox1.Text = CalcRez.ToString();
                TextBox2.Text += " = " + CalcRez.ToString();
            }
        }

        private void Znak_Click(object sender, EventArgs e)
        {
            CalcRez = -1 * Double.Parse(TextBox1.Text);
            TextBox1.Text = CalcRez.ToString();
            TextBox2.Text = TextBox2.Text.Insert(1, "-");
        }
    }
}
