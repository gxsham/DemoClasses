using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{
	public class AuthorDecorator : IDisplayInfo
	{
		IDisplayInfo baseAuthor = null; 
		internal AuthorDecorator(IDisplayInfo a)
		{
			baseAuthor = a; 
		}
		
		public virtual string DisplayInfo()
		{
			string baseInformation = baseAuthor.DisplayInfo();
			return baseInformation;
		}
		
	}
}
