using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class BinarySearch<T> where T : IComparable
    {
        //实现二分查找，方法名BinarySeek(int[] numbers, int target)：
        //传入一个有序（从大到小 / 从小到大）数组和数组中要查找的元素
        //  如果找到，返回该元素所在的下标；否则，返回 - 1
        static int BinarYseek(T[] numbers, T target) {
            int left = 0, right = numbers.Length - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (target.CompareTo(numbers[middle]) == 0) /*target == numbers[middle]*/
                {
                    return middle;
                }
                else if (target.CompareTo(numbers[middle]) > 0)/*target > numbers[middle]*/
                {
                    left = middle + 1;
                }
                else if (target.CompareTo(numbers[middle]) < 0) /*target < numbers[middle]*/
                {
                    right = middle - 1;
                } // else  nothing          
            }
            return -1;
        }

        public T GetMax(T[] array) {

            T max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max.CompareTo(array[i]) < 0)
                {
                    max = array[i];
                }
            }
            return max;

        }


    }
}
