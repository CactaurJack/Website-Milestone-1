using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheFlyingSaucer.Data.Enums;
using TheFlyingSaucer.Data.Drink;

namespace TheFlyingSaucer.DataTests.Drinks
{
    public class SaucerFuelTests
    {
        private SaucerFuel sf;
        [Fact]
        public void ShouldReturnCorrectSize()
        {
            sf = new SaucerFuel();
            Assert.Equal(Size.Small, sf.Size);
            sf.Size = Size.Medium;
            Assert.Equal(Size.Medium, sf.Size);
            sf.Size = Size.Large;
            Assert.Equal(Size.Large, sf.Size);
        }

        [Fact]
        public void ShouldTakeDecaf()
        {
            sf = new SaucerFuel();
            Assert.Equal(false, sf.Decaf);
            sf.Decaf = true;
            Assert.Equal(true, sf.Decaf);
        }

        [Fact]
        public void ShouldHaveRoomForCream()
        {
            sf = new SaucerFuel();
            Assert.Equal(false, sf.RoomForCream);
            sf.RoomForCream = true;
            Assert.Equal(true, sf.RoomForCream);
        }

        [Fact]
        public void PropertyShouldChange()
        {
            sf = new SaucerFuel();
            Assert.PropertyChanged(sf, "Size", () => sf.Size = Size.Small);
            sf.Size = Size.Medium;
            Assert.PropertyChanged(sf, "Size", () => sf.Size = Size.Medium);
            sf.Size = Size.Large;
            Assert.PropertyChanged(sf, "Size", () => sf.Size = Size.Large);

            sf.RoomForCream = true;
            Assert.PropertyChanged(sf, "RoomForCream", () => sf.RoomForCream = true);

            sf.Decaf = true;
            Assert.PropertyChanged(sf, "Decaf", () => sf.Decaf = true);
        }

    }
}
