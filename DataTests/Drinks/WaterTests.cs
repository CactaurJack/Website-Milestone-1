using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheFlyingSaucer.Data.Enums;
using TheFlyingSaucer.Data.Drink;

namespace TheFlyingSaucer.DataTests.Drinks
{
    public class WaterTests
    {
        private Water w;
        [Fact]
        public void ShouldReturnCorrectSize()
        {
            w = new Water();
            Assert.Equal(Size.Small, w.Size);
            w.Size = Size.Medium;
            Assert.Equal(Size.Medium, w.Size);
            w.Size = Size.Large;
            Assert.Equal(Size.Large, w.Size);

        }

        [Fact]
        public void ShouldChangeProperty()
        {
            w = new Water();
            Assert.PropertyChanged(w, "Size", () => w.Size = Size.Small);
            w.Size = Size.Medium;
            Assert.PropertyChanged(w, "Size", () => w.Size = Size.Medium);
            w.Size = Size.Large;
            Assert.PropertyChanged(w, "Size", () => w.Size = Size.Large);
        }
    }
}
