using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;
using System.ComponentModel;

namespace TheFlyingSaucer.Data.Drink
{
    public class LiquifiedVegetation : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name = "Liquified Vegetation";
        private string description = "Fresh juice extracted from the finest fruits and vegetables";
        private Size size = Size.Small;
        private decimal price = new Decimal(0.0);
        private uint calories = 0;
        private List<string> specialInstructions = new List<string>();
        private JuiceFlavor juiceFlavor = JuiceFlavor.Apple;

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

        /// <summary>
        /// Gets and sets the size and invokes event on property change
        /// </summary>
        public Size Size
        {
            get { return size; }
            set {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                size = value; 
            }
        }

        public decimal Price
        {
            get { switch (size) 
                    {
                        
                        case Size.Small:
                            price = new Decimal(1.00);
                            return price;
                        case Size.Medium:
                            price = new Decimal(1.50);
                            return price;
                        case Size.Large:
                            price = new Decimal(2.00);
                            return price;
                        default:
                            return price;
                    }
            }
            set { price = value; }
        }

        public uint Calories
        {
            get { switch (juiceFlavor)
                {
                    case JuiceFlavor.Apple:
                        switch (size)
                        {
                        case Size.Small:
                                calories = 113;
                                return calories;
                        case Size.Medium:
                                calories = 226;
                                return calories;
                        case Size.Large:
                                calories = 339;
                                return calories;
                        default:
                            return calories;
                        }
                    case JuiceFlavor.Cranberry:
                        switch (size)
                        {
                            case Size.Small:
                                calories = 117;
                                return calories;
                            case Size.Medium:
                                calories = 234;
                                return calories;
                            case Size.Large:
                                calories = 481;
                                return calories;
                            default:
                                return calories;
                        }
                    case JuiceFlavor.Grape:
                        switch (size)
                        {
                            case Size.Small:
                                calories = 152;
                                return calories;
                            case Size.Medium:
                                calories = 304;
                                return calories;
                            case Size.Large:
                                calories = 456;
                                return calories;
                            default:
                                return calories;
                        }
                    case JuiceFlavor.Orange:
                        switch (size)
                        {
                            case Size.Small:
                                calories = 111;
                                return calories;
                            case Size.Medium:
                                calories = 222;
                                return calories;
                            case Size.Large:
                                calories = 333;
                                return calories;
                            default:
                                return calories;
                        }
                    case JuiceFlavor.Tomato:
                        switch (size)
                        {
                            case Size.Small:
                                calories = 42;
                                return calories;
                            case Size.Medium:
                                calories = 84;
                                return calories;
                            case Size.Large:
                                calories = 126;
                                return calories;
                            default:
                                return calories;
                        }
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
                switch(size)
                {
                    case Size.Small:
                        specialInstructions.Add("Small");
                        break;
                    case Size.Medium:
                        specialInstructions.Add("Medium");
                        break;
                    case Size.Large:
                        specialInstructions.Add("Large");
                        break;
                }
                switch (juiceFlavor)
                {
                    case JuiceFlavor.Apple:
                        specialInstructions.Add("Apple");
                        return specialInstructions;
                    case JuiceFlavor.Cranberry:
                        specialInstructions.Add("Cranberry");
                        return specialInstructions;
                    case JuiceFlavor.Grape:
                        specialInstructions.Add("Grape");
                        return specialInstructions;
                    case JuiceFlavor.Orange:
                        specialInstructions.Add("Orange");
                        return specialInstructions;
                    case JuiceFlavor.Tomato:
                        specialInstructions.Add("Tomato");
                        return specialInstructions;
                }
                return specialInstructions; }
            set { specialInstructions = value; }
        }

        /// <summary>
        /// Gets and sets Juice Flavor and raises event when it changes
        /// </summary>
        public JuiceFlavor JuiceFlavor
        {
            get { return juiceFlavor; }
            set {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("JuiceFlavor"));
                juiceFlavor = value; }
        }

    }
}
