using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheFlyingSaucer.Data.Sides;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.DataTests.Sides
{
    public class CropCircleOatsTests
    {
        [Theory]
        [InlineData(Size.Small, "Small Crop Circle Oats")]
        [InlineData(Size.Medium, "Medium Crop Circle Oats")]
        [InlineData(Size.Large, "Large Crop Circle Oats")]
        public void NameIsCorrectForSize(Size size, string name)
        {
            var cco = new CropCircleOats();
            cco.Size = size;
            Assert.Equal(size, cco.Size);
            Assert.Equal(name, cco.Name);
        }

        [Fact]
        public void DescriptionIsCorrect()
        {
            var cco = new CropCircleOats();
            Assert.Equal("A hearty oatmeal doused in butter and your choice of syrup." , cco.Description);
        }

        [Theory]
        [InlineData(Size.Small, 158)]
        [InlineData(Size.Medium, 316)]
        [InlineData(Size.Large, 484)]
        public void CaloriesAreCorrectForSize(Size size, uint calories)
        {
            var cco = new CropCircleOats();
            cco.Size = size;
            Assert.Equal(calories, cco.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 1.5)]
        [InlineData(Size.Medium, 2.0)]
        [InlineData(Size.Large, 2.5)]
        public void PriceIsCorrect(Size size, decimal price)
        {
            var cco = new CropCircleOats();
            cco.Size = size;
            Assert.Equal(price, cco.Price);
        }

        [Fact]
        public void ShouldBeAbleToSetButter()
        {
            var cco = new CropCircleOats();
            Assert.Equal(true, cco.Butter);
            cco.Butter = false;
            Assert.Equal(false, cco.Butter);
        }

        [Theory]
        [InlineData(SyrupFlavor.Maple)]
        [InlineData(SyrupFlavor.Blackberry)]
        [InlineData(SyrupFlavor.Blueberry)]
        [InlineData(SyrupFlavor.Cherry)]
        [InlineData(SyrupFlavor.Strawberry)]

        public void ShouldBeAbleToSetSyrupFlavor(SyrupFlavor flavor)
        {
            var cco = new CropCircleOats();
            cco.SyrupFlavor = flavor;
            Assert.Equal(flavor, cco.SyrupFlavor);
        }

        [Theory]
        [InlineData(true, SyrupFlavor.Blackberry, new String[] { "Blackberry Syrup" })]
        [InlineData(true, SyrupFlavor.Blueberry, new String[] { "Blueberry Syrup" })]
        [InlineData(true, SyrupFlavor.Cherry, new String[] { "Cherry Syrup" })]
        [InlineData(true, SyrupFlavor.Maple, new String[] { "Maple Syrup" })]
        [InlineData(true, SyrupFlavor.Strawberry, new String[] { "Strawberry Syrup" })]
        [InlineData(false, SyrupFlavor.Blackberry, new String[] { "Hold Butter" , "Blackberry Syrup" })]
        [InlineData(false, SyrupFlavor.Blueberry, new String[] { "Hold Butter", "Blueberry Syrup" })]
        [InlineData(false, SyrupFlavor.Cherry, new String[] { "Hold Butter", "Cherry Syrup" })]
        [InlineData(false, SyrupFlavor.Maple, new String[] { "Hold Butter", "Maple Syrup" })]
        [InlineData(false, SyrupFlavor.Strawberry, new String[] { "Hold Butter", "Strawberry Syrup" })]
        public void ShouldProvideCurrentSpecialInstructions(bool butter, SyrupFlavor flavor, string[] instructions)
        {
            var cco = new CropCircleOats();
            cco.Butter = butter;
            cco.SyrupFlavor = flavor;
            Assert.Equal(butter, cco.Butter);
            Assert.Equal(flavor, cco.SyrupFlavor);
            Assert.Equal(instructions.Length, cco.SpecialInstructions.Count);
        }
    }
}
