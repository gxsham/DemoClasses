using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
namespace Uitilities
{
	public class WebSearch : IFileSearcher
	{
		public bool Search(string fileName)
		{
			Console.WriteLine($"Searching {fileName} on internet.");
			return true;
		}
	}
}
