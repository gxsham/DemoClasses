﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{
	public class ProxyAdmin :IEncryptable
	{
		private Admin _admin;

		public ProxyAdmin(string pass)
		{
			_admin = new Admin(pass);
		}

		public string GetEncryptedPassword()
		{
			return _admin.GetEncryptedPassword();
		}
		public string GetEncryptedPassword(int key)
		{
			return _admin.GetEncryptedPassword(key);
		}
		public string GetEncryptedPassword(int key, string offset)
		{
			return _admin.GetEncryptedPassword(key, offset);
		}

		public string SetEncryptedPassword(string password)
		{
			return _admin.SetEncryptedPassword(password);
		}
	}
}
