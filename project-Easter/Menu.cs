using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Easter
{
    public partial class Menu : Form
    {
        private readonly Form _parent;

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void overview_Click(object sender, EventArgs e)
        {
            Overview form3 = new Overview(parent: this);
            form3.Show();
            this.Hide(); // Optional: Hide the current form if you want to completely redirect to the new form
        }

        private void attractions_Click(object sender, EventArgs e)
        {
            Attractions form4 = new Attractions(parent: this);
            form4.Show();
            this.Hide();
        }

        private void history_Click(object sender, EventArgs e)
        {
            History form5 = new History(parent: this);
            form5.Show();
            this.Hide();
        }

        private void customs_Click(object sender, EventArgs e)
        {
            Customs form6 = new Customs(parent: this);
            form6.Show();
            this.Hide();
        }

        private void photos_Click(object sender, EventArgs e)
        {
            Photos form7 = new Photos();
            form7.FormClosed += Form7_FormClosed; // Subscribe to the FormClosed event
            this.Hide();
            form7.Show();
        }
        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string name = "Name: Maria Amorgianou";
            string email = "Email: mariaamorgianou.1994@gmail.com";

            string message = name + "\n" + email;
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text cut!", "Message");

        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form copied to clipboard", "Message");
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "myFormImage.png";
            string filePath = Path.Combine(desktopPath, fileName);
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            bmp.Save(filePath, ImageFormat.Png);

            MessageBox.Show("File saved to desktop. Please check your desktop for the file.", "Message");
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Show();
        }
    }
}
