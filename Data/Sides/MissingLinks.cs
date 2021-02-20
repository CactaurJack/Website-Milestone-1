/*
 * Author: Gregory Waters
 * File name: MissingLinks.cs
 * Purpose: Class representing the Missing Links side menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.Data.Sides
{
    /// <summary>
    /// Establishes MissingLinks class that inherits from Side abstract class
    /// </summary>
    public class MissingLinks : Side, IOrderItem
    {
        /// <summary>
        /// declaration of private backing variables
        /// </summary>
        private string name = " Missing Links";
        private string description = "Rich sage sausage links cooked to perfection.";
        private uint calories = 391;
        private decimal price = new Decimal(1.50);
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
                        return 391;
                    case Size.Medium:
                        return 782;
                    case Size.Large:
                        return 1173;
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
