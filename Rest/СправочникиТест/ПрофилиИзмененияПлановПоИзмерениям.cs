﻿
using System;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceClient.Web;
using V82.Справочники;

namespace V82.Rest.СправочникиТест
{
	public class ПрофилиИзмененияПлановПоИзмерениям:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ПрофилиИзмененияПлановПоИзмерениямЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Справочники/ПрофилиИзмененияПлановПоИзмерениям/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ПрофилиИзмененияПлановПоИзмерениямЗапрос ПрофилиИзмененияПлановПоИзмерениямЗапрос = null;
			try
			{
				ПрофилиИзмененияПлановПоИзмерениямЗапрос = Клиент.Get(new ПрофилиИзмененияПлановПоИзмерениямЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ПрофилиИзмененияПлановПоИзмерениямЗапрос;
		}
		public static ПрофилиИзмененияПлановПоИзмерениямЗапрос НайтиПоКоду(string Код)
		{
			var Урл = "http://localhost:1337/Справочники/ПрофилиИзмененияПлановПоИзмерениям/НайтиПоКоду/"+Код+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ПрофилиИзмененияПлановПоИзмерениямЗапрос ПрофилиИзмененияПлановПоИзмерениямЗапрос = null;
			try
			{
				ПрофилиИзмененияПлановПоИзмерениямЗапрос = Клиент.Get(new ПрофилиИзмененияПлановПоИзмерениямЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ПрофилиИзмененияПлановПоИзмерениямЗапрос;
		}
		public static ПрофилиИзмененияПлановПоИзмерениямЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Справочники/ПрофилиИзмененияПлановПоИзмерениям/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ПрофилиИзмененияПлановПоИзмерениямЗапрос ПрофилиИзмененияПлановПоИзмерениямЗапрос = null;
			try
			{
				ПрофилиИзмененияПлановПоИзмерениямЗапрос = Клиент.Get(new ПрофилиИзмененияПлановПоИзмерениямЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ПрофилиИзмененияПлановПоИзмерениямЗапрос;
		}
		public static void ЗаписатьНовый(ПрофилиИзмененияПлановПоИзмерениямЗапрос ПрофилиИзмененияПлановПоИзмерениямЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Справочники/ПрофилиИзмененияПлановПоИзмерениям?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ПрофилиИзмененияПлановПоИзмерениямОтвет = Клиент.Post(ПрофилиИзмененияПлановПоИзмерениямЗапрос);
		}
		public static void Записать(ПрофилиИзмененияПлановПоИзмерениямЗапрос ПрофилиИзмененияПлановПоИзмерениямЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Справочники/ПрофилиИзмененияПлановПоИзмерениям?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ПрофилиИзмененияПлановПоИзмерениямОтвет = Клиент.Put(ПрофилиИзмененияПлановПоИзмерениямЗапрос);
		}
		public static void Удалить(ПрофилиИзмененияПлановПоИзмерениямЗапрос ПрофилиИзмененияПлановПоИзмерениямЗапрос)//
		{
			var Урл = "http://localhost:1337/Справочники/ПрофилиИзмененияПлановПоИзмерениям?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ПрофилиИзмененияПлановПоИзмерениямОтвет = Клиент.Delete(ПрофилиИзмененияПлановПоИзмерениямЗапрос);
		}
	}
}