using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.Data.Drink
{
    public class SaucerFuel : Drink, IOrderItem
    {
        private string name = "Saucer Fuel";
        private string description = "Beamed directly from the best coffee plantations of South America, our rich brew is bound to put a bounce in your spacewalk.";
        private Size size = Size.Small;
        private decimal price = new Decimal(0.0);
        private uint calories = 0;
        private List<string> specialInstructions = new List<string>();
        private bool roomForCream = false;
        private bool decaf = false;

        public string Name
        {
            get { return size.ToString() + " " + name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        public decimal Price
        {
            get { switch (size)
                {
                    case Size.Small:
                        price = new Decimal(1.00);
                        return price;
                    case Size.Medium:
                        price = new Decimal(1.20);
                        return price;
                    case Size.Large:
                        price = new Decimal(1.40);
                        return price;
                    default:
                        return price;
                }
            }
            set { price = value; }
        }

        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        calories = 1;
                        return calories;
                    case Size.Medium:
                        calories = 2;
                        return calories;
                    case Size.Large:
                        calories = 3;
                        return calories;
                    default:
                        return calories;
                }
            }
            set { calories = value; }
        }

        public List<string> SpecialInstructions
        {
            get {
                specialInstructions = new List<string>();
                if(roomForCream)
                {
                    specialInstructions.Add("Room for Cream");
                }
                if(decaf)
                {
                    specialInstructions.Add("Decaf");
                }
                return specialInstructions;
            }
            set { specialInstructions = value; }
        }

        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

    }
}
