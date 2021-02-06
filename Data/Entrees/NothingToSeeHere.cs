/*
 * Author: Gregory Waters
 * File name: NothingToSeeHere.cs
 * Purpose: Class representing the Nothing to See Here menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.Data.Entrees
{
    class NothingToSeeHere
    {
        /// <summary>
        /// Establishes private backing variables
        /// </summary>
        private string name = "Nothing to See Here";
        private string description = "The breakfast classic of bacon, eggs, and Texas toast.";
        private double price = 3.50;
        private uint calories = 512;
        private bool substituteSausage = false;
        private EggStyle eggstyle = EggStyle.OverEasy;
        private List<string> specialInstructions = new List<string>();

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
        /// <summary>
        /// Changes calories based on substituteSausage
        /// </summary>
        public uint Calories
        {
            get 
            {
                if (substituteSausage)
                {
                    return calories + 31;
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
        public bool SubstituteSausage
        {
            get { return substituteSausage; }
            set
            {
                substituteSausage = value;
                if (substituteSausage)
                {
                    specialInstructions.Add("Substitute Sausage");
                }
            }
        }
        /// <summary>
        /// Establishes eggStyle
        /// </summary>
        public EggStyle EggStyle
        {
            get { return eggstyle; }
            set
            {
                eggstyle = value;
                specialInstructions.Add("Eggs " + eggstyle.ToString());
            }
        }
    }
}
