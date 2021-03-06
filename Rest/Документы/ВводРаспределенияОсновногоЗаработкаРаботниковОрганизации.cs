﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//VvodRaspredeleniyaOsnovnogoZarabotkaRabotnikovOrganizacii
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации","")]
	public class ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииЗапрос: V82.ДокументыСсылка.ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации,IReturn<ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииЗапрос>
	{
	}
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации/ПоСсылке","{Ссылка}")]
	public class ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииНайтиПоСсылке: V82.ДокументыСсылка.ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации,IReturn<ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации/ПоНомеру","{Номер}")]
	public class ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииНайтиПоНомеру: V82.ДокументыСсылка.ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации,IReturn<ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииВыбратьПоСсылке: V82.ДокументыСсылка.ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации,IReturn<ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииВыбратьПоНомеру: V82.ДокументыСсылка.ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации,IReturn<ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииСтраницаПоСсылке: V82.ДокументыСсылка.ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации,IReturn<ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииСтраницаПоНомеру: V82.ДокументыСсылка.ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации,IReturn<ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииСервис : Service
	{
		
		public object Get(ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииОтвет() { Ответ = "ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииОтвет() {Ответ = "ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииЗапрос Запрос)
		{
			return new ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииОтвет {Ответ = "ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации, "};
		}

		public object Post(ВводРаспределенияОсновногоЗаработкаРаботниковОрганизацииЗапрос ЗапросВводРаспределенияОсновногоЗаработкаРаботниковОрганизации)
		{
			var Ссылка = (ДокументыСсылка.ВводРаспределенияОсновногоЗаработкаРаботниковОрганизации)ЗапросВводРаспределенияОсновногоЗаработкаРаботниковОрганизации;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}