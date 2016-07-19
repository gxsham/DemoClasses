using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{
	

	class Program
	{
		static void Main(string[] args)
		{

			//AuthorFactory authorFactory = new AuthorFactory();
			User user = new User("Bejenari",  "Marian" );

			AuthorFactory authorFactory = AuthorFactory.Instance;

			Author author = authorFactory.CreateNewAuthor("Sergiu", "Bordea");


			Admin admin = new Admin("secret","Dorin", "Balan");

			Author[] ArrayAuthor = { author, admin};


			NewsFactory newsFactory = NewsFactory.Instance;

			author.Addarticle( newsFactory.CreateNews("Pluto",Categories.Astronomy, "Pluto is not a planet anymore"));
			admin.Addarticle(newsFactory.CreateNews("Xiaomi", Categories.HiTech | Categories.International, "Realesed Mi5 phone"));
			admin.Addarticle(newsFactory.CreateNews("Torrentsmd", Categories.Social | Categories.HiTech, "Becasue of anti-piratery law torrentsmd was closed"));
			
			Console.WriteLine("Sort by number of articles");
			Array.Sort(ArrayAuthor, Author.SortByArticles);
			foreach (Author element in ArrayAuthor)
				Console.WriteLine(element.ToString());

			Author DecorableAuthor = authorFactory.CreateNewAuthor("Decorable","Author");

			AuthorDecorator decAuthor = new CategoryAuthorDecorator(DecorableAuthor) {LikedCategory = "IT" };

			var decAuthorInfo = decAuthor.DisplayInfo();

			Console.WriteLine(decAuthorInfo);

			ProxyAdmin ProxyAdmin = new ProxyAdmin("proxypassword");
			Console.WriteLine(ProxyAdmin.GetRights());
			Console.ReadKey();
			


		}

		
	}
}
