using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEKENTUCKYUNDERGROUND
{
    internal class Distance
    {
        public static float ArrayDistanceFunction(float[] array1, float[] array2)
        {
            float total = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                total += Math.Abs(array1[i] - array2[i]);
            }
            return total;
        }
    }
}
