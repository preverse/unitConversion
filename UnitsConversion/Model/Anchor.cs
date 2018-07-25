using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitsConversion.Model
{
    public class Anchor
    {
        public Anchor(Unit unit, float ratio, UnitSystem unitSystem)
        {
            this.Unit = unit;
            this.Ratio = ratio;
            this.UnitSystem = unitSystem;
        }

        public Unit Unit;

        public float Ratio;

        public UnitSystem UnitSystem { get; set; }

    }
}
