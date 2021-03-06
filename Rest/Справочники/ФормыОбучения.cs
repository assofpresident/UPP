﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//FormyObucheniya
	[Маршрут("Справочники/ФормыОбучения","")]
	public class ФормыОбученияЗапрос: V82.СправочникиСсылка.ФормыОбучения,IReturn<ФормыОбученияЗапрос>
	{
	}
	[Маршрут("Справочники/ФормыОбучения/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ФормыОбучения/ПоСсылке","{Ссылка}")]
	public class ФормыОбученияНайтиПоСсылке: V82.СправочникиСсылка.ФормыОбучения,IReturn<ФормыОбученияНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ФормыОбучения/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ФормыОбучения/ПоКоду","{Код}")]
	public class ФормыОбученияНайтиПоКоду: V82.СправочникиСсылка.ФормыОбучения,IReturn<ФормыОбученияНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ФормыОбучения/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ФормыОбучения/ПоНаименованию","{Наименование}")]
	public class ФормыОбученияНайтиПоНаименованию: V82.СправочникиСсылка.ФормыОбучения,IReturn<ФормыОбученияНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ФормыОбучения/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ФормыОбучения/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ФормыОбучения/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ФормыОбученияВыбратьПоСсылке: V82.СправочникиСсылка.ФормыОбучения,IReturn<ФормыОбученияВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ФормыОбучения/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ФормыОбучения/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ФормыОбучения/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ФормыОбученияВыбратьПоКоду: V82.СправочникиСсылка.ФормыОбучения,IReturn<ФормыОбученияВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ФормыОбучения/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ФормыОбучения/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ФормыОбучения/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ФормыОбученияВыбратьПоНаименованию: V82.СправочникиСсылка.ФормыОбучения,IReturn<ФормыОбученияВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ФормыОбучения/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ФормыОбученияСтраницаПоСсылке: V82.СправочникиСсылка.ФормыОбучения,IReturn<ФормыОбученияСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ФормыОбучения/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ФормыОбученияСтраницаПоКоду: V82.СправочникиСсылка.ФормыОбучения,IReturn<ФормыОбученияСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ФормыОбучения/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ФормыОбученияСтраницаПоНаименованию: V82.СправочникиСсылка.ФормыОбучения,IReturn<ФормыОбученияСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ФормыОбученияОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ФормыОбученияСервис : Service
	{
		
		public object Get(ФормыОбученияЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ФормыОбученияНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ФормыОбучения.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ФормыОбученияОтвет() { Ответ = "ФормыОбучения c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ФормыОбученияНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ФормыОбучения.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ФормыОбученияОтвет() {Ответ = "ФормыОбучения c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ФормыОбученияНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ФормыОбученияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ФормыОбучения.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ФормыОбученияВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ФормыОбученияВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ФормыОбученияСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ФормыОбученияСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ФормыОбученияСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ФормыОбученияЗапрос Запрос)
		{
			return new ФормыОбученияОтвет {Ответ = "ФормыОбучения, "};
		}

		public object Post(ФормыОбученияЗапрос ЗапросФормыОбучения)
		{
			var Ссылка = (СправочникиСсылка.ФормыОбучения)ЗапросФормыОбучения;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}