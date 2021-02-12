using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheFlyingSaucer.Data.Sides;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.DataTests.Sides
{
    public class YoureToastTests
    {

        [Theory]
        [InlineData(Size.Small, "Small You're Toast")]
        [InlineData(Size.Medium, "Medium You're Toast")]
        [InlineData(Size.Large, "Large You're Toast")]
        public void NameIsCorrectForSize(Size size, string name)
        {
            var yt = new YoureToast();
            yt.Size = size;
            Assert.Equal(size, yt.Size);
            Assert.Equal(name, yt.Name);
        }

        [Fact]
        public void DescriptionIsCorrect()
        {
            var yt = new YoureToast();
            Assert.Equal("Thick, crusty slabs of Texas Toast.", yt.Description);
        }

        [Theory]
        [InlineData(Size.Small, 100)]
        [InlineData(Size.Medium, 200)]
        [InlineData(Size.Large, 300)]
        public void CaloriesAreCorrectForSize(Size size, uint calories)
        {
            var yt = new YoureToast();
            yt.Size = size;
            Assert.Equal(calories, yt.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 1.5)]
        [InlineData(Size.Medium, 2.0)]
        [InlineData(Size.Large, 2.5)]
        public void PriceIsCorrect(Size size, decimal price)
        {
            var yt = new YoureToast();
            yt.Size = size;
            Assert.Equal(price, yt.Price);
        }

        public void SpecialInstructionsShouldBeEmpty()
        {
            var yt = new YoureToast();
            Assert.Equal(0, yt.SpecialInstructions.Count);
        }

    }
}
