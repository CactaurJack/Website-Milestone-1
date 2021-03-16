/*
 * Author: Gregory Waters
 * File name: Evicerated Eggs.cs
 * Purpose: Class representing the Evicerated Eggs side menu item
 */

using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;
using System.ComponentModel;

namespace TheFlyingSaucer.Data.Sides
{
    /// <summary>
    /// Establishes EviceratedEggs class that inherits from Side abstract class
    /// </summary>
    public class EvisceratedEggs : Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// declaration of private backing variables
        /// </summary>
        private string name = " Eviscerated Eggs";
        private string description = "Farm-fresh eggs, served as you like!";
        private uint calories = 78;
        private decimal price = new decimal(1.50);
        private Size size = Size.Small;
        private EggStyle eggStyle = EggStyle.OverEasy;
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
                        return 78;
                    case Size.Medium:
                        return 156;
                    case Size.Large:
                        return 234;
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

        public Size Size
        {
            get { return size; }
            set { size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        public EggStyle EggStyle
        {
            get { return eggStyle; }
            set { eggStyle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EggStyle"));
            }
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
                switch(eggStyle)
                {
                    case EggStyle.OverEasy:
                        specialInstructions.Add("Eggs Over Easy");
                        return specialInstructions;
                    case EggStyle.Scrambled:
                        specialInstructions.Add("Eggs Scrambled");
                        return specialInstructions;
                    case EggStyle.Poached:
                        specialInstructions.Add("Eggs Poached");
                        return specialInstructions;
                    case EggStyle.HardBoiled:
                        specialInstructions.Add("Eggs Hard Boiled");
                        return specialInstructions;
                    case EggStyle.SunnySideUp:
                        specialInstructions.Add("Eggs Sunny Side Up");
                        return specialInstructions;
                    case EggStyle.OverMedium:
                        specialInstructions.Add("Eggs Over Medium");
                        return specialInstructions;
                    case EggStyle.OverWell:
                        specialInstructions.Add("Eggs Over Well");
                        return specialInstructions;
                }
                return specialInstructions;
            }
            set { specialInstructions = value; }
        }

    }
}
