﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//SostavMeropriyatiya
	[Маршрут("Справочники/СоставМероприятия","")]
	public class СоставМероприятияЗапрос: V82.СправочникиСсылка.СоставМероприятия,IReturn<СоставМероприятияЗапрос>
	{
	}
	[Маршрут("Справочники/СоставМероприятия/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СоставМероприятия/ПоСсылке","{Ссылка}")]
	public class СоставМероприятияНайтиПоСсылке: V82.СправочникиСсылка.СоставМероприятия,IReturn<СоставМероприятияНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СоставМероприятия/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СоставМероприятия/ПоКоду","{Код}")]
	public class СоставМероприятияНайтиПоКоду: V82.СправочникиСсылка.СоставМероприятия,IReturn<СоставМероприятияНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СоставМероприятия/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СоставМероприятия/ПоНаименованию","{Наименование}")]
	public class СоставМероприятияНайтиПоНаименованию: V82.СправочникиСсылка.СоставМероприятия,IReturn<СоставМероприятияНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СоставМероприятия/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СоставМероприятия/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СоставМероприятия/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СоставМероприятияВыбратьПоСсылке: V82.СправочникиСсылка.СоставМероприятия,IReturn<СоставМероприятияВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СоставМероприятия/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/СоставМероприятия/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СоставМероприятия/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СоставМероприятияВыбратьПоКоду: V82.СправочникиСсылка.СоставМероприятия,IReturn<СоставМероприятияВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СоставМероприятия/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/СоставМероприятия/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СоставМероприятия/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СоставМероприятияВыбратьПоНаименованию: V82.СправочникиСсылка.СоставМероприятия,IReturn<СоставМероприятияВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СоставМероприятия/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СоставМероприятияСтраницаПоСсылке: V82.СправочникиСсылка.СоставМероприятия,IReturn<СоставМероприятияСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СоставМероприятия/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СоставМероприятияСтраницаПоКоду: V82.СправочникиСсылка.СоставМероприятия,IReturn<СоставМероприятияСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СоставМероприятия/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СоставМероприятияСтраницаПоНаименованию: V82.СправочникиСсылка.СоставМероприятия,IReturn<СоставМероприятияСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СоставМероприятияОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СоставМероприятияСервис : Service
	{
		
		public object Get(СоставМероприятияЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СоставМероприятияНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.СоставМероприятия.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СоставМероприятияОтвет() { Ответ = "СоставМероприятия c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СоставМероприятияНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СоставМероприятия.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СоставМероприятияОтвет() {Ответ = "СоставМероприятия c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СоставМероприятияНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СоставМероприятияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.СоставМероприятия.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СоставМероприятияВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СоставМероприятияВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СоставМероприятияСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СоставМероприятияСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СоставМероприятияСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СоставМероприятияЗапрос Запрос)
		{
			return new СоставМероприятияОтвет {Ответ = "СоставМероприятия, "};
		}

		public object Post(СоставМероприятияЗапрос ЗапросСоставМероприятия)
		{
			var Ссылка = (СправочникиСсылка.СоставМероприятия)ЗапросСоставМероприятия;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}