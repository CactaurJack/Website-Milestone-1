using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheFlyingSaucer.Data.Sides;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.DataTests.Sides
{
    public class TakenBaconTests
    {

        [Theory]
        [InlineData(Size.Small, "Small Taken Bacon")]
        [InlineData(Size.Medium, "Medium Taken Bacon")]
        [InlineData(Size.Large, "Large Taken Bacon")]
        public void NameIsCorrectForSize(Size size, string name)
        {
            var tb = new TakenBacon();
            tb.Size = size;
            Assert.Equal(size, tb.Size);
            Assert.Equal(name, tb.Name);
        }

        [Fact]
        public void DescriptionIsCorrect()
        {
            var tb = new TakenBacon();
            Assert.Equal("Crispy thick-sliced strips of hickory-smoked bacon.", tb.Description);
        }

        [Theory]
        [InlineData(Size.Small, 43)]
        [InlineData(Size.Medium, 86)]
        [InlineData(Size.Large, 129)]
        public void CaloriesAreCorrectForSize(Size size, uint calories)
        {
            var tb = new TakenBacon();
            tb.Size = size;
            Assert.Equal(calories, tb.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 1.5)]
        [InlineData(Size.Medium, 2.0)]
        [InlineData(Size.Large, 2.5)]
        public void PriceIsCorrect(Size size, decimal price)
        {
            var tb = new TakenBacon();
            tb.Size = size;
            Assert.Equal(price, tb.Price);
        }

        public void SpecialInstructionsShouldBeEmpty()
        {
            var tb = new TakenBacon();
            Assert.Equal(0 , tb.SpecialInstructions.Count);
        }

    }
}
