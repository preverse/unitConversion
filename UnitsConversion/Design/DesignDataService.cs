﻿using System;
using System.Collections.Generic;
using UnitsConversion.Model;

namespace UnitsConversion.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem("Welcome to MVVM Light [design]");
            callback(item, null);
        }

        public void GetMetricUnitsList(Action<List<Unit>, Exception> callback)
        {

        }

        public void GetMetricAnchorList(Action<List<Anchor>, Exception> callback)
        {

        }
        public void GetDigitalUnitsList(Action<List<Unit>, Exception> callback)
        {

        }

        public void GetDigitalAnchorList(Action<List<Anchor>, Exception> callback)
        {

        }
    }
}