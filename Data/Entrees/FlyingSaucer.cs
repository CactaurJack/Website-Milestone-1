/*
 * Author: Gregory Waters
 * File name: FlyingSaucer.cs
 * Purpose: Class representing the Flying Saucer menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.Data.Entrees
{
    public class FlyingSaucer
    {
        /// <summary>
        /// Establishing and initializing private backing
        /// variables for the class
        /// </summary>
        private string name = "Flying Saucer";
        private string description = "Our namesake dish. A full stack of fluffy golden pancakes, served with whipped cream, butter and your choice of syrup";
        private double price = 5.50;
        private uint calories = 254;
        private bool halfStack = false;
        private SyrupFlavor syrupFlavor = SyrupFlavor.Maple;
        private List<string> specialInstructions = new List<string>() { "Maple" };

        /// <summary>
        /// Establishing public variables and getting and setting parameters
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; } 
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// Handles price changes based on halfStack bool property
        /// </summary>
        public double Price
        {
            get
            {
                if (halfStack)
                {
                    return 3.25;
                }
                else
                {
                    return price;
                }
            }
            set { price = value; }
        }
        /// <summary>
        /// Handles change in calories based on halfStack
        /// calories parameter is simplt divided by two
        /// </summary>
        public uint Calories
        {
            get 
            {
                if (halfStack)
                {
                    return calories / 2;
                }
                else
                {
                    return calories;
                }
            }
            set { calories = value; }
        }
        public List<string> SpecialInstructions
        {
            get { return specialInstructions; }
            set { specialInstructions = value; }
        }
        /// <summary>
        /// Updates syrup flavor and adds it to the specialInstructions property
        /// </summary>
        public SyrupFlavor SyrupFlavor
        {
            get { return syrupFlavor; }
            set
            {
                syrupFlavor = value;
                specialInstructions.Add(syrupFlavor.ToString());
            }
        }
        public bool HalfStack
        {
            get { return halfStack; }
            set 
            {
                halfStack = value;
                if(halfStack)
                {
                    specialInstructions.Add("Half Stack");
                };
            }
        }

        


    }
}
