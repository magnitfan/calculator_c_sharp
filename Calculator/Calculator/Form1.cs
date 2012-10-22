using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                MessageBox.Show("Введенные данные некорректны!", "Некорректные данные", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            else
            {
                CalcRez += Double.Parse(TextBox1.Text);
                oper = Plus.Text;
                TextBox1.Text += " " + Plus.Text + " ";
                LengthTextBox = TextBox1.TextLength;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            //Проверяем TextBox1.Text на отсутствие данных и выдаем ошибку
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Введенные данные некорректны!", "Некорректные данные", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            else
            {
                CalcRez += Double.Parse(TextBox1.Text);
                oper = Minus.Text;
                TextBox1.Text += " " + Minus.Text + " ";
                LengthTextBox = TextBox1.TextLength;
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
                TextBox1.Text += " " + Umn.Text + " ";
                LengthTextBox = TextBox1.TextLength;
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            //Проверяем TextBox1.Text на отсутствие данных и выдаем ошибку
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Введенные данные некорректны!", "Некорректные данные", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            else
            {
                CalcRez += Double.Parse(TextBox1.Text);
                oper = Del.Text;
                TextBox1.Text += " " + Del.Text + " ";
                LengthTextBox = TextBox1.TextLength;
            }
        }

        private void Ravno_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Введенные данные некорректны!", "Некорректные данные", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                CalcRez = 0;
                TextBox1.Text = "0";
            }
            else
            {
                if (oper == Plus.Text)
                {
                    CalcRez += Double.Parse(TextBox1.Text.Substring(LengthTextBox));
                    OperDone = true;
                }
                else if (oper == Minus.Text)
                {
                    CalcRez -= Double.Parse(TextBox1.Text.Substring(LengthTextBox));
                    OperDone = true;
                }
                else if (oper == Umn.Text)
                {
                    CalcRez *= Double.Parse(TextBox1.Text.Substring(LengthTextBox));
                    OperDone = true;
                }
                else if (oper == Del.Text)
                {
                    CalcRez /= Double.Parse(TextBox1.Text.Substring(LengthTextBox));
                    OperDone = true;
                }
                else if (oper == Stepen.Text)
                {
                    Osn = CalcRez;
                    CalcRez = 1;
                    for (int y = 1; y <= Int32.Parse(TextBox1.Text.Substring(LengthTextBox)); y++)
                    {
                        CalcRez *= Osn;
                    }
                }
                TextBox1.Text = CalcRez.ToString();
                CalcRez = 0;
                oper = "";
            }
        }

        private void Null_Click(object sender, EventArgs e)
        {
            CalcRez = 0;
            TextBox1.Text = "0";
            OperDone = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "0") || (OperDone == true))
            {
                TextBox1.Text = "1";
                OperDone = false;
            }
            else
            {
                TextBox1.Text += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "0") || (OperDone == true))
            {
                TextBox1.Text = "2";
                OperDone = false;
            }
            else
            {
                TextBox1.Text += 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "0") || (OperDone == true))
            {
                TextBox1.Text = "3";
                OperDone = false;
            }
            else
            {
                TextBox1.Text += 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "0") || (OperDone == true))
            {
                TextBox1.Text = "4";
                OperDone = false;
            }
            else
            {
                TextBox1.Text += 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "0") || (OperDone == true))
            {
                TextBox1.Text = "5";
                OperDone = false;
            }
            else
            {
                TextBox1.Text += 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "0") || (OperDone == true))
            {
                TextBox1.Text = "6";
                OperDone = false;
            }
            else
            {
                TextBox1.Text += 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "0") || (OperDone == true))
            {
                TextBox1.Text = "7";
                OperDone = false;
            }
            else
            {
                TextBox1.Text += 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "0") || (OperDone == true))
            {
                TextBox1.Text = "8";
                OperDone = false;
            }
            else
            {
                TextBox1.Text += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "0") || (OperDone == true))
            {
                TextBox1.Text = "9";
                OperDone = false;
            }
            else
            {
                TextBox1.Text += 9;
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (OperDone == true)
            {
                TextBox1.Text = "0,";
                OperDone = false;
            }
            else
            {

                TextBox1.Text += ",";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text != "0") && (OperDone == false))
            {
                TextBox1.Text += 0;
            }
            else
            {
                TextBox1.Text = "0";
                OperDone = false;
            }
        }

        private void button000_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text != "0") && (OperDone == false))
            {
                TextBox1.Text += "000";
            }
            else
            {
                TextBox1.Text = "0";
                OperDone = false;
            }
        }

        private void Pred_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1);
            }
            else
            {
                MessageBox.Show("В этой версии программы кнопка может использоваться только для удаления цифр из числа. Следите за обновлениями!","Ошибка программы", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Введенные данные некорректны!", "Некорректные данные", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            else if (Double.Parse(TextBox1.Text) < 0)
            {
                MessageBox.Show("Выражение под знаком радикала должно быть неотрицательным!", "Некорректные данные", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
            else
            {
                CalcRez = Math.Sqrt(Double.Parse(TextBox1.Text));
                TextBox1.Text = CalcRez.ToString();
            }
        }

        private void Znak_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.IndexOf("-") == -1)
            {
                TextBox1.Text = "-" + TextBox1.Text;
            }
            else
            {
                TextBox1.Text = TextBox1.Text.Remove(0, 1);
            }
        }

        private void Stepen_Click(object sender, EventArgs e)
        {
            //Проверяем TextBox1.Text на отсутствие данных и выдаем ошибку
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Введенные данные некорректны!", "Некорректные данные", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            else
            {
                CalcRez += Double.Parse(TextBox1.Text);
                oper = Stepen.Text;
                TextBox1.Text += " ^ ";
                LengthTextBox = TextBox1.TextLength;
            }
        }

    }
}
