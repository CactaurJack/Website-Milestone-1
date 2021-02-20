using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheFlyingSaucer.Data.Enums;
using TheFlyingSaucer.Data.Drink;

namespace TheFlyingSaucer.DataTests.Drinks
{
    public class LiquifiedVegitationTests
    {
        private LiquifiedVegetation lv;
        [Fact]
        public void ShouldReturnCorrectSize()
        {
            lv = new LiquifiedVegetation();
            Assert.Equal(Size.Small, lv.Size);
            lv.Size = Size.Medium;
            Assert.Equal(Size.Medium, lv.Size);
            lv.Size = Size.Large;
            Assert.Equal(Size.Large, lv.Size);

        }

        [Fact]
        public void ShouldHaveCorrectFruit()
        {
            lv = new LiquifiedVegetation();
            Assert.Equal(JuiceFlavor.Apple, lv.JuiceFlavor);
            lv.JuiceFlavor = JuiceFlavor.Cranberry;
            Assert.Equal(JuiceFlavor.Cranberry, lv.JuiceFlavor);
            lv.JuiceFlavor = JuiceFlavor.Grape;
            Assert.Equal(JuiceFlavor.Grape, lv.JuiceFlavor);
            lv.JuiceFlavor = JuiceFlavor.Orange;
            Assert.Equal(JuiceFlavor.Orange, lv.JuiceFlavor);
            lv.JuiceFlavor = JuiceFlavor.Tomato;
            Assert.Equal(JuiceFlavor.Tomato, lv.JuiceFlavor);
        }

    }
}
