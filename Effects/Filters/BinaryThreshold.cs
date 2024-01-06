using FiltersExample.Common;
using System.Drawing;

namespace FiltersExample.Filters.Filters
{
    public class BinaryThreshold : FilterBase
    {
        /// <summary>
        /// Apply binary threshold filter
        /// </summary>
        /// <param name="image"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public override void Apply(ref Bitmap image)
        {
            if (image is null) throw new ArgumentNullException(nameof(image));
            int w = image.Width;
            int h = image.Height;

            Bitmap resultImage = new Bitmap(w, h);
            int threshold = 380;

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Color c = image.GetPixel(i, j);
                    if ((c.R + c.G + c.B) < threshold) c = Color.Black;
                    else c = Color.White;

                    resultImage.SetPixel(i, j, c);
                }
            }
            image = resultImage;
        }
    }
}
