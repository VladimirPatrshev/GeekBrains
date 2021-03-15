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
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        public int Number { get; set; } = 0;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbInput.Text, out int i))
            {
                Number = i;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
