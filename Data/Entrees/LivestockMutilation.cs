/*
 * Author: Gregory Waters
 * File name: LiveStockMutilation.cs
 * Purpose: Class representing the Livestock Mutilation menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace TheFlyingSaucer.Data.Entrees
{
    public class LivestockMutilation : Entree, IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Establishes private backing variables
        /// </summary>
        private string name = "Livestock Mutilation";
        private string description = "A hearty gravy saturated with sausage, poured over fluffy golden buttermilk biscuits.";
        private decimal price = new Decimal(6.10);
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
                if (gravyOnTheSide)
                {
                    specialInstructions.Add("Gravy on the Side");
                }
                return specialInstructions;
            }
            set { specialInstructions = value; }
        }

        /// <summary>
        /// Gets and sets the GravyOnTheSide bool property and raises event on property change
        /// </summary>
        public bool GravyOnTheSide
        {
            get { return gravyOnTheSide; }
            set
            {
                gravyOnTheSide = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GravyOnTheSide"));
            }
        }

    }
}
