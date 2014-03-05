using Gtk;
using System;
using System.Threading;
using WinClient;
using System.ComponentModel;

public partial class MainWindow : Gtk.Window
{
	private string ip;
	private string port;
	private int count;

	private string n;
	private string lambda;
	private string mu;
	private string m;
	
	public string strINFO;
	public double delay;
	
	public MainWindow () : base(Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected virtual void RunClient (object sender, System.EventArgs e)
	{
		new Thread(gen).Start();
	}
	
	private void gen()
	{
		Log.Buffer.Text = "";
		try
		{
			if(rbQUEUE.Active)
			{
				ip = entryIP.Text;
				port = entryPORT.Text;
				count = Convert.ToInt32(entryCOUNT.Text);
				delay = Convert.ToInt32(entryDELAY.Text);
				Random R = new Random();
				for(int i = 1; i <= count; i++)
				{
					new thClient(ip, port, "{Заявка №" + Convert.ToString(i)+"}", this);
					Thread.Sleep(R.Next((int)delay - (int)(delay/2), (int)delay + ((int)delay/2)));
				}
			}
			else
			{
				ip = entryIP.Text;
				port = entryPORT.Text;
				n = entryN.Text;
				lambda = entryLAMBDA.Text;
				mu = entryMU.Text;
				m = entryM.Text;
				new thClient(ip, port, "[" + n + "|" + lambda + "|" + mu + "|" + m + "|", this);
			}
		}
		catch
		{
			ip = null;
			port = null;
			n = null;
			lambda = null;
			mu = null;
			m = null;
			Log.Buffer.Text = "";
			AddToLog("Что-то пошло не так. Поверьте правильность вводимых данных.");
		}
	}
	
	public void AddToLog(string str)
	{
		Gtk.Application.Invoke(delegate{Log.Buffer.Text += System.DateTime.Now + "	" + str + Environment.NewLine;});
	}
}