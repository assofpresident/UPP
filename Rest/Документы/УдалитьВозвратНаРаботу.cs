﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//UdalitVozvratNaRabotu
	[Маршрут("Документы/УдалитьВозвратНаРаботу","")]
	public class УдалитьВозвратНаРаботуЗапрос: V82.ДокументыСсылка.УдалитьВозвратНаРаботу,IReturn<УдалитьВозвратНаРаботуЗапрос>
	{
	}
	[Маршрут("Документы/УдалитьВозвратНаРаботу/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/УдалитьВозвратНаРаботу/ПоСсылке","{Ссылка}")]
	public class УдалитьВозвратНаРаботуНайтиПоСсылке: V82.ДокументыСсылка.УдалитьВозвратНаРаботу,IReturn<УдалитьВозвратНаРаботуНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/УдалитьВозвратНаРаботу/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/УдалитьВозвратНаРаботу/ПоНомеру","{Номер}")]
	public class УдалитьВозвратНаРаботуНайтиПоНомеру: V82.ДокументыСсылка.УдалитьВозвратНаРаботу,IReturn<УдалитьВозвратНаРаботуНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/УдалитьВозвратНаРаботу/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/УдалитьВозвратНаРаботу/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/УдалитьВозвратНаРаботу/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class УдалитьВозвратНаРаботуВыбратьПоСсылке: V82.ДокументыСсылка.УдалитьВозвратНаРаботу,IReturn<УдалитьВозвратНаРаботуВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/УдалитьВозвратНаРаботу/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/УдалитьВозвратНаРаботу/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/УдалитьВозвратНаРаботу/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class УдалитьВозвратНаРаботуВыбратьПоНомеру: V82.ДокументыСсылка.УдалитьВозвратНаРаботу,IReturn<УдалитьВозвратНаРаботуВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/УдалитьВозвратНаРаботу/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class УдалитьВозвратНаРаботуСтраницаПоСсылке: V82.ДокументыСсылка.УдалитьВозвратНаРаботу,IReturn<УдалитьВозвратНаРаботуСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/УдалитьВозвратНаРаботу/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class УдалитьВозвратНаРаботуСтраницаПоНомеру: V82.ДокументыСсылка.УдалитьВозвратНаРаботу,IReturn<УдалитьВозвратНаРаботуСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class УдалитьВозвратНаРаботуОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class УдалитьВозвратНаРаботуСервис : Service
	{
		
		public object Get(УдалитьВозвратНаРаботуЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(УдалитьВозвратНаРаботуНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.УдалитьВозвратНаРаботу.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new УдалитьВозвратНаРаботуОтвет() { Ответ = "УдалитьВозвратНаРаботу c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(УдалитьВозвратНаРаботуНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.УдалитьВозвратНаРаботу.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new УдалитьВозвратНаРаботуОтвет() {Ответ = "УдалитьВозвратНаРаботу c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(УдалитьВозвратНаРаботуВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.УдалитьВозвратНаРаботу.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(УдалитьВозвратНаРаботуВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(УдалитьВозвратНаРаботуСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(УдалитьВозвратНаРаботуСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(УдалитьВозвратНаРаботуЗапрос Запрос)
		{
			return new УдалитьВозвратНаРаботуОтвет {Ответ = "УдалитьВозвратНаРаботу, "};
		}

		public object Post(УдалитьВозвратНаРаботуЗапрос ЗапросУдалитьВозвратНаРаботу)
		{
			var Ссылка = (ДокументыСсылка.УдалитьВозвратНаРаботу)ЗапросУдалитьВозвратНаРаботу;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}