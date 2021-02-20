using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.Data.Drink
{
    public abstract class Drink
    {
        string Name;
        string Description;
        decimal Price;
        uint Calories;
        List<string> SpecialInstructions;
        Size Size;
    }
}
