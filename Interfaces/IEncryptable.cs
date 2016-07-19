using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public interface IEncryptable
	{
		string GetEncryptedPassword();
		string GetEncryptedPassword(int key);
		string GetEncryptedPassword(int key, string offset);
		string SetEncryptedPassword(string password);
	}
}
