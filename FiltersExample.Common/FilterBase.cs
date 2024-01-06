using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersExample.Common
{
    public abstract class FilterBase
    {
        public abstract void Apply(ref Bitmap image);
    }
}
