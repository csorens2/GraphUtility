using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraries.PieChart
{
    public abstract class PieSlice
    {
        public virtual float Value { get; }

        public PieSlice(float value)
        {
            this.Value = value;
        }
    }
}
