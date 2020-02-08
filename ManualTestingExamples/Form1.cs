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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static readonly Dictionary<string, string> credentials = new Dictionary<string, string>() 
        {
            { "sanja", "Beograd123!" },
            { "admin", "admin" } // this is for security testing
        };

        private void button1_Click(object sender, EventArgs e)
        {
            var user = credentials.FirstOrDefault(p => p.Key == txtLoginUserName.Text && p.Value == txtPassword.Text);

            if (user.Key == null)
            {
                MessageBox.Show("Uneli ste pogresne kredencijale");
            }
            else
            {
                MainManuForm mainManuForm = new MainManuForm();
                mainManuForm.Show();
            }
        }
    }
}
