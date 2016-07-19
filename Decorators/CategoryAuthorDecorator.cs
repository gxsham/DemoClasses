using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{
	public class CategoryAuthorDecorator : AuthorDecorator
	{
		public string LikedCategory { get; set; }
		public CategoryAuthorDecorator (IDisplayInfo baseAuthorInfo) : base(baseAuthorInfo)
		{

		}

		public override string DisplayInfo()
		{
			var result = base.DisplayInfo();
			result = $"{result} Liked Category is {LikedCategory}";
			return result;
		}
	}
}
