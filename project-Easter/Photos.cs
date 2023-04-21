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

namespace project_Easter
{
    public partial class Photos : Form
    {
        private const int Delay = 1_000;

        private readonly List<string> imagePaths = new List<string>
        {
            Path.Combine(Directory.GetCurrentDirectory(), @"images\0.jpg"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\1.jpg"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\2.jpg"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\3.jpg"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\4.jpg"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\5.jpg"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\6.jpg"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\7.jpg"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\8.jpg"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\9.jpg"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\10.gif")
        };

        private readonly List<Image> _images = new List<Image>();

        public Photos()
        {
            InitializeComponent();
        }

        private async Task LoadImagesAsync()
        {
            foreach (var path in imagePaths)
            {
                // LOAD IMAGE
                var image = Image.FromFile(path);
                pictureBox1.Image = image;
                
                // Store images in list to dispose later
                _images.Add(image);
                
                await Task.Delay(Delay);
            }

            Close();
        }

        private async void Photos_Load(object sender, EventArgs e)
        {
            await LoadImagesAsync();
        }

        private void Photos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _images.ForEach(i => i.Dispose());
        }
    }
}
