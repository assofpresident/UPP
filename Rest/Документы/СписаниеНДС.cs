﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//SpisanieNDS
	[Маршрут("Документы/СписаниеНДС","")]
	public class СписаниеНДСЗапрос: V82.ДокументыСсылка.СписаниеНДС,IReturn<СписаниеНДСЗапрос>
	{
	}
	[Маршрут("Документы/СписаниеНДС/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/СписаниеНДС/ПоСсылке","{Ссылка}")]
	public class СписаниеНДСНайтиПоСсылке: V82.ДокументыСсылка.СписаниеНДС,IReturn<СписаниеНДСНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/СписаниеНДС/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/СписаниеНДС/ПоНомеру","{Номер}")]
	public class СписаниеНДСНайтиПоНомеру: V82.ДокументыСсылка.СписаниеНДС,IReturn<СписаниеНДСНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/СписаниеНДС/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/СписаниеНДС/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СписаниеНДС/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СписаниеНДСВыбратьПоСсылке: V82.ДокументыСсылка.СписаниеНДС,IReturn<СписаниеНДСВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/СписаниеНДС/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/СписаниеНДС/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/СписаниеНДС/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class СписаниеНДСВыбратьПоНомеру: V82.ДокументыСсылка.СписаниеНДС,IReturn<СписаниеНДСВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/СписаниеНДС/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СписаниеНДССтраницаПоСсылке: V82.ДокументыСсылка.СписаниеНДС,IReturn<СписаниеНДССтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/СписаниеНДС/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class СписаниеНДССтраницаПоНомеру: V82.ДокументыСсылка.СписаниеНДС,IReturn<СписаниеНДССтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СписаниеНДСОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СписаниеНДССервис : Service
	{
		
		public object Get(СписаниеНДСЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СписаниеНДСНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.СписаниеНДС.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СписаниеНДСОтвет() { Ответ = "СписаниеНДС c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СписаниеНДСНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.СписаниеНДС.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new СписаниеНДСОтвет() {Ответ = "СписаниеНДС c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СписаниеНДСВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.СписаниеНДС.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СписаниеНДСВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(СписаниеНДССтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СписаниеНДССтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(СписаниеНДСЗапрос Запрос)
		{
			return new СписаниеНДСОтвет {Ответ = "СписаниеНДС, "};
		}

		public object Post(СписаниеНДСЗапрос ЗапросСписаниеНДС)
		{
			var Ссылка = (ДокументыСсылка.СписаниеНДС)ЗапросСписаниеНДС;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}