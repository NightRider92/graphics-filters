using Filters;
using FiltersExample.Common;
using FiltersExample.Filters.Filters;
using System.Diagnostics;
using System.Drawing;

namespace Filters
{
    /// <inheritdoc/>
    public class Filters : IFilters
    {
        /// <inheritdoc/>
        public Task Apply(ref Bitmap image, FilterType type)
        {
            if (image is null) throw new ArgumentNullException(nameof(image));
            try
            {
                FilterBase? filter = null;

                switch (type)
                {
                    case FilterType.Fisheye:

                        filter = new Fisheye();
                        break;

                    case FilterType.BinaryThreshold:
                        filter = new BinaryThreshold();
                        break;


                    case FilterType.ColorInversion:
                        filter = new ColorInversion();
                        break;

                    default:
                        throw new Exception("Unknown filter type");
                }

                filter.Apply(ref image);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                return Task.CompletedTask;
            }
        }
    }
}