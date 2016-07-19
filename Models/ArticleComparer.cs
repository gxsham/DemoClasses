using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{
	public class ArticleComparer : IComparer
	{
		public int Compare(object x, object y)
		{
			Author a1 = (Author)x;
			Author a2 = (Author)y;
			return a1.CompareTo(a2);
		}

	}
}
