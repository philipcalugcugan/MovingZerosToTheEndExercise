using System;

namespace MovingZerosToTheEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *  Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
            */

            var movingZerosToTheEndHelper = new MovingZerosToTheEnd();
            var answer = movingZerosToTheEndHelper.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });

            Console.ReadLine(); // Wait for press key before exit
        }
    }
}
