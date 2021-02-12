using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheFlyingSaucer.Data.Sides;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.DataTests.Sides
{
    public class GlowingHaystackTests
    {

        [Theory]
        [InlineData(Size.Small, "Small Glowing Haystack")]
        [InlineData(Size.Medium, "Medium Glowing Haystack")]
        [InlineData(Size.Large, "Large Glowing Haystack")]
        public void NameIsCorrectForSize(Size size, string name)
        {
            var gh = new GlowingHaystack();
            gh.Size = size;
            Assert.Equal(size, gh.Size);
            Assert.Equal(name, gh.Name);
        }

        [Fact]
        public void DescriptionIsCorrect()
        {
            var gh = new GlowingHaystack();
            Assert.Equal("A dense pile of crisp hash browns, smothered in roasted green pepper sauce.", gh.Description);
        }

        [Theory]
        [InlineData(Size.Small, 470)]
        [InlineData(Size.Medium, 610)]
        [InlineData(Size.Large, 785)]
        public void CaloriesAreCorrectForSize(Size size, uint calories)
        {
            var gh = new GlowingHaystack();
            gh.Size = size;
            Assert.Equal(calories, gh.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 1.5)]
        [InlineData(Size.Medium, 2.0)]
        [InlineData(Size.Large, 2.5)]
        public void PriceIsCorrect(Size size, decimal price)
        {
            var gh = new GlowingHaystack();
            gh.Size = size;
            Assert.Equal(price, gh.Price);
        }

        [Fact]
        public void ShouldBeAbleToSetSauced()
        {
            var gh = new GlowingHaystack();
            Assert.Equal(true, gh.Sauced);
            gh.Sauced = false;
            Assert.Equal(false, gh.Sauced);
        }

        [Theory]
        [InlineData(true, new string[0])]
        [InlineData(false, new string[] { "Hold Sauce"})]

        public void ShouldProvideCurrentSpecialInstructions(bool sauced, string[] instructions)
        {
            var gh = new GlowingHaystack();
            gh.Sauced = sauced;
            Assert.Equal(instructions.Length, gh.SpecialInstructions.Count);
        }

    }
}
