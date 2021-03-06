﻿using System;
using System.Linq;

namespace MobileDeviceClasses
{
    public class Display
    {
        private double? size = null;
        private uint? colors = null;

        #region constructors
        /// <summary>
        /// default constructor
        /// </summary>
        public Display()
        {
        }

        /// <summary>
        /// ctor w/ parameters
        /// </summary>
        public Display(double displaySize, uint numberOfColors)
        {
            this.size = displaySize;
            this.colors = numberOfColors;
        }
        #endregion

        #region properties
        public double? Size
        {
            get { return this.size; }
            set
            {
                if (value < 3 || value > 10)
                    throw new ArgumentException("Invalid display size!");

                this.size = value;
            }
        }

        //properties colors
        public uint? Colors
        {
            get { return this.colors; }
            set
            {
                if (value <= 0 || value > 128000000)
                    throw new ArgumentException("Invalid colors value");

                this.colors = value;
            }
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return string.Format("{0}\", {1} colors",
                                  this.size, this.colors);
        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.ToString());
        }
        #endregion
    }
}
