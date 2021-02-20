using System;
using System.Collections.Generic;
using System.Text;
using TheFlyingSaucer.Data;
using TheFlyingSaucer.Data.Entrees;

namespace TheFlyingSaucer.Data
{
    public class Menu
    {
        private List<IOrderItem> entrees;
        private List<IOrderItem> sides;
        private List<IOrderItem> drinks;
        private List<IOrderItem> full;

        public IEnumerable<IOrderItem> Entrees()
        {   
            entrees.Add(new Entrees.CrashedSaucer());
            entrees.Add(new Entrees.FlyingSaucer());
            FlyingSaucer temp = new Entrees.FlyingSaucer();
            temp.HalfStack = true;
            entrees.Add(temp);
            entrees.Add(new Entrees.LivestockMutilation());
            entrees.Add(new Entrees.NothingToSeeHere());
            entrees.Add(new Entrees.OuterOmelette());
            entrees.Add(new Entrees.SpaceScramble());
            return entrees;
        }

        public IEnumerable<IOrderItem> Sides()
        {
            sides.Add(new Sides.CropCircleOats());
            sides.Add(new Sides.EvisceratedEggs());
            sides.Add(new Sides.GlowingHaystack());
            sides.Add(new Sides.MissingLinks());
            sides.Add(new Sides.TakenBacon());
            sides.Add(new Sides.YoureToast());
            return sides;
        }

        public IEnumerable<IOrderItem> Drinks()
        {
            drinks.Add(new Drink.LiquifiedVegetation());
            drinks.Add(new Drink.SaucerFuel());
            drinks.Add(new Drink.Water());
            return drinks;
        }

        public IEnumerable<IOrderItem> Full()
        {
            full.Add(new Entrees.CrashedSaucer());
            full.Add(new Entrees.FlyingSaucer());
            full.Add(new Entrees.LivestockMutilation());
            full.Add(new Entrees.NothingToSeeHere());
            full.Add(new Entrees.OuterOmelette());
            full.Add(new Entrees.SpaceScramble());

            full.Add(new Sides.CropCircleOats());
            full.Add(new Sides.EvisceratedEggs());
            full.Add(new Sides.GlowingHaystack());
            full.Add(new Sides.MissingLinks());
            full.Add(new Sides.TakenBacon());
            full.Add(new Sides.YoureToast());

            full.Add(new Drink.LiquifiedVegetation());
            full.Add(new Drink.SaucerFuel());
            full.Add(new Drink.Water());
            return full;
        }



    }
}
