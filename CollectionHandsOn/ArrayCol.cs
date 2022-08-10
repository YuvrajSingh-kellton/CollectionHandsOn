using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionHandsOn
{
    public class ArrayCol
    {
        public void CArray<T>(int input, string cases)
        {
            T[] arr = new T[input];
            ArrayList obj = new ArrayList();
            for (int i = 0; i < input; i++)
            {
                if (cases == "1")
                {
                    dynamic n = Convert.ToInt32(Console.Read());
                    arr[i] = n;
                }
                else if (cases == "2")
                {
                    dynamic n = Console.Read();
                    arr[i] = n;
                }
                else
                {
                    dynamic n = Convert.ToBoolean(Console.Read());
                    arr[i] = n;
                }
            }
            for (int i = 0; i < input; i++)
            {
                Console.Write(arr[i] + " ");
            }
            return;
        }
    }
}