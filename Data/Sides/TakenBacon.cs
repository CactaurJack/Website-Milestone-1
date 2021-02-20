/*
 * Author: Gregory Waters
 * File name: TakenBacon.cs
 * Purpose: Class representing the Taken Bacon side menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.Data.Sides
{
    /// <summary>
    /// Establishes TakenBacon class that inherits from Side abstract class
    /// </summary>
    public class TakenBacon : Side, IOrderItem
    {
        /// <summary>
        /// declaration of private backing variables
        /// </summary>
        private string name = " Taken Bacon";
        private string description = "Crispy thick-sliced strips of hickory-smoked bacon.";
        private uint calories = 43;
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
                        return 43;
                    case Size.Medium:
                        return 86;
                    case Size.Large:
                        return 129;
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
