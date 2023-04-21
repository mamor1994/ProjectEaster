using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Printing;
using System.Xml;
using System.Net;
using System.Drawing.Imaging;

namespace project_Easter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "myFormText.txt";
            string filePath = Path.Combine(desktopPath, fileName);
            string fileContent = "This is the content of my form.";

            File.WriteAllText(filePath, fileContent);

            MessageBox.Show("File saved to desktop: " + fileName, "Message");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the SaveFileDialog to get the file name and location
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.Title = "Save Form As";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Use a StreamWriter to write the form's text to the selected file
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(this.Text);
                }
            }

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form copied to clipboard", "Message");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text cut!", "Message");

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBox1.Text = Clipboard.GetText();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = "Name: Maria Amorgianou";
            string email = "Email: mariaamorgianou.1994@gmail.com";

            string message = name + "\n" + email;
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

