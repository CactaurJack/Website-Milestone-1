/*
 * Author: Gregory Waters
 * File name: CropCircleOats.cs
 * Purpose: Class representing the Crop Circle Oats side menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.Data.Sides
{
    /// <summary>
    /// Establishes CropCircleOats class that inherits from Side abstract class
    /// </summary>
    public class CropCircleOats : Side, IOrderItem
    {
        /// <summary>
        /// declaration of private backing variables
        /// </summary>
        private string name = " Crop Circle Oats";
        private string description = "A hearty oatmeal doused in butter and your choice of syrup.";
        private uint calories = 158;
        private decimal price =  new Decimal(1.5);
        private bool butter = true;
        private bool syrup = true;
        private SyrupFlavor syrupFlavor = SyrupFlavor.Maple;
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
                        return 158;
                    case Size.Medium:
                        return 316;
                    case Size.Large:
                        return 484;
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

        public SyrupFlavor SyrupFlavor
        {
            get { return syrupFlavor; }
            set { syrupFlavor = value; }
        }

        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        public bool Syrup
        {
            get { return syrup; }
            set { syrup = value; }
        }

        public bool Butter
        {
            get { return butter; }
            set { butter = value; }
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
                if (!butter)
                {
                    specialInstructions.Add("Hold Butter");
                }

                if(syrup)
                { 
                    specialInstructions.Add(syrupFlavor.ToString() + " Syrup");
                }
                else
                {
                    specialInstructions.Add("Hold Syrup");
                }
                
                return specialInstructions;
            }
            set { specialInstructions = value; }
        }

    }
}
