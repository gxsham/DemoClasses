using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class Music : IMusicPlayer
	{
		private List<string> _playList = new List<string>() { "song1", "song2" };
		IFileSearcher action = null;
		
		public void Play()
		{
			Console.WriteLine(_playList.First());
		}

		public void Pause()
		{
			Console.WriteLine("Pause");
		}

		public void Stop()
		{
			Console.WriteLine("Stop");
		}
	}
}

