using DataStructures.Array;
using DataStructures.LinkedList.Singly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2024
{
    public class Checker<T>
    {
        private int FindMax(int[] nums)
        {
            int max = nums[0];
            int i = 1;
            while (i < nums.Length)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                i++;
            }
            return max;
        }

        // Int - FLoat - Double
        // [1, 2, 5, 9, 8, 1, 2, 3, 5, 2] -> first: 2, second: 1
        public bool ContainsDuplicate(int[] nums)
        {
            int[] duplicate = new int[FindMax(nums) + 1]; // 10
            foreach (int num in nums)
            {
                duplicate[num]++;
            }

            // First and second duplicate
            int first = duplicate[0], second = duplicate[1];

            for (int i = 2; i < duplicate.Length; i++)
            {
                if (second > first)
                {
                    var temp = first;
                    first = second;
                    second = temp;
                }

                if (duplicate[i] > first)
                {
                    first = duplicate[i];
                }

                if (duplicate[i] > second)
                {
                    second = duplicate[i];
                }
            }

            Console.WriteLine($"First: {Array.IndexOf(duplicate, first)}, Second: {Array.IndexOf(duplicate, second)}");

            // Duplicate
            foreach (int num in duplicate)
            {
                if (num >= 2)
                {
                    return true;
                }
            }
            return false;
        }

        public SinglyLinkedList<T> ReverseList(SinglyLinkedListNode<T> head)
        {
            SinglyLinkedList<T> reverse = new SinglyLinkedList<T>();

            var temp = head;
            while (temp != null)
            {
                reverse.AddFirst(temp.Value);
                temp = temp.Next;
            }

            return reverse;
        }

        public SinglyLinkedList<T> ToSinglyLinkedList(Array<T> array)
        {
            SinglyLinkedList<T> values = new SinglyLinkedList<T>();

            for (int i = 0; i < array.Count; i++)
            {
                values.AddLast(array[i]);
            }

            return values;
        }
    }
}
