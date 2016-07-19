using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{
	public class AuthorFactory
	{

		public static readonly Lazy<AuthorFactory> lazy = new Lazy<AuthorFactory>(() => new AuthorFactory(), true);
		public static AuthorFactory Instance { get { return lazy.Value; } }

		AuthorFactory()
		{
		}
		public  Author CreateNewAuthor(string name ,string surname)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("Name is mandatory");
			}
			if (string.IsNullOrWhiteSpace(surname))
			{
				throw new ArgumentException("Surname is mandatory");
			}

			var author = new Author(name, surname);
			return author; 
		}

		public  Author ImportAuthor(string name, string surname, List<News> newsList)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("Name is mandatory");
			}
			if (string.IsNullOrWhiteSpace(surname))
			{
				throw new ArgumentException("Surame is mandatory");
			}


			var author = new Author(name, surname);
			if (newsList!= null)
			{
				author.articlesList = newsList;
			}

			return author;
		}
	}
}
