using System;

namespace BinarySearch
{
	public static class BinarySearch
	{
		/// <summary>
		/// Returns the first index of a given integer in an array of integers or -1 if not found.
		/// </summary>
		/// <param name="searchValue"></param>
		/// <param name="arr"></param>
		/// <returns>The index of the value in the array or -1 if not found.</returns>
		public static int Search(int searchValue, int[] arr)
		{
			if (arr is null) throw new ArgumentNullException(nameof(arr));

			int lowerBound = 0;
			int upperBound = arr.Length - 1;
			while (lowerBound < searchValue)
			{
				var middle = (int) Math.Floor((lowerBound + upperBound) / 2f);
				if (arr[middle] == searchValue)
				{
					return middle;
				}

				if (arr[middle] < searchValue)
				{
					lowerBound = middle + 1;
				}
				else if (arr[middle] > searchValue)
				{
					upperBound = middle - 1;
				}
			}

			return -1;
		}
	}
}
