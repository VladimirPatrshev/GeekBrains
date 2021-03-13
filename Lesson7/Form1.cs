using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{

    public partial class Form1 : Form
    {
        public static int Rnd()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 100);
            return x;
        }
        public int x = Rnd();
        public int count = 0;
        public Form1()
        {

            InitializeComponent();
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            

            if (int.TryParse(Answer.Text, out int i))
            {

                label2.Text = x.ToString();
                Answer.Text = i.ToString();


                if (i > x)
                {
                    label1.Text = "Ваше число больше";
                    count++;
                }
                if (i < x)
                {
                    label1.Text = "Ваше число меньше";
                    count++;
                }
                if (i == x)
                {
                    count++;
                    MessageBox.Show($"Вы выиграли!! Количество Ваших попыток {count}", "Победа",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Вы ввели некорректное число", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }
        private void Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
