using ManualTestingExamples.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualTestingExamples
{
    public partial class PrivateIndividualsForm : Form
    {
        public PrivateIndividualsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrivateIndividualsCards privateIndividualsCards = new PrivateIndividualsCards();
            privateIndividualsCards.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageHelperClass.StillInDevelopmentModeMessage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageHelperClass.StillInDevelopmentModeMessage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageHelperClass.StillInDevelopmentModeMessage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageHelperClass.StillInDevelopmentModeMessage();
        }
    }
}
