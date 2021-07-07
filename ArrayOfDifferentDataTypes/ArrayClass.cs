using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfDifferentDataTypes
{
    class ArrayClass
    {
        //To print the int array
        public static void ToPrintIntArray(int[] intArray)
        {
            foreach(var ele in intArray)
            {
                Console.Write(ele + " ");
            }
          
        }
        //To print float array
        public static void ToPrintFloatArray(float[] floatArray)
        {
            foreach (var ele in floatArray)
            {
                Console.Write(ele + " ");
            }
          
        }
        //To print char array
        public static void ToPrintCharArray(char[] charArray)
        {
            foreach (var ele in charArray)
            {
                Console.Write(ele + " ");
            }

        }
    }
}
