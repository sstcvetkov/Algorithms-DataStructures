using System.Collections;
using System.Collections.Generic;

namespace Sorting.Tests
{
	public class TestData : IEnumerable<object[]>
	{
		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[] {new [] {5, 2, 4, 6, 1, 3}};
			yield return new object[] {new [] {1, -1, 0}};
			yield return new object[] {new [] {1, 1, 1}};
			yield return new object[] {new int[0]};
			yield return new object[] {new [] {1}};
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}