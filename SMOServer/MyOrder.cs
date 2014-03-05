using System;
using System.Net.Sockets;

namespace SMOServer
{
	
	public class MyOrder
	{
		public int head;			//"Голова" массива
		public int tail;			//"Хвост" массива
		private Socket[] array;		//Массив сокетов
		private int temp;			//Временная переменная для проверки на переполнение очереди
		private int arraySize;
		
		public MyOrder(int arraySize)
		{
			//Создаем пустой массив
			this.arraySize=arraySize;
			array=new Socket[arraySize];
			head=0;
			tail=0;
		}
		
		public void AddToOrder(Socket handler)
		{
			temp=tail+1;
			if(temp>=arraySize)
			{
				temp=0;
			}
			if(temp==head)
			{
				AddToLog("Переполнение очереди");
			}
			else
			{
				array[tail]=handler;
				tail=temp;
			}	
		}
		
		public void DelFromOrder()
		{
			if(head==tail)
			{
				AddToLog("Очередь пуста");
				
			}
			else
			{
				array[head]=null;
				head++;
				if(head>=arraySize)
				{
					head=0;
				}
			}
		}
		//Просто берем первый головной(head) элемент и удаляем его из очереди
		public Socket TakeHead()
		{
			Socket handler=array[head];
			DelFromOrder();
			return handler;
		}
		
		//Добавление в лог
		private void AddToLog(string str)
		{
			Console.WriteLine(System.DateTime.Now + " " + str);
		}
	}
}