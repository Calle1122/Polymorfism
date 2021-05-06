using System;

namespace Polymorfism
{
    public class student : creature
    {
        public override void Talk()
        {
            Console.WriteLine("\nStudent says:");
            Console.WriteLine("Noooooo! I don't want to.");
        }
    }
}
