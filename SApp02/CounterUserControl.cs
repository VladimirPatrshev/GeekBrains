using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SApp02
{
    public partial class CounterUserControl : UserControl
    {

        private int counter = 0;

        public event CounterEventHandler CustomEvent;
        public event EventHandler<CounterEventArgs> CounterEvent;

        public CounterUserControl()
        {
            InitializeComponent();
            lblCounter.Text = counter.ToString();
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            tbCounter.Text = "Вы нажали на кнопку";
            counter++;
            lblCounter.Text = counter.ToString();
            if (counter >= 3)
            {
                if (CustomEvent != null)
                {
                    CustomEvent.Invoke(sender, new CounterEventArgs(counter));
                }
                if (CounterEvent != null)
                {
                    CounterEvent.Invoke(sender, new CounterEventArgs(counter));
                }
                counter = 0;
                lblCounter.Text = counter.ToString();
            }
        }

        private void tbCounter_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = tbCounter.Text;
        }
    }

    public delegate void CounterEventHandler(object sender, CounterEventArgs e);

    public class CounterEventArgs : EventArgs
    {
        public int Counter { get; set; }

        public CounterEventArgs(int counter)
        {
            Counter = counter;
        }
    }
}
