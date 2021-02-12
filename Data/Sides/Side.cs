using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.Data.Sides
{
    public abstract class Side
    {
        string Name;
        string Description;
        decimal Price;
        uint Calories;
        List<string> SpecialInstructions;
        Size Size;
    }
}
