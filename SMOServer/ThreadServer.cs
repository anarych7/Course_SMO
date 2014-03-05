using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SMOServer
{
	public class ThreadServer
	{
		private string		ip;				//IP адрес сервера
		private string		port;			//Порт сервера
		private IPEndPoint	ipep;			//Конечная точка для подсоединения сокета
		public Socket		ServerSocket;	//Сокет на стороне сервера
		public MyOrder		OrderOfQueue;	//Очередь заявок
		public int			Delay;			//Задержка для эмуляции обработки заявки
		
		public ThreadServer()
		{
			Configure();
		}
		//Настраиваем сервер
		public void Configure()
		{
			Console.WriteLine("Настройка сервера");
			Console.WriteLine("Начать? (yes/no)");
			string answer=Console.ReadLine();
			if(answer=="yes")
			{
				Console.Clear();
				Console.Write("Введите IP адрес сервера в формате xxx.xxx.xxx.xxx:");
				ip=Console.ReadLine();
				Console.Write("Введите номер свободного порта:");
				port=Console.ReadLine();
				Console.Write("Введите интенсивность обслуживания в минуту:");
				string sDelay=Console.ReadLine();
				try
				{
					//Создаем конечную точку ipep
					ipep = new IPEndPoint(IPAddress.Parse(ip), Convert.ToInt32(port));
					//Создаем объект Socket(для работы в сети, потоковый, используя протокол Tcp)
					ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					//Задержка для эмулирования работы над зявкой
					Delay=(60/Convert.ToInt32(sDelay))*1000;
					Console.Clear();
					//Запускаем сервер
					new Thread(StartServer).Start();
				}
				catch
				{
					Console.Clear();
					Console.WriteLine("Что-то пошло не так. Поверьте правильность вводимых данных.");
					Configure();
				}
			}
			else
			{
				Console.WriteLine("Спасибо за использования данной программы!");
			}
		}
		
		public void StartServer()
		{
			//Очередь на 50000 мест
			OrderOfQueue=new MyOrder(50000);
			
			//Пункт обслуживания заявок(3 канала)
			new STO(OrderOfQueue,Delay);
			
			//Пытаемся создать сервер
			try
			{
				ServerSocket.Bind(ipep);	//Связываем сокет на сервере с конечной точкой
				ServerSocket.Listen(50000);	//Переводим сокет сервера в режим прослушивания
				AddToLog("Ожидаем подключения клиентов для обслуживания");
				//Ожидаем клиентов
				while(true)
				{
					//При подключении клиента, добавляем его в очередь
					OrderOfQueue.AddToOrder(ServerSocket.Accept());
				}
			}
			//Ловим исключения
			catch(Exception e)
			{
				//Останавливаем сервер
				ServerSocket.Close();
				AddToLog("Ошибка:" + e.Message);
			}
		}
		//Добавление в лог
		private void AddToLog(string str)
		{
			Console.WriteLine(System.DateTime.Now + " " + str);
		}
	}
}