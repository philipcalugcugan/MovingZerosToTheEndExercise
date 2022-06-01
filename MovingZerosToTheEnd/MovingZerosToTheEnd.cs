using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingZerosToTheEnd
{
    public class MovingZerosToTheEnd
    {
        public int[] MoveZeroes(int[] arr)
        {
            var nonZeroes = arr.ToList().Where(w => w != 0).ToList();
            var zeroes = arr.ToList().Where(z => z == 0).ToList();
            var newArrangedList = new List<int>();
            newArrangedList.AddRange(nonZeroes);
            newArrangedList.AddRange(zeroes);

            return newArrangedList.ToArray();
        }
    }
}
