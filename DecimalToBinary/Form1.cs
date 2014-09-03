using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecimalToBinary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = Number.Text;
            int enter = Convert.ToInt32(temp);

            if (DTB.Checked)    //10轉2
            {
                int tempNum = DecimalToBinary(enter);
                Answer.Text = "Answer : " + tempNum;
            }
            else
            {
                //2轉10
                int tempNum = BinaryToDecimal(enter);
                Answer.Text = "Answer : " + tempNum;
            }
        }

        private int DecimalToBinary(int number)
        {
            int total = 0, m = 1;

            while (number != 0)
            {
                total = total + (number % 2) * m;
                number = number / 2;
                m = m * 10;

            }
            return total;
        }

        private int BinaryToDecimal(int number)
        {
            int temp = 0, i = 0, m = 1;

            while (number > 0)
            {

                temp = temp + m * power(2, i);
                m = number % 10;
                number = number / 10;
                i++;

            }
            return temp;
        }

        private int power(int a,int b)  //a的b次方的函式
        {
            int Base=1,i;

            for(i=0;i<b;i++)
            {
                Base=Base*a;
            }
            return Base;
        }

        private void Number_TextChanged(object sender, EventArgs e)
        {
            Answer.Text = "";
            if (Number.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Number.ShortcutsEnabled = false;
        }
    }
}
