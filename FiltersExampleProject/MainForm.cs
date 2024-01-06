using Filters;
using FiltersExample.Common;
using System.Diagnostics;
using System.IO;

namespace FisheyeEffectWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            // Replace with path
            Bitmap? bmp = (Bitmap)Bitmap.FromFile("G:\\Old files\\Slike\\image.jpg");
            if (bmp is null) throw new ArgumentNullException(nameof(bmp));

            IFilters filters = new Filters.Filters();
            //filters.Apply(ref bmp, FilterType.Fisheye);
            //filters.Apply(ref bmp, FiltersExample.Effects.Filters.FilterType.BinaryThreshold);
            //filters.Apply(ref bmp, FilterType.ColorInversion);

            this.BackgroundImage = new Bitmap(bmp);
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}