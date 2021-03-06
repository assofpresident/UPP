﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KlyuchiAnalitikiUchetaPartijj
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий","")]
	public class КлючиАналитикиУчетаПартийЗапрос: V82.СправочникиСсылка.КлючиАналитикиУчетаПартий,IReturn<КлючиАналитикиУчетаПартийЗапрос>
	{
	}
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий/ПоСсылке","{Ссылка}")]
	public class КлючиАналитикиУчетаПартийНайтиПоСсылке: V82.СправочникиСсылка.КлючиАналитикиУчетаПартий,IReturn<КлючиАналитикиУчетаПартийНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий/ПоНаименованию","{Наименование}")]
	public class КлючиАналитикиУчетаПартийНайтиПоНаименованию: V82.СправочникиСсылка.КлючиАналитикиУчетаПартий,IReturn<КлючиАналитикиУчетаПартийНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КлючиАналитикиУчетаПартийВыбратьПоСсылке: V82.СправочникиСсылка.КлючиАналитикиУчетаПартий,IReturn<КлючиАналитикиУчетаПартийВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class КлючиАналитикиУчетаПартийВыбратьПоНаименованию: V82.СправочникиСсылка.КлючиАналитикиУчетаПартий,IReturn<КлючиАналитикиУчетаПартийВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КлючиАналитикиУчетаПартийСтраницаПоСсылке: V82.СправочникиСсылка.КлючиАналитикиУчетаПартий,IReturn<КлючиАналитикиУчетаПартийСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КлючиАналитикиУчетаПартий/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class КлючиАналитикиУчетаПартийСтраницаПоНаименованию: V82.СправочникиСсылка.КлючиАналитикиУчетаПартий,IReturn<КлючиАналитикиУчетаПартийСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КлючиАналитикиУчетаПартийОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class КлючиАналитикиУчетаПартийСервис : Service
	{
		
		public object Get(КлючиАналитикиУчетаПартийЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(КлючиАналитикиУчетаПартийНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.КлючиАналитикиУчетаПартий.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new КлючиАналитикиУчетаПартийОтвет() { Ответ = "КлючиАналитикиУчетаПартий c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КлючиАналитикиУчетаПартийНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КлючиАналитикиУчетаПартийВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.КлючиАналитикиУчетаПартий.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(КлючиАналитикиУчетаПартийВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КлючиАналитикиУчетаПартийСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КлючиАналитикиУчетаПартийСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(КлючиАналитикиУчетаПартийЗапрос Запрос)
		{
			return new КлючиАналитикиУчетаПартийОтвет {Ответ = "КлючиАналитикиУчетаПартий, "};
		}

		public object Post(КлючиАналитикиУчетаПартийЗапрос ЗапросКлючиАналитикиУчетаПартий)
		{
			var Ссылка = (СправочникиСсылка.КлючиАналитикиУчетаПартий)ЗапросКлючиАналитикиУчетаПартий;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}