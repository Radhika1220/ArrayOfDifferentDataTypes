using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfDifferentDataTypes
{
   public  class ArrayClass<T>

    {
        //To print the int array
        private T[] inputArray;
       public ArrayClass(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void ToPrint()
        {
            foreach(var ele in inputArray)
            {
                Console.Write(ele + " " );
            }
        }
    }
}
