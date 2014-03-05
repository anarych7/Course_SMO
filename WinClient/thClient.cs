using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace WinClient
{
	class thClient
	{
		public IPEndPoint ipep;
		public Socket handler;
		public byte[] buff = new byte[1024];
		public string msg;
		public MainWindow window;
		
		public thClient(string ip, string port, string msg, MainWindow window)
		{
			ipep = new IPEndPoint(IPAddress.Parse(ip), Convert.ToInt32(port));
			handler = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			this.msg = msg;
			this.window = window;
			new Thread(startClient).Start();
		}
		
		public void startClient()
		{
			try
			{
				handler.Connect(ipep);
				handler.Send(Encoding.UTF8.GetBytes(msg));
				string data = null;
				while(true)
				{
					byte[] buff = new byte[1024];
					data += Encoding.UTF8.GetString(buff, 0, handler.Receive(buff));
					if(data.IndexOf("") > -1)
					{
						handler.Close();
						break;
					}
				}
				window.AddToLog(data);
			}
			catch(Exception e)
			{
				handler.Close();
				window.AddToLog(e.Message);
			}
		}
	}
}