using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitsConversion.Model
{
    public interface IDataService
    {
        void GetData(Action<DataItem, Exception> callback);
        
        void GetMetricUnitsList(Action<List<Unit>, Exception> callback);
        void GetMetricAnchorList(Action<List<Anchor>, Exception> callback);

        void GetDigitalUnitsList(Action<List<Unit>, Exception> callback);
        void GetDigitalAnchorList(Action<List<Anchor>, Exception> callback);
    }
}
