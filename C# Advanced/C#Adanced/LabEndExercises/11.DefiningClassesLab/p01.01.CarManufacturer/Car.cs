﻿namespace p01._01.CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        private string make;
        private string model;
        private int year;

        public string Make
        {
            get
            {
                return this.make;
            }

            set
            {
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }

            set
            {
                this.year = value;
            }
        }
    }
}
