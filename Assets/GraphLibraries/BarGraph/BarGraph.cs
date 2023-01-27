using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;

namespace GraphLibraries.BarGraph
{ 
    public abstract class BarGraph
    {
        public Dictionary<string, Bar> Bars { get; }

        public BarGraph()
        {
            Bars = new Dictionary<string, Bar>();
        }

        public void AddBar(string name, float value)
        {
            Bars.Add(name, new Bar(value));
        }
    }
}
