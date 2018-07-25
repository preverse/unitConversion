using GalaSoft.MvvmLight;
using System.Collections.Generic;
using UnitsConversion.Model;

namespace UnitsConversion.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        public List<Anchor> Anchors { get; set; }


        public const string UnitsPropertyName = "Units";
        public List<Unit> _units;
        public List<Unit> Units
        {
            get
            {
                return _units;
            }
            set
            {
                Set(ref _units, value);
            }
        }

        public const string FromUnitPropertyName = "FromUnit";
        public Unit _fromUnit;
        public Unit FromUnit
        {
            get
            {
                return _fromUnit;
            }
            set
            {
                Set(ref _fromUnit, value);
                Update();
            }
        }

        public const string ToUnitPropertyName = "ToUnit";
        public Unit _toUnit;
        public Unit ToUnit
        {
            get
            {
                return _toUnit;
            }
            set
            {
                Set(ref _toUnit, value);
                Update();
            }
        }

        public const string FromValuePropertyName = "FromValue";
        public float _fromValue;
        public float FromValue
        {
            get
            {
                return _fromValue;
            }
            set
            {
                Set(ref _fromValue, value);
                Update();
            }
        }

        public const string ToValuePropertyName = "ToValue";
        public float _toValue;
        public float ToValue
        {
            get
            {
                return _toValue;
            }
            set
            {
                Set(ref _toValue, value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;

            // Uncomment this to use metric system values
            //_dataService.GetMetricUnitsList((item, error) => { Units = item; });
            //_dataService.GetMetricAnchorList((item, error) => { Anchors = item; });

            // Uncomment this to use digital system values
            _dataService.GetDigitalUnitsList((item, error) => { Units = item; });
            _dataService.GetDigitalAnchorList((item, error) => { Anchors = item; });
        }

        public void Update()
        {
            if (this.FromUnit == null || this.ToUnit == null)
                return;

            float toAnchorValue = this.FromValue * this.FromUnit.ToAnchor;

            if (this.FromUnit.UnitSystem != this.ToUnit.UnitSystem)
            {
                var ratio = Anchors.Find(x => x.UnitSystem == this.FromUnit.UnitSystem).Ratio;

                toAnchorValue = toAnchorValue * ratio;
            }

            float fromAnchorValue = toAnchorValue / this.ToUnit.ToAnchor;

            this.ToValue = fromAnchorValue;
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}