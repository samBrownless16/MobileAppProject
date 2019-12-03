using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAppProject
{
    class Questions
    {
        public void ShuffleArrays(int[] arr)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int index, temp;

            for (int i = arr.Length - 1; i > 0; i--)
            {
                index = rand.Next(i);
                temp = arr[index];
                arr[index] = arr[i];
                arr[i] = temp;
            }
        }
    }
}