﻿
using System;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///(Регл)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ЗаявлениеОбОбменеДубликатеСтраховогоСвидетельства:ДокументСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("59e4d8b1-1e03-4664-8453-a020cd3ec005");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012032.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления {get;set;}
		public DateTime Дата {get;set;}
		public DateTime ПрефиксНомера {get;set;}
		public string/*11*/ Номер {get;set;}
		public bool Проведен {get;set;}
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		public V82.Перечисления/*Ссылка*/.ВидыАДВ ВидАДВ {get;set;}//Вид АДВ
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		public string/*(100)*/ КраткийСоставДокумента {get;set;}//Краткий состав документа
		public V82.Перечисления/*Ссылка*/.ФорматФайлаПФР ФорматФайла {get;set;}//Формат файла
		public string/*(5)*/ НомерПачки {get;set;}//Номер пачки
		public bool ЗаменятьБуквуЕ {get;set;}//Заменять букву "ё"
		
		public ЗаявлениеОбОбменеДубликатеСтраховогоСвидетельства()
		{
		}
		
		public ЗаявлениеОбОбменеДубликатеСтраховогоСвидетельства(byte[] УникальныйИдентификатор)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Number [Номер]
					,_Fld4797RRef [Организация]
					,_Fld4798RRef [ВидАДВ]
					,_Fld4799 [Комментарий]
					,_Fld4800RRef [Ответственный]
					,_Fld4801 [КраткийСоставДокумента]
					,_Fld21443RRef [ФорматФайла]
					,_Fld26770 [НомерПачки]
					,_Fld26771 [ЗаменятьБуквуЕ]
					From _Document273(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор";
					Команда.Parameters.AddWithValue("УникальныйИдентификатор", УникальныйИдентификатор);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							//ToDo: Читать нужно через GetValues()
							Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Номер = Читалка.GetString(3);
							ВидАДВ = V82.Перечисления/*Ссылка*/.ВидыАДВ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Комментарий = Читалка.GetString(6);
							КраткийСоставДокумента = Читалка.GetString(8);
							ФорматФайла = V82.Перечисления/*Ссылка*/.ФорматФайлаПФР.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							НомерПачки = Читалка.GetString(10);
							ЗаменятьБуквуЕ = ((byte[])Читалка.GetValue(11))[0]==1;
							//return Ссылка;
						}
						else
						{
							//return null;
						}
					}
				}
			}
		}
		
		public V82.ДокументыОбъект.ЗаявлениеОбОбменеДубликатеСтраховогоСвидетельства  ПолучитьОбъект()
		{
			var Объект = new V82.ДокументыОбъект.ЗаявлениеОбОбменеДубликатеСтраховогоСвидетельства();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Номер = Номер;
			Объект.Организация = Организация;
			Объект.ВидАДВ = ВидАДВ;
			Объект.Комментарий = Комментарий;
			Объект.Ответственный = Ответственный;
			Объект.КраткийСоставДокумента = КраткийСоставДокумента;
			Объект.ФорматФайла = ФорматФайла;
			Объект.НомерПачки = НомерПачки;
			Объект.ЗаменятьБуквуЕ = ЗаменятьБуквуЕ;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.ДокументыСсылка.ЗаявлениеОбОбменеДубликатеСтраховогоСвидетельства ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.ДокументыСсылка.ЗаявлениеОбОбменеДубликатеСтраховогоСвидетельства)Кэш[УИ];
			}
			var Ссылка = new V82.ДокументыСсылка.ЗаявлениеОбОбменеДубликатеСтраховогоСвидетельства(УникальныйИдентификатор);
			Кэш.Add(УИ, Ссылка);
			return Ссылка;
		}
		
		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}
		
		public string СериализацияJson()
		{
			return this.ToJson();
		}
		
		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}