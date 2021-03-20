using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsApp
{
    public partial class Form1 : Form
    {
        private TrueFalse database;
        public Form1()
        {
            InitializeComponent();
        }
        public int ANS = 0;
        public int x = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                ANS++;
                x++;
                textBox1.Text = database[(int)nudNumber1.Value - 1].Text;
                checkBox1.Checked = database[(int)nudNumber1.Value - 1].TrueFalse;
                
            }
            else
            {
                ANS++;
                x++;
              
            }

            if (x == nudNumber1.Maximum)
            {
                MessageBox.Show($"Вы ответили на {nudNumber1.Value} вопросов. Правильно ответили на {ANS} вопросов", "Финиш",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ANS++;
                x++;
                textBox1.Text = database[(int)nudNumber1.Value - 1].Text;
                checkBox1.Checked = database[(int)nudNumber1.Value - 1].TrueFalse;
                
            }
            else
            {
                ANS++;
                x++;
            }
            
            if (x == nudNumber1.Maximum)
            {
                MessageBox.Show($"Вы ответили на {nudNumber1.Value} вопросов. Правильно ответили на {ANS} вопросов", "Финиш",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void nudNumber1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = database[(int)nudNumber1.Value - 1].Text;
            checkBox1.Checked = database[(int)nudNumber1.Value - 1].TrueFalse;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(openFileDialog.FileName);
                database.Load();

                nudNumber1.Minimum = 1;
                nudNumber1.Maximum = database.Count;
                nudNumber1.Value = database.Count;

                if (database.Count > 0)
                {
                    textBox1.Text = database[0].Text;
                    checkBox1.Checked = database[0].TrueFalse;
                }
            }
        }

       
    }
}
