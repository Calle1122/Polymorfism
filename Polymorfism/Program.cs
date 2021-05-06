using System;
using System.Collections.Generic;

namespace Polymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<creature> creatureList = new List<creature>();

            teacher someTeacher = new teacher();
            student someStudent = new student();

            creatureList.Add(someTeacher);
            creatureList.Add(someStudent);

            foreach (creature creature in creatureList)
            {
            creature.Talk();
            }

            Console.ReadLine();
            
        }
    }
}
