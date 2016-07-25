using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DemoClasses;

namespace DemoClasses
{
	public class Author :User, IComparable , IDisplayInfo
	{

		internal List<News> articlesList = new List<News>();
		internal int ArticlesNumber
		{
			get { return articlesList.Count; }
		}

		public  Author(string name = "Anonim" , string surname = "Author")
		{
			this.Name = name;
			this.Surname = surname;
		}

		//string formating 
		public override string ToString() => $"{Name} {Surname}\t:{ArticlesNumber}";
		


		//string formating 
		public override string GetRights() => $"{base.GetRights()} Author";
		

		internal void Addarticle( News news )
		{
			articlesList.Add(news);
		}

		internal News[] GetArticlesList() => articlesList.ToArray();
		


		public static IComparer SortByArticles
		{
			get { return (IComparer)new ArticleComparer(); }
		}


		public int CompareTo(object obj)
		{
			Author temp = (Author)obj;
			if (this.ArticlesNumber > temp.ArticlesNumber)
				return 1;
			if (this.ArticlesNumber < temp.ArticlesNumber)
				return -1;
			else
				return 0;
		}

		public string DisplayInfo()
		{
			return $"{Name} {Surname} has {ArticlesNumber} articles.";
		}

		
	}
}
