using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SApp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           // button1.Location = new Point(100, 100);
        }

        private void counterUserControl_CustomEvent(object sender, CounterEventArgs e)
        {
            //MessageBox.Show(string.Format("Вы нажали на кнопку {0} раза.", e.Counter),
            //    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void counterUserControl_CounterEvent(object sender, CounterEventArgs e)
        {
            MessageBox.Show(string.Format("Вы нажали на кнопку {0} раза.", e.Counter),
               "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbCheck.Text, out int i))
            {
                MessageBox.Show(string.Format("Вы ввели число {0}", i), "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCheck2.Text = i.ToString();
                tbCheck.Text = "";
            }
            else
            {
                MessageBox.Show("Вы ввели некорректное число", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbCheck_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbCheck.Text, out int i))
            {
                tbCheck2.Text = i.ToString();
            }
            else
            {
                tbCheck2.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dialogForm = new DialogForm();
            if (dialogForm.ShowDialog() == DialogResult.OK)
            {
               label1.Text = dialogForm.Number.ToString();
            }
        }
    }
}
