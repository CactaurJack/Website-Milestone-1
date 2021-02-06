/*
 * Author: Gregory Waters
 * File name: LiveStockMutilation.cs
 * Purpose: Class representing the Livestock Mutilation menu item
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace TheFlyingSaucer.Data.Entrees
{
    class LivestockMutilation
    {
        /// <summary>
        /// Establishes private backing variables
        /// </summary>
        private string name = "Livestock Mutilation";
        private string description = "A hearty gravy saturated with sausage, poured over fluffy golden buttermilk biscuits.";
        private double price = 6.10;
        private uint calories = 332;
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Handles the only special instruction
        /// </summary>
        private bool gravyOnTheSide = false;

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
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public uint Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        public List<string> SpecialInstructions
        {
            get { return specialInstructions; }
            set { specialInstructions = value; }
        }
        /// <summary>
        /// Updates Special Instructions
        /// </summary>
        public bool GravyOnTheSide
        {
            get { return gravyOnTheSide; }
            set
            {
                gravyOnTheSide = value;
                if (gravyOnTheSide)
                {
                    specialInstructions.Add("Gravy on the Side");
                }
            }
        }

    }
}
