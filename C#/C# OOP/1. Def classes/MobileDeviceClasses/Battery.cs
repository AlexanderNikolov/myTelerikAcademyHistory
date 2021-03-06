﻿/*
 *  3. Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) 
 *      and use it as a new field for the batteries.
 */

using System;

namespace MobileDeviceClasses {
    public class Battery {

        public enum BatteryType {
            Nikopol9V,
            NiMH,
            NiCd,
            LiIon
        }

        private uint? hoursIddle = null;
        private uint? hoursTalk = null;

        /// <summary>
        /// default ctor
        /// </summary>
        public Battery(BatteryType type, uint? hoursIddle = null, uint? hoursTalk = null) {
            this.Type = type;
            this.HoursIddle = hoursIddle;
            this.HoursTalk = hoursTalk;
        }

        #region properties
        public BatteryType Type {
            get;
            set;
        }

        public uint? HoursIddle {
            get { return this.hoursIddle; }
            set { this.hoursIddle = value; }
        }

        public uint? HoursTalk {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }
        #endregion

        #region methods
        public override string ToString() {
            return string.Format("battery: {0} {1} {2}",
                                 this.Type, this.hoursIddle, this.hoursTalk);
        }

        public void BatteryInfo() {
            Console.WriteLine(this.ToString());
        }
        #endregion
    }
}
