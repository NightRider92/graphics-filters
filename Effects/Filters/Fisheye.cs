using FiltersExample.Common;
using System.Drawing;

namespace FiltersExample.Filters.Filters
{
    public class Fisheye : FilterBase
    {
        /// <summary>
        /// Apply fisheye filter
        /// </summary>
        /// <param name="image"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public override void Apply(ref Bitmap image)
        {
            if (image is null) throw new ArgumentNullException(nameof(image));
            int focalLength = 125;

            int w = image.Width;
            int h = image.Height;

            Bitmap resultImage = new Bitmap(w, h);
            int centerX = w / 2;
            int centerY = h / 2;

            // Iterate over image pixels
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Color c = image.GetPixel(i, j);
                    PointF p = Mathemathics.EquisolidAngleProjection(new PointF(i, j), focalLength, new PointF(centerX, centerY));

                    // Image needs to be inside bounds (returns from 0 to (w-1)
                    p.X = Math.Max(0, Math.Min(p.X, w - 1));

                    // Image needs to be inside bounds (returns from 0 to (h-1)
                    p.Y = Math.Max(0, Math.Min(p.Y, h - 1));

                    // Set pixel (slow method, just algorithm proof of concept)
                    resultImage.SetPixel((int)p.X, (int)p.Y, c);
                }
            }

            image = resultImage;
        }
    }
}
