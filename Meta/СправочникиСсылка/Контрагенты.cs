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
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	///<summary>
	///(Общ)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class Контрагенты:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("946bc5df-4474-4748-88c8-6475a2a3d688");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012011.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public bool Предопределенный {get;set;}
		public V82.СправочникиСсылка.Контрагенты Родитель {get;set;}
		public bool ЭтоГруппа {get;set;}
		public string/*9*/ Код {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*100*/ Наименование {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ НаименованиеПолное {get;set;}//Полное наименование
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ) Дополнительное описание
		///</summary>
		public string/*(0)*/ ДополнительноеОписание {get;set;}//Дополнительное описание
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты ГоловнойКонтрагент {get;set;}//Головной контрагент
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей ИсточникИнформацииПриОбращении {get;set;}//Источник информации при обращении
		///<summary>
		///(Регл) 
		///</summary>
		public string/*(10)*/ КодПоОКПО {get;set;}//Код по ОКПО
		///<summary>
		///(Регл) Идентификационный номер налогоплательщика
		///</summary>
		public string/*(12)*/ ИНН {get;set;}
		///<summary>
		///(Регл) Идентификационный номер налогоплательщика
		///</summary>
		public string/*(9)*/ КПП {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ЮрФизЛицо ЮрФизЛицо {get;set;}//Юр. / физ. лицо
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета ОсновнойБанковскийСчет {get;set;}//Основной банковский счет
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ОсновнойДоговорКонтрагента {get;set;}//Основной договор контрагента
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.ВидыДеятельностиКонтрагентов ОсновнойВидДеятельности {get;set;}//Основной вид деятельности
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ДокументУдостоверяющийЛичность {get;set;}//Документ, удостоверяющий личность
		///<summary>
		///(Упр) Основной менеджер
		///</summary>
		public V82.СправочникиСсылка.Пользователи ОсновнойМенеджерПокупателя {get;set;}//Основной менеджер покупателя
		///<summary>
		///(Общ)
		///</summary>
		public bool Покупатель {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public bool Поставщик {get;set;}
		///<summary>
		///(Общ) Расписание работы строкой
		///</summary>
		public string/*(0)*/ РасписаниеРаботыСтрокой {get;set;}//Расписание работы строкой
		///<summary>
		///(Упр)
		///</summary>
		public decimal/*(3)*/ СрокВыполненияЗаказаПоставщиком {get;set;}//Срок выполнения заказа поставщиком (в днях)
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.КонтактныеЛицаКонтрагентов ОсновноеКонтактноеЛицо {get;set;}//Основное контактное лицо
		///<summary>
		///(Регл)
		///</summary>
		public bool НеЯвляетсяРезидентом {get;set;}//Не является резидентом
		public V82.СправочникиСсылка.КлассификаторОКОПФ ОКОПФ {get;set;}
		public V82.СправочникиСсылка.Регионы Регион {get;set;}
		public V82.СправочникиСсылка.ГруппыДоступаКонтрагентов ГруппаДоступаКонтрагента {get;set;}//Группа доступа контрагента
		
		public Контрагенты()
		{
		}
		
		public Контрагенты(byte[] УникальныйИдентификатор)
			: this(УникальныйИдентификатор,0)
		{
		}
		
		public Контрагенты(byte[] УникальныйИдентификатор,int Глубина)
		{
			if (Глубина>3)
			{
				return;
			}
			if (new Guid(УникальныйИдентификатор) == Guid.Empty)
			{
				return;
			}
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1266 [НаименованиеПолное]
					,_Fld1264 [Комментарий]
					,_Fld1260 [ДополнительноеОписание]
					,_Fld1258RRef [ГоловнойКонтрагент]
					,_Fld1262RRef [ИсточникИнформацииПриОбращении]
					,_Fld1263 [КодПоОКПО]
					,_Fld1261 [ИНН]
					,_Fld1265 [КПП]
					,_Fld1276RRef [ЮрФизЛицо]
					,_Fld1268RRef [ОсновнойБанковскийСчет]
					,_Fld1270RRef [ОсновнойДоговорКонтрагента]
					,_Fld1269RRef [ОсновнойВидДеятельности]
					,_Fld1259 [ДокументУдостоверяющийЛичность]
					,_Fld1271RRef [ОсновнойМенеджерПокупателя]
					,_Fld1272 [Покупатель]
					,_Fld1273 [Поставщик]
					,_Fld1274 [РасписаниеРаботыСтрокой]
					,_Fld1275 [СрокВыполненияЗаказаПоставщиком]
					,_Fld1267RRef [ОсновноеКонтактноеЛицо]
					,_Fld1277 [НеЯвляетсяРезидентом]
					,_Fld1278RRef [ОКОПФ]
					,_Fld1279RRef [Регион]
					,_Fld21240RRef [ГруппаДоступаКонтрагента]
					From _Reference78(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор  -- and _Folder = 0x01  ";
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
							Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Родитель = new V82.СправочникиСсылка.Контрагенты((byte[])Читалка.GetValue(4),Глубина+1);
							ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Код = Читалка.GetString(6);
							Наименование = Читалка.GetString(7);
								Комментарий = Читалка.GetString(9);
							if(!ЭтоГруппа)
							{
								НаименованиеПолное = Читалка.GetString(8);
								ДополнительноеОписание = Читалка.GetString(10);
								ГоловнойКонтрагент = new V82.СправочникиСсылка.Контрагенты((byte[])Читалка.GetValue(11),Глубина+1);
								ИсточникИнформацииПриОбращении = new V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей((byte[])Читалка.GetValue(12),Глубина+1);
								КодПоОКПО = Читалка.GetString(13);
								ИНН = Читалка.GetString(14);
								КПП = Читалка.GetString(15);
								ЮрФизЛицо = V82.Перечисления/*Ссылка*/.ЮрФизЛицо.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
								ОсновнойБанковскийСчет = new V82.СправочникиСсылка.БанковскиеСчета((byte[])Читалка.GetValue(17),Глубина+1);
								ОсновнойДоговорКонтрагента = new V82.СправочникиСсылка.ДоговорыКонтрагентов((byte[])Читалка.GetValue(18),Глубина+1);
								ОсновнойВидДеятельности = new V82.СправочникиСсылка.ВидыДеятельностиКонтрагентов((byte[])Читалка.GetValue(19),Глубина+1);
								ДокументУдостоверяющийЛичность = Читалка.GetString(20);
								ОсновнойМенеджерПокупателя = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(21),Глубина+1);
								Покупатель = ((byte[])Читалка.GetValue(22))[0]==1;
								Поставщик = ((byte[])Читалка.GetValue(23))[0]==1;
								РасписаниеРаботыСтрокой = Читалка.GetString(24);
								СрокВыполненияЗаказаПоставщиком = Читалка.GetDecimal(25);
								ОсновноеКонтактноеЛицо = new V82.СправочникиСсылка.КонтактныеЛицаКонтрагентов((byte[])Читалка.GetValue(26),Глубина+1);
								НеЯвляетсяРезидентом = ((byte[])Читалка.GetValue(27))[0]==1;
								ОКОПФ = new V82.СправочникиСсылка.КлассификаторОКОПФ((byte[])Читалка.GetValue(28),Глубина+1);
								Регион = new V82.СправочникиСсылка.Регионы((byte[])Читалка.GetValue(29),Глубина+1);
								ГруппаДоступаКонтрагента = new V82.СправочникиСсылка.ГруппыДоступаКонтрагентов((byte[])Читалка.GetValue(30),Глубина+1);
							}
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
		
		public V82.СправочникиОбъект.Контрагенты  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.Контрагенты();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Родитель = Родитель;
			Объект.ЭтоГруппа = ЭтоГруппа;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.НаименованиеПолное = НаименованиеПолное;
			Объект.Комментарий = Комментарий;
			Объект.ДополнительноеОписание = ДополнительноеОписание;
			Объект.ГоловнойКонтрагент = ГоловнойКонтрагент;
			Объект.ИсточникИнформацииПриОбращении = ИсточникИнформацииПриОбращении;
			Объект.КодПоОКПО = КодПоОКПО;
			Объект.ИНН = ИНН;
			Объект.КПП = КПП;
			Объект.ЮрФизЛицо = ЮрФизЛицо;
			Объект.ОсновнойБанковскийСчет = ОсновнойБанковскийСчет;
			Объект.ОсновнойДоговорКонтрагента = ОсновнойДоговорКонтрагента;
			Объект.ОсновнойВидДеятельности = ОсновнойВидДеятельности;
			Объект.ДокументУдостоверяющийЛичность = ДокументУдостоверяющийЛичность;
			Объект.ОсновнойМенеджерПокупателя = ОсновнойМенеджерПокупателя;
			Объект.Покупатель = Покупатель;
			Объект.Поставщик = Поставщик;
			Объект.РасписаниеРаботыСтрокой = РасписаниеРаботыСтрокой;
			Объект.СрокВыполненияЗаказаПоставщиком = СрокВыполненияЗаказаПоставщиком;
			Объект.ОсновноеКонтактноеЛицо = ОсновноеКонтактноеЛицо;
			Объект.НеЯвляетсяРезидентом = НеЯвляетсяРезидентом;
			Объект.ОКОПФ = ОКОПФ;
			Объект.Регион = Регион;
			Объект.ГруппаДоступаКонтрагента = ГруппаДоступаКонтрагента;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.Контрагенты ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.Контрагенты)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.Контрагенты(УникальныйИдентификатор);
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