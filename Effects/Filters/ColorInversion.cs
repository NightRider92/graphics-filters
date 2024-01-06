using FiltersExample.Common;
using System.Drawing;

namespace FiltersExample.Filters.Filters
{
    public class ColorInversion : FilterBase
    {
        public override void Apply(ref Bitmap image)
        {
            if (image is null) throw new ArgumentNullException(nameof(image));
            int w = image.Width;
            int h = image.Height;

            Bitmap resultImage = new Bitmap(w, h);

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Color c = image.GetPixel(i, j);
                    Color invertedColor = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    resultImage.SetPixel(i, j, invertedColor);
                }
            }
            image = resultImage;
        }
    }
}
