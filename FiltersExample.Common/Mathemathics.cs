using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersExample.Common
{
    public static class Mathemathics
    {
        /// <summary>
        /// Equisolid angle projection formula (cartesian to polar coordinates) / fisheye filter
        /// Formula found by Googling
        /// </summary>
        /// <param name="point"></param>
        /// <param name="focalLength"></param>
        /// <param name="center"></param>
        /// <returns></returns>
        public static PointF EquisolidAngleProjection(PointF point, int focalLength, PointF center)
        {
            float offsetX = point.X - center.X;
            float offsetY = point.Y - center.Y;

            float r = (float)Math.Sqrt((offsetX * offsetX) + (offsetY * offsetY));
            double theta = Math.Atan2(offsetY, offsetX);

            float radius = focalLength * (float)Math.Atan(r / (2 * focalLength));

            float distortedX = center.X + radius * (float)Math.Cos(theta);
            float distortedY = center.Y + radius * (float)Math.Sin(theta);

            return new PointF(distortedX, distortedY);
        }
    }
}
