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
    public partial class MainManuForm : Form
    {
        public MainManuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrivateIndividualsForm privateIndividualsForm = new PrivateIndividualsForm();
            privateIndividualsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageHelperClass.StillInDevelopmentModeMessage();
        }
    }
}
