using System;
using System.Collections.Generic;
using System.Text;

namespace TheFlyingSaucer.Data
{
    public interface IOrderItem
    {
        string Name { get; }
        decimal Price { get; set; }
        uint Calories { get; set; }
        List<string> SpecialInstructions {get; set;}
    }
}
