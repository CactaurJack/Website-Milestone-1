/*
 * Author: Gregory Waters
 * File name: SpaceScramble.cs
 * Purpose: Class representing the Space Scramble menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;
using System.ComponentModel;

namespace TheFlyingSaucer.Data.Entrees
{
    public class SpaceScramble : Entree, IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Establishes private backing variables
        /// </summary>
        private string name = "Space Scramble";
        private string description = "A hearty skillet-fried scramble of potatoes, sausage, peppers, jack cheddar cheese, sour cream, and topped with your choice of egg.";
        private decimal price = new Decimal(5.20);
        private uint calories = 380;
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// variables specific to SpecialInstructions
        /// </summary>
        private bool potatoes = true;
        private bool sausage = true;
        private bool peppers = true;
        private bool cheese = true;
        private bool sourCream = true;
        private bool egg = true;
        private EggStyle eggStyle = EggStyle.OverEasy;

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
                if (!potatoes)
                {
                    specialInstructions.Add("Hold Potatoes");
                }
                if (!sausage)
                {
                    specialInstructions.Add("Hold Sausage");
                }
                if (!peppers)
                {
                    specialInstructions.Add("Hold Peppers");
                }
                if (!cheese)
                {
                    specialInstructions.Add("Hold Cheese");
                }
                if (!sourCream)
                {
                    specialInstructions.Add("Hold Sour Cream");
                }
                if (!egg)
                {
                    specialInstructions.Add("Hold Egg");
                }
                if (egg)
                {
                    specialInstructions.Add("Eggs " + eggStyle.ToString());
                }
                return specialInstructions;
            }
            set { specialInstructions = value; }
        }
        /// <summary>
        /// SpecialInstruction section
        /// gets and sets all Special Instructions and adds their strings to the list
        /// </summary>
        public bool Potatoes
        {
            get { return potatoes; }
            set
            {
                potatoes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Potatoes"));
            }
        }
        public bool Sausage
        {
            get { return sausage; }
            set
            {
                sausage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sausage"));
            }
        }
        public bool Peppers
        {
            get { return peppers; }
            set
            {
                peppers = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Peppers"));
            }
        }
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
            }
        }
        public bool SourCream
        {
            get { return sourCream; }
            set
            {
                sourCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SourCream"));
            }
        }
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
            }
        }
        /// <summary>
        /// Handler for the style of egg requested
        /// also formats the string
        /// </summary>
        public EggStyle EggStyle
        {
            get { return eggStyle; }
            set 
            { 
                eggStyle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EggStyle"));
            }
        }
    }
}
