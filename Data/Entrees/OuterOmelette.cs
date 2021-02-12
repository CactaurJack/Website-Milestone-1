/*
 * Author: Gregory Waters
 * File name: OuterOmelette.cs
 * Purpose: Class representing the Outer Omelette menu item
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace TheFlyingSaucer.Data.Entrees
{
    public class OuterOmelette : Entree
    {
        /// <summary>
        /// Establishes private backing variables
        /// </summary>
        private string name = "Outer Omelette";
        private string description = "A loaded omelette stuffed with all the favorites.";
        private decimal price = new Decimal(5.80);
        private uint calories = 510;
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// variables specific to SpecialInstructions
        /// </summary>
        private bool tomatoes = true;
        private bool mushrooms = true;
        private bool peppers = true;
        private bool onions = true;
        private bool spinach = true;
        private bool ham = true;
        private bool cheese = true;
        private bool sourCream = true;

        /// <summary>
        /// Standard Entree public entities
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
        public decimal Price
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
            get
            {
                specialInstructions = new List<string>();
                if (!tomatoes)
                {
                    specialInstructions.Add("Hold Tomatoes");
                }
                if (!mushrooms)
                {
                    specialInstructions.Add("Hold Mushrooms");
                }
                if (!peppers)
                {
                    specialInstructions.Add("Hold Peppers");
                }
                if (!onions)
                {
                    specialInstructions.Add("Hold Onions");
                }
                if (!spinach)
                {
                    specialInstructions.Add("Hold Spinach");
                }
                if (!ham)
                {
                    specialInstructions.Add("Hold Ham");
                }
                if (!cheese)
                {
                    specialInstructions.Add("Hold Cheese");
                }
                if (!sourCream)
                {
                    specialInstructions.Add("Hold Sour Cream");
                }
                return specialInstructions;
            }
            set { specialInstructions = value; }
        }
        /// <summary>
        /// SpecialInstruction section
        /// gets and sets all Special Instructions and adds their strings to the list
        /// </summary>
        public bool Tomatoes
        {
            get { return tomatoes; }
            set
            {
                tomatoes = value;
            }
        }
        public bool Mushrooms
        {
            get { return mushrooms; }
            set
            {
                mushrooms = value;
            }
        }
        public bool Peppers
        {
            get { return peppers; }
            set
            {
                peppers = value;
            }
        }
        public bool Onions
        {
            get { return onions; }
            set
            {
                onions = value;
            }
        }
        public bool Spinach
        {
            get { return spinach; }
            set
            {
                spinach = value;
            }
        }
        public bool Ham
        {
            get { return ham; }
            set
            {
                ham = value;
            }
        }
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
            }
        }
        public bool SourCream
        {
            get { return sourCream; }
            set
            {
                sourCream = value;
            }
        }

    }
}
