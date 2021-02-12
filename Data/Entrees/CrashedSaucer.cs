/*
 * Author: Gregory Waters
 * File name: CrashedSaucer.cs
 * Purpose: Class representing the Crashed Saucer menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.Data.Entrees
{
    public class CrashedSaucer : Entree
    {
        /// <summary>
        /// Establishing and initializing private backing
        /// variables for the class
        /// </summary>
        private string name = "Crashed Saucer";
        private string description = "A stack of thick-sliced french toast, served with whipped cream, butter and your choice of syrup.";
        private decimal price = new Decimal(5.80);
        private uint calories = 510;
        private bool halfStack = false;
        private bool syrup = true;
        private SyrupFlavor syrupFlavor = SyrupFlavor.Maple;
        private List<string> specialInstructions = new List<string>();

        /// <summary>
        /// Establishes getters and setters for the public variables
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
        /// Returns price based on halfStack property
        /// </summary>
        public decimal Price
        {
            get
            {
                if (halfStack)
                {
                    return new Decimal(3.70);
                }
                else
                {
                    return price;
                }
            }
            set { price = value; }
        }
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
            get 
            {
                specialInstructions = new List<string>();
                if (halfStack)
                {
                    specialInstructions.Add("Half Stack");
                }

                if (syrup)
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
        public SyrupFlavor SyrupFlavor
        {
            get { return syrupFlavor; }
            set { syrupFlavor = value; }
        }

        public bool Syrup
        {
            get { return syrup; }
            set { syrup = value; }
        }

        public bool HalfStack
        {
            get { return halfStack; }
            set { halfStack = value; }
            
        }
    }
}
