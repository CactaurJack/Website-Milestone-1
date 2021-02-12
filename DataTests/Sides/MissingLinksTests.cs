using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheFlyingSaucer.Data.Sides;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.DataTests.Sides
{
    public class MissingLinksTests
    {

        [Theory]
        [InlineData(Size.Small, "Small Missing Links")]
        [InlineData(Size.Medium, "Medium Missing Links")]
        [InlineData(Size.Large, "Large Missing Links")]
        public void NameIsCorrectForSize(Size size, string name)
        {
            var ml = new MissingLinks();
            ml.Size = size;
            Assert.Equal(size, ml.Size);
            Assert.Equal(name, ml.Name);
        }

        [Fact]
        public void DescriptionIsCorrect()
        {
            var ml = new MissingLinks();
            Assert.Equal("Rich sage sausage links cooked to perfection.", ml.Description);
        }

        [Theory]
        [InlineData(Size.Small, 391)]
        [InlineData(Size.Medium, 782)]
        [InlineData(Size.Large, 1173)]
        public void CaloriesAreCorrectForSize(Size size, uint calories)
        {
            var ml = new MissingLinks();
            ml.Size = size;
            Assert.Equal(calories, ml.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 1.5)]
        [InlineData(Size.Medium, 2.0)]
        [InlineData(Size.Large, 2.5)]
        public void PriceIsCorrect(Size size, decimal price)
        {
            var ml = new MissingLinks();
            ml.Size = size;
            Assert.Equal(price, ml.Price);
        }

        public void SpecialInstructionsShouldBeEmpty()
        {
            var ml = new MissingLinks();
            Assert.Equal(0, ml.SpecialInstructions.Count);
        }

    }
}
