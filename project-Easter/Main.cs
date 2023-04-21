using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_Easter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
  
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text cut!", "Message");

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form copied to clipboard", "Message");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = "Name: Maria Amorgianou";
            string email = "Email: mariaamorgianou.1994@gmail.com";

            string message = name + "\n" + email;
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "myFormImage.png";
            string filePath = Path.Combine(desktopPath, fileName);
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            bmp.Save(filePath, ImageFormat.Png);

            MessageBox.Show("File saved to desktop. Please check your desktop for the file.", "Message");
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

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu(this);
            form2.Show();
            this.Hide();
        }
    }
}
