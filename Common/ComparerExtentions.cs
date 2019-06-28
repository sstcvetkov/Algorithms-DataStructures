using System;
using System.Collections.Generic;

namespace Common
{
	public static class ComparerExtentions
	{
		/// <summary>
		/// Determines if the values are equal.
		/// </summary>
		/// <returns>
		/// <c>true</c> if first is equals to the second; otherwise, <c>false</c>.
		/// </returns>
		/// <param name="first">The first value.</param>
		/// <param name="second">The second value.</param>
		/// <param name="comparer"></param>
		/// <typeparam name="T">The Type of values.</typeparam>
		public static bool IsEqualTo<T>(this T first, T second, IComparer<T> comparer = null) 
			where T : IComparable<T>
		{
			return (comparer?.Compare(first, second) ?? first.CompareTo(second)) == 0;
		}

		public static bool IsGreaterThan<T>(this T first, T second, IComparer<T> comparer) 
			where T : IComparable<T>
		{
			return (comparer?.Compare(first, second) ?? first.CompareTo(second)) > 0;
		}

		public static bool IsGreaterThanOrEqualTo<T>(this T first, T second, IComparer<T> comparer) 
			where T : IComparable<T>
		{
			return (comparer?.Compare(first, second) ?? first.CompareTo(second)) >= 0;
		}

		public static bool IsLessThan<T>(this T first, T second, IComparer<T> comparer) 
			where T : IComparable<T>
		{
			return (comparer?.Compare(first, second) ?? first.CompareTo(second)) < 0;
		}

		public static bool IsLessThanOrEqualTo<T>(this T first, T second, IComparer<T> comparer) 
			where T : IComparable<T>
		{
			return (comparer?.Compare(first, second) ?? first.CompareTo(second)) <= 0;
		}
	}
}
