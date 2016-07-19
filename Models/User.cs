using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DemoClasses
{
	public class User :  IGetRight
	{

		public  string Name { get; set; }
		
		public string Surname { get; set; }
		
		internal User( string name = "Anonim", string surname = "Anonim")
		{
			Name = name;
			Surname = surname;
		}
		

		public virtual string GetRights() => "User";
		

		public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
		
		
		
	}
}
