using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraries.BarGraph
{
    public class Bar
    {
        public bool Showing { get; set; }

        public float Value { get; }

        public Bar(float value)
        {
            this.Value = value;
            this.Showing = false;
        }
    }
}
