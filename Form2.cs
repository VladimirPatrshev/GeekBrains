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
    public partial class Form2 : Form
    {
        private TrueFalse database;

        public Form2()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(saveFileDialog.FileName);
                database.Add("Земля круглая?", true);
                database.Save();

                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(openFileDialog.FileName);
                database.Load();

                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;

                if (database.Count > 0)
                {
                    tbQuestion.Text = database[0].Text;
                    cbTrue.Checked = database[0].TrueFalse;
                }
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            database.Save();
            MessageBox.Show("Вы успешно сохранили базу вопросов", "База вопросов",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value + 1].Text = tbQuestion.Text;
            database[(int)nudNumber.Value + 1].TrueFalse = cbTrue.Checked;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            database.Add($"Вопрос #{database.Count + 1}", true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите удалить вопрос?", "База вопросов",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {


                if (nudNumber.Maximum == 1)
                    return;
                database.Remove((int)nudNumber.Value - 1);
                nudNumber.Maximum--;

                MessageBox.Show("Вопрос успешно удален", "База вопросов",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbQuestion.Text = "";
            }

            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(saveFileDialog.FileName);



                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                MessageBox.Show("Вы успешно сохранили базу вопросов", "База вопросов",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Патрушев, PadlaINC, QuestionApp ver. 0.1 , Екатеринбург, 2021г.", "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
       
    }
}
