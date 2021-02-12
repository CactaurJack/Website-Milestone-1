/*
 * Author: Gregory Waters
 * File name: Entree.cs
 * Purpose: Abstract class meant for all Entree items to inherit
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace TheFlyingSaucer.Data.Entrees
{
    /// <summary>
    /// Establishes variables found in every entree class
    /// </summary>
    public abstract class Entree
    {
        string Name;
        string Description;
        decimal Price;
        uint Calories;
        List<string> SpecialInstructions;
    }
}
