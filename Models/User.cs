using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Interfaces;

namespace DemoClasses
{
	public class User :  IGetRight
	{

		public  string Name { get; set; }
		
		public string Surname { get; set; }

		private IMusicPlayer _musicPlayer;
		
		internal User(IMusicPlayer musicPlayer,string name = "Anonim", string surname = "Anonim")
		{
			Name = name;
			Surname = surname;
			this._musicPlayer = musicPlayer;
		}
		internal User( string name = "Anonim", string surname = "Anonim")
		{
			Name = name;
			Surname = surname;
		}

		public void StartPlayer()
		{
			_musicPlayer.Play();
		}

		public virtual string GetRights() => "User";
		

		public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
		
		
		
	}
}
