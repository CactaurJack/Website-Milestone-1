/*
 * Author: Gregory Waters
 * File name: NothingToSeeHere.cs
 * Purpose: Class representing the Nothing to See Here menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;
using System.ComponentModel;

namespace TheFlyingSaucer.Data.Entrees
{
    public class NothingToSeeHere : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Establishes event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Establishes private backing variables
        /// </summary>
        private string name = "Nothing to See Here";
        private string description = "The breakfast classic of bacon, eggs, and Texas toast.";
        private decimal price = new Decimal(3.50);
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
        public decimal Price
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
            get
            {
                specialInstructions = new List<string>();
                if (substituteSausage)
                {
                    specialInstructions.Add("Substitute Sausage");
                }
                specialInstructions.Add("Eggs " + eggstyle.ToString());
                return specialInstructions;
            }
            set { specialInstructions = value; }
        }

        /// <summary>
        /// Gets and sets the SubstititueSausage bool property and raises event on property changed
        /// </summary>
        public bool SubstituteSausage
        {
            get { return substituteSausage; }
            set
            {
                substituteSausage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubstituteSausage"));
            }
        }
        /// <summary>
        /// Establishes eggStyle and raises event on property changed
        /// </summary>
        public EggStyle EggStyle
        {
            get { return eggstyle; }
            set
            {
                eggstyle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EggStyle"));
            }
        }
    }
}
