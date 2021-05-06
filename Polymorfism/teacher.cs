using System;

namespace Polymorfism
{
    public class teacher : creature
    {
        override public void Talk(){
            Console.WriteLine("Hand in your homework... NOW!");
        }
    }
}
