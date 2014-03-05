using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

using System.Threading;

namespace SMOServer
{
	public class MyDevice
	{
		private int id;
		private string state;
		public Socket handler;
		private int delay;
		
		public MyDevice(int id, int delay)
		{
			this.id=id;
			this.delay=delay;
			state="free";	
		}
		
		public bool isFree()
        {
            return state == "free";
        }
		
		public void StartFix(Socket handler)
		{
			state="busy";
			this.handler=handler;
			new Thread(Fix).Start();
		}
		//Обработка заявок
		private void Fix()
		{
			AddToLog("dev"+Convert.ToString(id)+" busy");
			//Очистка строки для хранения переданных данных от клиента
			string data=null;
			//Начинаем принимать данные
			while(true)
			{
				//Буфер для данных от клиента
				byte[] buff = new byte[1024];
				//Накапливаем данные в data
				data += Encoding.UTF8.GetString(buff, 0, handler.Receive(buff));
				//Читаем до конца строки
				if(data.IndexOf("")>-1)
				{
					break;
				}
			}
			//Определяем тип заявки
			//Обычная заявка на обработку должна иметь формат "{<Любой_текст>}"
			//Заявка на расчет характеристик СМО должна иметь формат
			//"[<количество каналов СМО>|<интенсивность входного потока>|<интенсивность обслуживания>|<размер очереди>|"
			switch(data[0])
			{
				case '{':
					Random R = new Random();
					data+="       	(dev"+Convert.ToString(id)+")";
					Thread.Sleep(R.Next((int)delay - (int)(delay/2), (int)delay + ((int)delay/2)));
					handler.Send(Encoding.UTF8.GetBytes(data));
					handler.Close();
					AddToLog("dev"+Convert.ToString(id)+" free");
					state="free";
					break;
				case '[':
					data=Calculate(data);
					handler.Send(Encoding.UTF8.GetBytes(data));
					handler.Close();
					AddToLog("dev"+Convert.ToString(id)+" free");
					state="free";
					break;
			}
		}
		//Расчет характеристик СМО
		private string Calculate(string str)
		{
			long n=0;
			double lambda=0;
			double mu=0;
			long m=0;
			long[] param_mas=new long[4];
			int imas=0;
			string tmp=null;
			
			for(int index=1;index<str.Length;index++)
			{
				if(str[index]!='|')
				{
					tmp+=str[index];
				}
				else
				{
					param_mas[imas]=Convert.ToInt64(tmp);
					imas++;
					tmp=null;
				}
			}
			n=param_mas[0];
			lambda=param_mas[1];
			mu=param_mas[2];
			m=param_mas[3];
			double[] p_mas=new double[n+m+1];
			double alfa=lambda/mu;
			double P0=1;
			long k;
			for(k=1;k<=n;k++)
			{
				P0+=Math.Pow(alfa,k)/fact(k);
			}
			
			if(m!=0)
			{
				for(k=n+1;k<=n+m;k++)
				{
					P0+=Math.Pow(alfa,k)/(fact(n)*Math.Pow(n,k-n));	
				}
			}
			P0=1/P0;
			p_mas[0]=P0;
			tmp="Характеристики СМО"+Environment.NewLine;
			tmp+="Alfa="+Convert.ToString(alfa)+Environment.NewLine;
			tmp+="P0="+Convert.ToString(P0)+Environment.NewLine;
			double p_sum=0;
			for(k=1;k<=n;k++)
			{
				p_mas[k]=(Math.Pow(alfa,k)/fact(k))*P0;
				p_sum+=p_mas[k];
				tmp+="P"+Convert.ToString(k)+"="+Convert.ToString(p_mas[k])+Environment.NewLine;
			}
			for(k=n+1;k<=n+m;k++)
			{
				p_mas[k]=(Math.Pow(alfa,n+k)/(Math.Pow(n,k)*fact(n)))*P0;
				p_sum+=p_mas[k];
				tmp+="P"+Convert.ToString(k)+"="+Convert.ToString(p_mas[k])+Environment.NewLine;
			}
			p_sum+=p_mas[0];
			tmp+="sumP="+Convert.ToString(p_sum)+Environment.NewLine;
			double L_order=(Math.Pow(alfa,n+m)*P0)/(n*fact(n)*Math.Pow(1-alfa/n,2));
			tmp+="Среднее число заявок в очереди="+Convert.ToString(L_order)+Environment.NewLine;
			double T_order=(Math.Pow(alfa,n)*P0)/(n*mu*fact(n)*Math.Pow(1-alfa/n,2));
			tmp+="Среднее время ожидания в очереди="+Convert.ToString(T_order)+Environment.NewLine;
			double L_SMO=L_order+alfa;
			tmp+="Среднее число заявок в СМО "+Convert.ToString(L_SMO)+Environment.NewLine;
			return tmp;
		}
		
		//Факториал
		public int fact(long num)
		{
			int fact=1;
			for (int i=1;i<=num;i++)
			{
				fact=i*fact;
			}
			return fact;
		}
		
		//Добавление в лог
		private void AddToLog(string str)
		{
			Console.WriteLine(System.DateTime.Now + "	" + str);
		}
	}
}