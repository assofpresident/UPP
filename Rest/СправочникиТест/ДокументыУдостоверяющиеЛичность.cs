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
	public class ДокументыУдостоверяющиеЛичность:V82.Rest.СправочникиТест.СправочникТест
	{
		public static ДокументыУдостоверяющиеЛичностьЗапрос НайтиПоУникальномуИдентификатору(Guid УникальныйИдентификатор)//ПолучитьПоСсылке,Взять
		{
			var Урл = "http://localhost:1337/Справочники/ДокументыУдостоверяющиеЛичность/НайтиПоСсылке/"+УникальныйИдентификатор+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ДокументыУдостоверяющиеЛичностьЗапрос ДокументыУдостоверяющиеЛичностьЗапрос = null;
			try
			{
				ДокументыУдостоверяющиеЛичностьЗапрос = Клиент.Get(new ДокументыУдостоверяющиеЛичностьЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ДокументыУдостоверяющиеЛичностьЗапрос;
		}
		public static ДокументыУдостоверяющиеЛичностьЗапрос НайтиПоНаименованию(string Наименование)//ПолучитьПоНаименованию,Взять
		{
			var Урл = "http://localhost:1337/Справочники/ДокументыУдостоверяющиеЛичность/НайтиПоНаименованию/"+Наименование+"?format=json";
			var Клиент = new JsonServiceClient(Урл);
			ДокументыУдостоверяющиеЛичностьЗапрос ДокументыУдостоверяющиеЛичностьЗапрос = null;
			try
			{
				ДокументыУдостоверяющиеЛичностьЗапрос = Клиент.Get(new ДокументыУдостоверяющиеЛичностьЗапрос());
			}
			catch (Exception)
			{
				return null;
			}
			return ДокументыУдостоверяющиеЛичностьЗапрос;
		}
		public static void ЗаписатьНовый(ДокументыУдостоверяющиеЛичностьЗапрос ДокументыУдостоверяющиеЛичностьЗапрос)//Положить
		{
			var Урл = "http://localhost:1337/Справочники/ДокументыУдостоверяющиеЛичность?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ДокументыУдостоверяющиеЛичностьОтвет = Клиент.Post(ДокументыУдостоверяющиеЛичностьЗапрос);
		}
		public static void Записать(ДокументыУдостоверяющиеЛичностьЗапрос ДокументыУдостоверяющиеЛичностьЗапрос)//Обновить
		{
			var Урл = "http://localhost:1337/Справочники/ДокументыУдостоверяющиеЛичность?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ДокументыУдостоверяющиеЛичностьОтвет = Клиент.Put(ДокументыУдостоверяющиеЛичностьЗапрос);
		}
		public static void Удалить(ДокументыУдостоверяющиеЛичностьЗапрос ДокументыУдостоверяющиеЛичностьЗапрос)//
		{
			var Урл = "http://localhost:1337/Справочники/ДокументыУдостоверяющиеЛичность?format=json";
			var Клиент = new JsonServiceClient(Урл);
			var ДокументыУдостоверяющиеЛичностьОтвет = Клиент.Delete(ДокументыУдостоверяющиеЛичностьЗапрос);
		}
	}
}