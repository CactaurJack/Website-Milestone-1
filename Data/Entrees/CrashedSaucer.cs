/*
 * Author: Gregory Waters
 * File name: CrashedSaucer.cs
 * Purpose: Class representing the Crashed Saucer menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;
using System.ComponentModel;

namespace TheFlyingSaucer.Data.Entrees
{
    public class CrashedSaucer : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
        private bool whippedCream = true;
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
                if(!syrup)
                {
                    specialInstructions.Add("Hold Syrup");
                }
                if(!whippedCream)
                {
                    specialInstructions.Add("Hold Whipped Cream");
                }
                

                return specialInstructions;
            }
            set { specialInstructions = value; }
        }


        /// <summary>
        /// Gets and sets SyrupFlavor enum property and raises event on property changed
        /// </summary>
        public SyrupFlavor SyrupFlavor
        {
            get { return syrupFlavor; }
            set {
                
                syrupFlavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SyrupFlavor"));
            }
        }

        /// <summary>
        /// Gets and sets Syrup bool property and raises event on property changed
        /// </summary>
        public bool Syrup
        {
            get { return syrup; }
            set {  
                syrup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Syrup"));}
        }

        /// <summary>
        /// Gets and sets HalfStack bool property and raises event on property changed
        /// </summary>
        public bool HalfStack
        {
            get { return halfStack; }
            set {
                
                halfStack = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfStack"));
            }
            
        }

        /// <summary>
        /// Gets and sets WhippedCream bool property and raises event on property changed
        /// </summary>
        public bool WhippedCream
        {
            get { return whippedCream; }
            set {
                
                whippedCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WhippedCream")); }
        }
    }
}
