using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualTestingExamples
{
    public partial class Form1 : Form
    {
        int wrongAttempt = 0;
        string docPath = @"C:\Response.txt";

        public Form1()
        {
            InitializeComponent();
            CreateFileIfNotExists(docPath);
        }

        private static readonly Dictionary<string, string> credentials = new Dictionary<string, string>() 
        {
            { "sanja", "Beograd123!" },
            { "admin", "admin" } // this is for security testing
        };

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool canContinue = true;

                var user = credentials.FirstOrDefault(p => p.Key == txtLoginUserName.Text && p.Value == txtPassword.Text);

                string lockTime = File.ReadLines(docPath).FirstOrDefault();

                if (!string.IsNullOrEmpty(lockTime))
                {
                    var oldLockTime = DateTime.ParseExact(lockTime, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                    if (oldLockTime > DateTime.Now.AddMinutes(-10))
                    {
                        canContinue = false;
                        wrongAttempt = 0;
                    }
                }

                if (canContinue == false)
                {
                    MessageBox.Show($"Morate sacekati deset minuta vas nalog je blokiran.");
                }

                if (wrongAttempt > 3)
                {
                    MessageBox.Show("Zakljucali ste vas nalog. Molimo vas da sacekate deset minuta");
                    var lockDateTime = DateTime.Now;

                    File.WriteAllText(docPath, string.Empty);
                    File.WriteAllText(docPath, lockDateTime.ToString());
                }

                if (user.Key == null)
                {
                    wrongAttempt++;
                    MessageBox.Show("Uneli ste pogresne kredencijale");
                }
                else
                {
                    
                    MainManuForm mainManuForm = new MainManuForm();
                    mainManuForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool CreateFileIfNotExists(string existingPath)
        {
            try
            {
                if (!File.Exists(existingPath))
                {
                    File.Create(existingPath);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
