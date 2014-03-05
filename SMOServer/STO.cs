using System;
using System.Threading;

namespace SMOServer
{
	public class STO
	{
		public MyOrder queue;
		private MyDevice[] dev;
		private int indexFreeDev;
		
		public STO(MyOrder queue,int delay)
		{
			this.queue=queue;
			dev=new MyDevice[3];
			for(int i=0;i<dev.Length;i++)
			{
				dev[i]=new MyDevice(i,delay);
			}
			new Thread(RunSTO).Start();
		}
		//Работа СТО
		private void RunSTO()
		{
			while(true)
			{
				GetFreeDev();
				if((queue.head!=queue.tail)&(indexFreeDev!=-1))
				{
					dev[indexFreeDev].StartFix(queue.TakeHead());
				}
				Thread.Sleep(1);
			}
		}
		//Получаем номер свободного канала
		private void GetFreeDev()
		{
			for(int i=0;i<dev.Length;i++)
			{
				if(dev[i].isFree())
				{
					indexFreeDev=i;
					break;
				}
				else
				{
					indexFreeDev=-1;
				}
			}
		}
	}
}