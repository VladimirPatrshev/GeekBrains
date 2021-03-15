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
    public partial class Form3 : Form
    {
        public static int Rnd()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 100);
            return x;
        }
        
        
        
        public Form3()
        {
            InitializeComponent();

            button1.Text = "+1";
            button2.Text = "x2";
            button3.Text = "Сброс";
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = $"Достигнете числа: {x}";
            
            this.Text = "Удвоитель";

           
            MessageBox.Show(string.Format("Ваша задача число {0}", x), "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            int y = int.Parse(label1.Text);
            if (y == x)
            {
                MessageBox.Show(string.Format("Вы выиграли!!!"), "Победа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public int count = 0;
        public int x = Rnd();
        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
            count++;
            label2.Text = $"Количество шагов:{count}";

            int y = int.Parse(label1.Text);
            if (y == x)
            {
                MessageBox.Show(string.Format("Вы выиграли!!!"), "Победа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) * 2).ToString();
            count++;
            label2.Text = $"Количество шагов:{count}";

            int y = int.Parse(label1.Text);
            if (y == x)
            {
                MessageBox.Show(string.Format("Вы выиграли!!!"), "Победа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            count=0;
            label2.Text = $"Количество шагов: {count}";
            
        }
    }


        
    
}
