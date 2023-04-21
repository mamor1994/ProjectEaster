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
    public partial class Customs : Form
    {
        private string[] customsTexts = new string[] 
        {
            "Corfu, a beautiful Greek island in the Ionian Sea, has unique and vibrant Easter customs that make it an exceptional destination during the Easter season. Here are some of the most notable Easter traditions in Corfu:",
            "1. Palm Sunday Procession: On Palm Sunday, the procession of the holy relic of Saint Spyridon, the patron saint of Corfu, takes place. The islanders carry the saint's relics around the town in a solemn and atmospheric procession.",
            "2. Pot Throwing (Botides): On Holy Saturday morning, a unique and exciting custom called \"Botides\" occurs in Corfu Town. People throw clay pots filled with water from their balconies onto the streets below. The smashing of pots symbolizes the triumph of life over death and the welcoming of spring.",
            "3. The Resurrection (Anastasi): The most significant event during Easter in Corfu is the Resurrection celebration on Holy Saturday night. Thousands of people gather in the central square of Corfu Town, where the island's three main churches participate in the ceremony. At midnight, when the Resurrection is proclaimed, fireworks and firecrackers light up the sky, and the joyful atmosphere fills the streets.",
            "4. The Procession of the Epitaphios: On Good Friday, a solemn procession takes place in Corfu Town, as well as in villages across the island. The procession of the Epitaphios (a bier representing the tomb of Christ) is accompanied by mournful music played by local bands, and the streets are adorned with flower decorations.",
            "5. Easter Sunday Feast: Easter Sunday in Corfu is a day of joy and feasting. Families gather to enjoy a traditional meal, which usually includes roasted lamb or goat, along with various local dishes, such as \"fogatsa\" (a sweet bread) and \"tsilihourda\" (a soup made from lamb offal).",
            "These customs and traditions make Easter in Corfu a truly unique and memorable experience."
        };
        private int currentIndex = 0;
        private int currentCharacter = 0;
        private readonly Form _parent;

        public Customs(Form parent)
        {
            InitializeComponent();
            timer1.Enabled = true;
            label1.Text = "";
            _parent = parent;
        }

        private void UpdateCustomsText()
        {
            
            if (currentIndex < customsTexts.Length)
            {
                    label1.Text += customsTexts[currentIndex] + "\r\n";
                    currentIndex++;
                } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateCustomsText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    this.Hide(); // Hide the current form
            //    Menu form2 = new Menu(); // Replace "MainForm" with the name of your previous form
            //    form2.Show(); // Show the previous form
            //    form2.FormClosed += (s, args) => this.Close(); // Close the current form when the previous form is closed

            Close();    
        }

        private void Customs_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Show();
        }
    }
}
