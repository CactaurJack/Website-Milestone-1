/*
 * Author: Gregory Waters
 * File name: GlowingHaystack.cs
 * Purpose: Class representing the Glowing Haystack side menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.Data.Sides
{
    /// <summary>
    /// Establishes GlowingHaystack class that inherits from Side abstract class
    /// </summary>
    public class GlowingHaystack : Side, IOrderItem
    {
        /// <summary>
        /// declaration of private backing variables
        /// </summary>
        private string name = " Glowing Haystack";
        private string description = "A dense pile of crisp hash browns, smothered in roasted green pepper sauce.";
        private uint calories = 470;
        private decimal price = new decimal(1.50);
        private bool sauced = true;
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
                        return 470;
                    case Size.Medium:
                        return 610;
                    case Size.Large:
                        return 785;
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

        public bool Sauced
        {
            get { return sauced; }
            set { sauced = value; }
        }

        /// <summary>
        /// Builds the special instructions list every time the public variable is called
        /// this method helps to prevent repeat entries and always keep the list up to date
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                specialInstructions = new List<string>();
                if (!sauced)
                {
                    specialInstructions.Add("Hold Sauce");
                }
                return specialInstructions;
            }
            set { specialInstructions = value; }
        }

    }
}
