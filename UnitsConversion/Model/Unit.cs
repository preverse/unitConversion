using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitsConversion.Model
{
    public enum UnitSystem
    {
        METRIC,
        IMPERIAL,
        BITS,
        BYTES
    }

    public class Unit
    {
        public Unit(string alias, string name, float toAnchor, UnitSystem unitSystem)
        {
            this.Alias = alias;
            this.Name = name;
            this.ToAnchor = toAnchor;
            this.UnitSystem = unitSystem;
        }

        public string Alias { get; set; }

        public string Name { get; set; }

        public float ToAnchor { get; set; }

        public UnitSystem UnitSystem { get; set; }

    }
}
