﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Документы
{
	//IzmenenieUslovijjOplatyOtpuskaPoUkhoduZaRebenkom
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком","")]
	public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомЗапрос: V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком,IReturn<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомЗапрос>
	{
	}
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком/ПоСсылке","{Ссылка}")]
	public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомНайтиПоСсылке: V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком,IReturn<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомНайтиПоСсылке>
	{
	}
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком/НайтиПоНомеру","{Номер}")]
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком/ПоНомеру","{Номер}")]
	public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомНайтиПоНомеру: V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком,IReturn<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомНайтиПоНомеру>
	{
	}
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомВыбратьПоСсылке: V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком,IReturn<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком/ВыбратьПоНомеру","{___Первые}")]
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком/ВыбратьПоНомеру","{___Первые}/{___Мин}")]
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком/ВыбратьПоНомеру","{___Первые}/{___Мин}/{___Макс}")]
	public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомВыбратьПоНомеру: V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком,IReturn<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомВыбратьПоНомеру>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомСтраницаПоСсылке: V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком,IReturn<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Документы/ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком/СтраницаПоНомеру","{___Размер}/{___Номер}")]
	public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомСтраницаПоНомеру: V82.ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком,IReturn<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомСтраницаПоНомеру>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомСервис : Service
	{
		
		public object Get(ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Документы.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомОтвет() { Ответ = "ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомНайтиПоНомеру Запрос)
		{
			if(Запрос.Номер == null)
			{
				return null;
			}
			var СтрокаНомер = System.Uri.UnescapeDataString(Запрос.Номер);
			var Ссылка = V82.Документы.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком.НайтиПоНомеру(СтрокаНомер);
			if (Ссылка == null)
			{
				return new ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомОтвет() {Ответ = "ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком c номером '" + Запрос.Номер + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Документы.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомВыбратьПоНомеру Запрос)
		{
			return null;
		}
		
		public object Get(ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомСтраницаПоНомеру Запрос)
		{
			return null;
		}

		public object Any(ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомЗапрос Запрос)
		{
			return new ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомОтвет {Ответ = "ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком, "};
		}

		public object Post(ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомЗапрос ЗапросИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком)
		{
			var Ссылка = (ДокументыСсылка.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком)ЗапросИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}