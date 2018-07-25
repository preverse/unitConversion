using System;
using System.Collections.Generic;

namespace UnitsConversion.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new DataItem("Welcome to MVVM Light");
            callback(item, null);
        }

        public void GetMetricUnitsList(Action<List<Unit>, Exception> callback)
        {
            List<Unit> lUnits = new List<Unit>();

            Unit millimeters = new Unit("mm", "millimeters", 0.001F, UnitSystem.METRIC);
            Unit centimeters = new Unit("cm", "centimeters", 0.01F, UnitSystem.METRIC);
            Unit meters = new Unit("m", "meters", 1F, UnitSystem.METRIC);
            Unit kilometers = new Unit("m", "kilometers", 1000F, UnitSystem.METRIC);


            Unit inches = new Unit("in", "inches", 0.083F, UnitSystem.IMPERIAL);
            Unit feets = new Unit("ft", "feets", 1F, UnitSystem.IMPERIAL);
            Unit yard = new Unit("yd", "yard", 3F, UnitSystem.IMPERIAL);
            Unit mile = new Unit("mi", "mile", 5280F, UnitSystem.IMPERIAL);

            lUnits.Add(millimeters);
            lUnits.Add(centimeters);
            lUnits.Add(meters);
            lUnits.Add(kilometers);

            lUnits.Add(inches);
            lUnits.Add(feets);
            lUnits.Add(yard);
            lUnits.Add(mile);

            callback(lUnits, null);
        }

        public void GetMetricAnchorList(Action<List<Anchor>, Exception> callback)
        {
            Unit meters = new Unit("m", "meters", 1F, UnitSystem.METRIC);
            Unit feets = new Unit("ft", "feets", 1F, UnitSystem.IMPERIAL);

            Anchor anchorMeter = new Anchor(meters, 3.28084F, UnitSystem.METRIC);
            Anchor anchorFeets = new Anchor(feets, 0.30479F, UnitSystem.IMPERIAL);

            List<Anchor> lAnchor = new List<Anchor>();

            lAnchor.Add(anchorMeter);
            lAnchor.Add(anchorFeets);

            callback(lAnchor, null);
        }

        public void GetDigitalUnitsList(Action<List<Unit>, Exception> callback)
        {
            List<Unit> lUnits = new List<Unit>();

            Unit bits = new Unit("b", "bits", 1F, UnitSystem.BITS);
            Unit kilobits = new Unit("Kb", "kilobits", 1024F, UnitSystem.BITS);
            Unit megabits = new Unit("Mb", "megabits", 1048576F, UnitSystem.BITS);
            Unit gigabits = new Unit("Gb", "gigabits", 1073741824F, UnitSystem.BITS);
            Unit terabits = new Unit("Tb", "terabits", 1099511627776F, UnitSystem.BITS);


            Unit bytes = new Unit("B", "bytes", 1F, UnitSystem.BYTES);
            Unit kilobytes = new Unit("KB", "kilobytes", 1024F, UnitSystem.BYTES);
            Unit megabytes = new Unit("MB", "megabytes", 1048576F, UnitSystem.BYTES);
            Unit gigabytes = new Unit("GB", "gigabytes", 1073741824F, UnitSystem.BYTES);
            Unit terabytes = new Unit("TB", "terabytes", 1099511627776F, UnitSystem.BYTES);

            lUnits.Add(bits);
            lUnits.Add(kilobits);
            lUnits.Add(megabits);
            lUnits.Add(gigabits);
            lUnits.Add(terabits);

            lUnits.Add(bytes);
            lUnits.Add(kilobytes);
            lUnits.Add(megabytes);
            lUnits.Add(gigabytes);
            lUnits.Add(terabytes);

            callback(lUnits, null);
        }

        public void GetDigitalAnchorList(Action<List<Anchor>, Exception> callback)
        {
            Unit bits = new Unit("b", "bits", 1F, UnitSystem.BITS);
            Unit bytes = new Unit("B", "bytes", 1F, UnitSystem.BYTES);

            Anchor anchorMeter = new Anchor(bits, 0.125F, UnitSystem.BITS);
            Anchor anchorFeets = new Anchor(bytes, 8F, UnitSystem.BYTES);

            List<Anchor> lAnchor = new List<Anchor>();

            lAnchor.Add(anchorMeter);
            lAnchor.Add(anchorFeets);

            callback(lAnchor, null);
        }
    }
}