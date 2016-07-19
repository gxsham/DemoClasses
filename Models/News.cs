using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoClasses
{
	public class News
	{
		internal Categories Categories { get; set; }
		
		internal string Topic { get; set; }
		internal string Text { get; set; }
		internal DateTime CreationTime { get; }

		//Date time 
		internal News(string topic, Categories cat, string text = null)
		{
			Topic = topic;
			Categories = cat;
			Text = text;
			CreationTime = DateTime.Now;
		}

		public override string ToString() => $"{Topic.ToUpper()}\t{Categories.ToString().ToLower()}\t{Text}";
		
	}
}
