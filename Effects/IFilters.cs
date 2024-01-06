using FiltersExample.Common;
using System.Drawing;

namespace Filters
{
    /// <summary>
    /// Filters interface
    /// </summary>
    public interface IFilters
    {
        /// <summary>
        /// Apply filter
        /// </summary>
        /// <param name="image">Image reference</param>
        /// <param name="type"> Type of filter</param>
        /// <returns> Returns task</returns>
        public Task Apply(ref Bitmap image, FilterType type);
    }
}
