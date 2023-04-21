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
  
    public partial class History : Form
    {
        private string[] historyTexts = new string[]
        {
            "1. Ancient History: Corfu has been inhabited since the Paleolithic era, but its recorded history begins around the 8th century BCE, when it was settled by the Corinthians. The ancient city of Kerkyra was a significant naval power and a member of the Athenian League during the Peloponnesian War.",
            "2. Roman Period: In 229 BCE, Corfu became a Roman protectorate and later a province of the Roman Empire. It served as a vital naval base, with its ports playing a key role in the empire's eastern Mediterranean trade routes.",
            "3. Byzantine Era: After the fall of the Western Roman Empire, Corfu remained under Byzantine rule for several centuries. During this time, the island faced numerous invasions, including raids by the Vandals, Ostrogoths, and Normans.",
            "4. Venetian Rule: In 1386, Corfu voluntarily submitted to Venetian rule to protect itself from the growing Ottoman threat. Under the Venetians, the island's fortifications were strengthened, and its culture and architecture were heavily influenced by the Venetian Republic. Corfu remained under Venetian control until 1797.",
            "5. French and British Occupation: Following the fall of the Venetian Republic, Corfu briefly fell under French rule during the Napoleonic Wars. However, in 1815, the island became a British protectorate as part of the United States of the Ionian Islands.",
            "6. Union with Greece: In 1864, the Ionian Islands were ceded to Greece, and Corfu became a part of the newly-formed Greek state.",
            "7. World War II and Modern Times: During World War II, Corfu was occupied by Italian and German forces. After the war, the island's economy shifted towards tourism, and Corfu became a popular destination for visitors from around the world."
        };
        private int currentIndex = 0;
        private int currentCharacterIndex = 0;
        private string currentText = "";
        private int pauseCounter = 0;
        private int pauseDuration = 20; // The number of timer ticks to wait before displaying the next text
        private readonly Form _parent;

        public History(Form parent)
        {
            InitializeComponent();
            timer1.Enabled = true;
            _parent = parent;
        }
        private void UpdateHistoryText()
        {
            if (currentCharacterIndex < historyTexts[currentIndex].Length)
            {
                currentText += historyTexts[currentIndex][currentCharacterIndex];
                label1.Text = currentText;
                currentCharacterIndex++;
            }
            else
            {
                if (pauseCounter < pauseDuration)
                {
                    pauseCounter++;
                }
                else
                {
                    currentIndex = (currentIndex + 1) % historyTexts.Length;
                    currentCharacterIndex = 0;
                    currentText = "";
                    pauseCounter = 0;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateHistoryText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide(); // Hide the current form
            //Menu form2 = new Menu(); // Replace "MainForm" with the name of your previous form
            //form2.Show(); // Show the previous form
            //form2.FormClosed += (s, args) => this.Close(); // Close the current form when the previous form is closed
            Close();
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Show();
        }
    }
}
