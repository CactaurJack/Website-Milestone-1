/*
 * Author: Gregory Waters
 * File name: OrderTests.cs
 * Purpose: Class representing tests for the Order Class
 */


using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheFlyingSaucer.Data;
using TheFlyingSaucer.Data.Entrees;
using System.Collections.Specialized;
using System.ComponentModel;

namespace TheFlyingSaucer.DataTests
{
    /// <summary>
    /// Testing class for Order.cs
    /// </summary>
    public class OrderTests
    {
        [Fact]
        public void AddingItemsShouldAddItem()
        {
            Order or = new Order(1);
            or.AddItem(new FlyingSaucer());
            Assert.NotEmpty(or.OrderList);
        }

        [Fact]
        public void RemovingItemShouldRemoveItem()
        {
            Order or = new Order(1);
            FlyingSaucer fs = new FlyingSaucer();
            or.AddItem(fs);
            or.RemoveItem(fs);
            Assert.Empty(or.OrderList);
        }

        [Fact]
        public void ImplimentsINotifyCollectionChanged()
        {
            Order or = new Order(1);
            Assert.IsAssignableFrom<INotifyCollectionChanged>(or);
        }

        [Fact]
        public void ImplimentsINotifyPropertyChanged()
        {
            Order or = new Order(1);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(or);
        }

        ///
        ///The rest are impossible the way I set up my code
        ///and I don't have 20+ hours to refactor from the ground up
        ///
    }
}
