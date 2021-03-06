﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//KomplektaciyaNomenklatury
	[Маршрут("Документы/КомплектацияНоменклатуры","")]
	public class КомплектацияНоменклатурыЗапрос: V82.ДокументыСсылка.КомплектацияНоменклатуры,IReturn<КомплектацияНоменклатурыЗапрос>
	{
	}
	[Маршрут("Документы/КомплектацияНоменклатуры/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/КомплектацияНоменклатуры/ПоСсылке","{Ссылка}")]
	public class КомплектацияНоменклатурыНайтиПоСсылке: V82.ДокументыСсылка.КомплектацияНоменклатуры,IReturn<КомплектацияНоменклатурыНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/КомплектацияНоменклатуры/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/КомплектацияНоменклатуры/ПоНомеру","{Номер}")]
	public class КомплектацияНоменклатурыНайтиПоНомеру: V82.ДокументыСсылка.КомплектацияНоменклатуры,IReturn<КомплектацияНоменклатурыНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/КомплектацияНоменклатуры/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/КомплектацияНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/КомплектацияНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КомплектацияНоменклатурыВыбратьПоСсылке: V82.ДокументыСсылка.КомплектацияНоменклатуры,IReturn<КомплектацияНоменклатурыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/КомплектацияНоменклатуры/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/КомплектацияНоменклатуры/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/КомплектацияНоменклатуры/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class КомплектацияНоменклатурыВыбратьПоНомеру: V82.ДокументыСсылка.КомплектацияНоменклатуры,IReturn<КомплектацияНоменклатурыВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/КомплектацияНоменклатуры/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КомплектацияНоменклатурыСтраницаПоСсылке: V82.ДокументыСсылка.КомплектацияНоменклатуры,IReturn<КомплектацияНоменклатурыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/КомплектацияНоменклатуры/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class КомплектацияНоменклатурыСтраницаПоНомеру: V82.ДокументыСсылка.КомплектацияНоменклатуры,IReturn<КомплектацияНоменклатурыСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КомплектацияНоменклатурыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class КомплектацияНоменклатурыСервис : Service
	{
		
		public object Get(КомплектацияНоменклатурыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(КомплектацияНоменклатурыНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.КомплектацияНоменклатуры.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new КомплектацияНоменклатурыОтвет() { Ответ = "КомплектацияНоменклатуры c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КомплектацияНоменклатурыНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.КомплектацияНоменклатуры.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new КомплектацияНоменклатурыОтвет() {Ответ = "КомплектацияНоменклатуры c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КомплектацияНоменклатурыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.КомплектацияНоменклатуры.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(КомплектацияНоменклатурыВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(КомплектацияНоменклатурыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КомплектацияНоменклатурыСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(КомплектацияНоменклатурыЗапрос Запрос)
		{
			return new КомплектацияНоменклатурыОтвет {Ответ = "КомплектацияНоменклатуры, "};
		}

		public object Post(КомплектацияНоменклатурыЗапрос ЗапросКомплектацияНоменклатуры)
		{
			var Ссылка = (ДокументыСсылка.КомплектацияНоменклатуры)ЗапросКомплектацияНоменклатуры;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}