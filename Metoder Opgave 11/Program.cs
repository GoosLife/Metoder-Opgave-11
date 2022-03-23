using System;

namespace Metoder_Opgave_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        /// FOR THE RECORD:
        /// The assignment specifies using lists, not arrays :)

        /// <summary>
        /// Adds two integers.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The sum of the integers.</returns>
        private static int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Divides two integers.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>x divided by y.</returns>
        private static int Divide(int x, int y)
        {
            return x / y;
        }

        /// <summary>
        /// Calculate how many times x goes into y.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The amount of times x goes into y.</returns>
        private static int GoesInto(int x, int y)
        {
            return y / x;
        }

        /// <summary>
        /// Find the largest element in a list.
        /// </summary>
        /// <param name="list"></param>
        /// <returns>The largest element in the list.</returns>
        private static int FindLargestElement(List<int> list)
        {
            // Create a copy of the list to sort
            List<int> listCopy = list;
            listCopy.Sort();

            return listCopy[listCopy.Count - 1]; // After sorting, the largest element must be the last element.
        }

        /// <summary>
        /// Find out if a list contains an element.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="x">The element to look for.</param>
        /// <returns>True if list contains x, otherwise false.</returns>
        private static bool Indeholder(List<int> list, int x)
        {
            return list.Contains(x) ? true : false;
        }

        /// <summary>
        /// Find the average from a list of integers.
        /// </summary>
        /// <param name="list"></param>
        /// <returns>The average of list.</returns>
        private static double Average(List<int> list)
        {
            double total = 0;

            for (int i = 0; i < list.Count; i++)
            {
                total += list[i];
            }

            return total / list.Count;
        }

        /// <summary>
        /// Check if a list is sorted.
        /// </summary>
        /// <param name="list"></param>
        /// <returns>True if list is sorted, otherwise false.</returns>
        private static bool IsSorted(List<int> list)
        {
            bool isSorted = true;

            // Make a copy of the list that is sorted for sure.
            List<int> listCopy = list;
            listCopy.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != listCopy[i]) // If any entry doesn't match up between the lists, the original list is not sorted.
                {
                    isSorted = false;
                    break;
                }
            }

            return isSorted;

        }
    }
}