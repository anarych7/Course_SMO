using System;
using Gtk;
using System.Threading;

namespace WinClient
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init();
			MainWindow Win = new MainWindow();
			Win.ShowAll();
			Application.Run();
		}
		static void OnWinDelete (object o, DeleteEventArgs args)
		{
			Application.Quit();
		}
	}	
}