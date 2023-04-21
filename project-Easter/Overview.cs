using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Easter
{
    public partial class Overview : Form
    {
        private string fullText = "Corfu, also known as Kerkyra, is a stunning Greek island located in the Ionian Sea.  It is the second-largest Ionian island and boasts a rich history, diverse cultural influences, and breathtaking landscapes. With its lush green vegetation, pristine beaches, and charming old town, Corfu has become a popular tourist destination for visitors from around the world. The island's unique blend of Venetian, French, British, and Greek architecture, as well as its vibrant local traditions, make Corfu an enchanting and unforgettable Easter destination in Greece.";
        private int currentTextIndex = 0;
        private readonly Form _parent;

        public Overview()
        {
            InitializeComponent();
            this.Load += (sender, e) =>
            {
                timer1.Start();
            };
        }

        public Overview(Form parent)
        {
            InitializeComponent();
            this.Load += (sender, e) =>
            {
                timer1.Start();
            };
            _parent = parent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentTextIndex < fullText.Length)
            {
                currentTextIndex++;
                labelOverview.Text = fullText.Substring(0, currentTextIndex);
            }
            else
            {
                timer1.Stop(); // Stop the timer when the full text is displayed
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide(); // Hide the current form
            //Menu form2 = new Menu(); // Replace "MainForm" with the name of your previous form
            //form2.Show(); // Show the previous form
            //form2.FormClosed += (s, args) => this.Close(); // Close the current form when the previous form is closed
            Close();            
        }

        private void Overview_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Show();
        }
    }
}
