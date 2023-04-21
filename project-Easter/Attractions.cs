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
    public partial class Attractions : Form
    {
        private string[] attractionTexts = new string[]
        {
            "Corfu Old Town:\nA UNESCO World Heritage site, the old town features a maze of narrow streets, charming squares, and a mix of Venetian, French, and British architecture. Key sites to visit include the Old Fortress, the New Fortress, and the Liston promenade.",
            "Paleokastritsa:\nA picturesque coastal village on the west coast of Corfu, known for its crystal-clear waters, stunning beaches, and lush greenery. The area is perfect for swimming, snorkeling, and exploring hidden coves.",
            "Achilleion Palace:\nBuilt by Empress Elisabeth of Austria in the late 19th century, this beautiful palace and its surrounding gardens offer stunning views of the Ionian Sea and are dedicated to the Greek hero Achilles.",
            "Kanoni and Mouse Island (Pontikonisi):\nThe Kanoni peninsula offers breathtaking views of the famous Mouse Island, home to the Byzantine church of Pantokrator. A short boat ride takes visitors to the island for a closer look at the church and the surrounding scenery.",
            "Sidari and the Canal d'Amour:\nLocated on the north coast of Corfu, Sidari is a popular resort town with a unique geological formation known as the Canal d'Amour. The sandstone cliffs and crystal-clear waters create a picturesque setting for swimming and sunbathing.",
            "Mount Pantokrator:\nThe highest peak on the island offers panoramic views of Corfu and the surrounding islands. Hiking trails lead to the summit, where you'll find a monastery and a small café.",
            "Angelokastro:\nA Byzantine fortress perched on a hilltop overlooking Paleokastritsa. The fortress offers incredible views of the coast and an insight into Corfu's rich history."
        };
        private int currentIndex = 0;
        private readonly Form _parent;

        public Attractions(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = $"{currentIndex + 1}. {attractionTexts[currentIndex]}";
            currentIndex = (currentIndex + 1) % attractionTexts.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide(); // Hide the current form
            //Menu form2 = new Menu(); // Replace "MainForm" with the name of your previous form
            //form2.Show(); // Show the previous form
            //form2.FormClosed += (s, args) => this.Close(); // Close the current form when the previous form is closed
            Close();
        }

        private void Attractions_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Show();
        }
    }
}
