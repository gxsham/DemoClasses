using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{
	public sealed class Admin : Author, IEncryptable
	{

		private string password { get; set;  }
		
		
		internal Admin(string password,string name = "Anonim", string surname = "Admin")
		{
			this.Name = name;
			this.Surname = surname;
			this.password = password;
		}


		public override string GetRights() => $"{base.GetRights()} Admin";


		public string GetEncryptedPassword() => SetEncryptedPassword(password);


		public string GetEncryptedPassword(int key) => SetEncryptedPassword($"{password}{key}");


		public string GetEncryptedPassword(int key, string offset) => SetEncryptedPassword($"{password}{key}{offset}");
		

		public string SetEncryptedPassword(string password) => Encoding.ASCII.GetBytes(password).Aggregate(string.Empty, (a, b) => a + b);
		
	}

	

}
