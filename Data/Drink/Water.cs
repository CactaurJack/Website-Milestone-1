using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;
using System.ComponentModel;

namespace TheFlyingSaucer.Data.Drink
{
    public class Water : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes the event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private string name = "Water";
        private string description = "Watch out if you come from a planet where pure H2O is deadly, because that’s all this is!";
        private Size size = Size.Small;
        private decimal price = new Decimal(0.0);
        private uint calories = 0;
        private List<string> specialInstructions = new List<string>();
        private bool ice = true;

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
        /// Gets and sets the Size property and raises event on property change
        /// </summary>
        public Size Size
        {
            get { return size; }
            set {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                size = value; }
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
            get {
                specialInstructions = new List<string>();
                if(!ice)
                {
                    specialInstructions.Add("No Ice");
                }
                return specialInstructions; }
            set { specialInstructions = value; }
        }

        /// <summary>
        /// Gets and sets the Ice bool property and raises event on property change
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                ice = value; }
        }

    }
}
