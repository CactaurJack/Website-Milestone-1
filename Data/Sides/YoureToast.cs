/*
 * Author: Gregory Waters
 * File name: YoureToast.cs
 * Purpose: Class representing the You're Toast side menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.Data.Sides
{
    /// <summary>
    /// Establishes YoureToast
    /// class that inherits from Side abstract class
    /// </summary>
    public class YoureToast : Side
    {
        /// <summary>
        /// declaration of private backing variables
        /// </summary>
        private string name = " You're Toast";
        private string description = "Thick, crusty slabs of Texas Toast.";
        private uint calories = 100;
        private decimal price = new decimal(1.50);
        private Size size = Size.Small;
        private List<string> specialInstructions = new List<string>();

        /// <summary>
        /// Getters and setters for private entities within the class
        /// </summary>
        public string Name
        {
            get { return (size.ToString() + name); }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// method for returning calories based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 100;
                    case Size.Medium:
                        return 200;
                    case Size.Large:
                        return 300;
                };
                return calories;
            }
            set
            {
                calories = value;
            }
        }

        public decimal Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return new Decimal(1.5);
                    case Size.Medium:
                        return new Decimal(2.0);
                    case Size.Large:
                        return new Decimal(2.5);
                };
                return price;
            }
            set
            {
                price = value;
            }
        }

        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                specialInstructions = new List<string>();
                return specialInstructions;
            }
            set { specialInstructions = value; }
        }

    }
}
