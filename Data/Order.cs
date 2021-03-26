/*
 * Author: Gregory Waters
 * File name: Order.cs
 * Purpose: Class representing an order from the menu
 */


using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.ComponentModel;

namespace TheFlyingSaucer.Data
{
    /// <summary>
    /// Class defining the individual Order
    /// </summary>
    public class Order : INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// Private backing variables for getters and setters
        /// </summary>
        private DateTime dateTime;
        private NotifyCollectionChangedEventArgs e;
        private List<IOrderItem> orderList = new List<IOrderItem>();
        private decimal salesTax = (decimal)0.12;
        private decimal subTotal = (decimal)0.0;
        private decimal tax = (decimal)0.0;
        private decimal total = (decimal)0.0;
        private int number = 0;
        private uint calories = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor to take in correct order number
        /// </summary>
        /// <param name="orderNumber"></param>
        public Order(int orderNumber)
        {
            number = orderNumber;
            dateTime = DateTime.Now;
        }

        /// <summary>
        /// Event definition for INotifyCollectionChanged Interface
        /// </summary>
        event NotifyCollectionChangedEventHandler INotifyCollectionChanged.CollectionChanged
        {
            add
            {
                new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, OrderList);
            }

            remove
            {
                new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, OrderList);
            }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
        }

        /// <summary>
        /// Sales tax getter and setter
        /// </summary>
        public decimal SalesTax
        {
            get { return salesTax; }
            set { salesTax = value; }
        }

        /// <summary>
        /// Add item method, creates new event on add
        /// </summary>
        /// <param name="item">IOrder Item</param>
        public void AddItem(IOrderItem item)
        {
            orderList.Add(item);
            TotalUp();
            e = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, OrderList);
        }

        /// <summary>
        /// Remove item method, creates new event on removal
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItem(IOrderItem item)
        {
            if(orderList.Contains(item))
            {
                orderList.Remove(item);
                TotalUp();
                e = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, OrderList);
            }
        }

        /// <summary>
        /// Getter for list of IOrder items
        /// </summary>
        public List<IOrderItem> OrderList
        {
            get { return orderList; }
        }

        /// <summary>
        /// Getter for total variable
        /// </summary>
        public decimal Total
        {
            get { return total; }
        }

        /// <summary>
        /// getter for subtotal variable
        /// </summary>
        public decimal SubTotal
        {
            get { return subTotal; }
        }

        /// <summary>
        /// Getter for amount of tax applied
        /// </summary>
        public decimal Tax
        {
            get { return tax; }
        }

        /// <summary>
        /// Getter for total calories
        /// </summary>
        public decimal Calories
        {
            get { return calories; }
        }

        /// <summary>
        /// Getter for order number
        /// </summary>
        public int Number
        {
            get { return number; }
        }

        /// <summary>
        /// Supplies updates to all relavent fields based on contents of OrderList
        /// </summary>
        private void TotalUp()
        {
            subTotal = 0;
            total = 0;
            tax = 0;
            calories = 0;
            foreach(IOrderItem i in OrderList)
            {
                subTotal += i.Price;
                calories += i.Calories;
            }
            new PropertyChangedEventArgs("SubTotal");
            new PropertyChangedEventArgs("Calories");
            tax = subTotal * salesTax;
            new PropertyChangedEventArgs("Tax");
            total = tax + subTotal;
            new PropertyChangedEventArgs("Total");
        }



    }
}
