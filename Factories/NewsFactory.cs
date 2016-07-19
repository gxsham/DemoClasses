using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{
	public class NewsFactory
	{
		private static readonly Lazy<NewsFactory> lazy = new Lazy<NewsFactory>(() => new NewsFactory(), true);

		public static NewsFactory Instance { get { return lazy.Value; } }

		protected NewsFactory()
		{
		}

		public News CreateNews(string topic, Categories cat, string text = null)
		{
			if (string.IsNullOrWhiteSpace(topic))
			{
				throw new ArgumentException("No topic!");
			}

			var localNews = new News(topic, cat, text);
			return localNews;
		}

	}
}
