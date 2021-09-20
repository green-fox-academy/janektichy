using System;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();
            Thing first = new Thing("Get milk");
            Thing second = new Thing("Remove the obstacles");
            Thing third = new Thing("Stand up");
            Thing fourth = new Thing("Eat lunch");

            
            fleet.Add(first);
            fleet.Add(second);
            fleet.Add(third);
            fleet.Add(fourth);

            first.Complete();
            first.ShowThing();

        }
    }
}
