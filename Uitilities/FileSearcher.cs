using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Models
{
	public class FileSearcher
	{
		IFileSearcher action = null; 

		public void StartSearch(IFileSearcher concreteImplement, string fileName)
		{
			action = concreteImplement;
			action.Search(fileName);
		}
	}
}
