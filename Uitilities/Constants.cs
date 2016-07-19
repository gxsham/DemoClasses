using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{


	[Flags]
	public enum Categories { Astronomy = 0x01, Social = 0x02, HiTech = 0x04, International = 0x08, Common = 0 }
	public static class Constants
	{
		public const int INT_KEY = 2131;
		public const string STR_KEY = "asfaags";
	}
}
