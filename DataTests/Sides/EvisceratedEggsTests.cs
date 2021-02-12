using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheFlyingSaucer.Data.Sides;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.DataTests.Sides
{
    public class EvisceratedEggsTests
    {

        [Theory]
        [InlineData(Size.Small, "Small Eviscerated Eggs")]
        [InlineData(Size.Medium, "Medium Eviscerated Eggs")]
        [InlineData(Size.Large, "Large Eviscerated Eggs")]
        public void NameIsCorrectForSize(Size size, string name)
        {
            var ee = new EvisceratedEggs();
            ee.Size = size;
            Assert.Equal(size, ee.Size);
            Assert.Equal(name, ee.Name);
        }

        [Fact]
        public void DescriptionIsCorrect()
        {
            var ee = new EvisceratedEggs();
            Assert.Equal("Farm-fresh eggs, served as you like!", ee.Description);
        }

        [Theory]
        [InlineData(Size.Small, 78)]
        [InlineData(Size.Medium, 156)]
        [InlineData(Size.Large, 234)]
        public void CaloriesAreCorrectForSize(Size size, uint calories)
        {
            var ee = new EvisceratedEggs();
            ee.Size = size;
            Assert.Equal(calories, ee.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 1.5)]
        [InlineData(Size.Medium, 2.0)]
        [InlineData(Size.Large, 2.5)]
        public void PriceIsCorrect(Size size, decimal price)
        {
            var ee = new EvisceratedEggs();
            ee.Size = size;
            Assert.Equal(price, ee.Price);
        }

        [Theory]
        [InlineData(EggStyle.HardBoiled)]
        [InlineData(EggStyle.OverEasy)]
        [InlineData(EggStyle.OverMedium)]
        [InlineData(EggStyle.OverWell)]
        [InlineData(EggStyle.Poached)]
        [InlineData(EggStyle.Scrambled)]
        [InlineData(EggStyle.SunnySideUp)]
        public void ShouldBeAbleToSetEggStyle(EggStyle style)
        {
            var ee = new EvisceratedEggs();
            ee.EggStyle = style;
            Assert.Equal(style, ee.EggStyle);
        }

        [Theory]
        [InlineData(EggStyle.HardBoiled, new string[] { "Hard Boiled" })]
        [InlineData(EggStyle.OverEasy, new string[] { "Over Easy" })]
        [InlineData(EggStyle.OverMedium, new string[] { "Over Medium" })]
        [InlineData(EggStyle.OverWell, new string[] { "Over Well" })]
        [InlineData(EggStyle.Poached, new string[] { "Poached" })]
        [InlineData(EggStyle.Scrambled, new string[] { "Scrambled" })]
        [InlineData(EggStyle.SunnySideUp, new string[] { "Sunny Side Up" })]
        public void ShouldProvideCurrentSpecialInstructions(EggStyle style, string[] instructions)
        {
            var ee = new EvisceratedEggs();
            ee.EggStyle = style;
            Assert.Equal(instructions.Length, ee.SpecialInstructions.Count);
        }

    }

}

