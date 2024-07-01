namespace XomracLabs.Utilities.Extensions
{

	using System.Collections.Generic;
	using System.Linq;

	
	public static class ListExtensions
	{
		public static bool IsNullOrEmpty<T>(this IList<T> list)
		{
			return list == null || !list.Any();
		}
	
		public static void CloneTo<T>(this IList<T> list,ref List<T> newList)
		{
			newList = new List<T>(list);
		}

		public static void Swap<T>(this IList<T> list, int indexA, int indexB)
		{
			(list[indexA], list[indexB]) = (list[indexB], list[indexA]);
		}
	}

}