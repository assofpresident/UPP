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
	public partial class ГрафикиРаботы:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("b4923b8c-6737-4f2f-b910-efcc0f652260");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928011941.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*50*/ Наименование {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыРабочихГрафиков ВидГрафика {get;set;}//Вид графика
		///<summary>
		///(Общ)
		///</summary>
		public bool СуммированныйУчетРабочегоВремени {get;set;}//Суммированный учет рабочего времени
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ДниНедели ПервыйВыходной {get;set;}//Первый выходной
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ДниНедели ВторойВыходной {get;set;}//Второй выходной
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДатаОтсчета {get;set;}//Дата отсчета
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(7.2)*/ ДлительностьРабочейНедели {get;set;}//Длительность рабочей недели
		public bool СокращенноеРабочееВремя {get;set;}//Сокращенное рабочее время
		public V82.СправочникиСсылка.ГрафикиРаботы ГрафикПолногоРабочегоВремени {get;set;}//График полного рабочего времени
		///<summary>
		///(Общ)
		///</summary>
		public DateTime НачалоДневныхЧасов {get;set;}//Начало дневных часов
		///<summary>
		///(Общ)
		///</summary>
		public DateTime НачалоВечернихЧасов {get;set;}//Начало вечерних часов
		///<summary>
		///(Общ)
		///</summary>
		public DateTime НачалоНочныхЧасов {get;set;}//Начало ночных часов
		public bool СокращеннаяРабочаяНеделя {get;set;}//Сокращенная рабочая неделя
		public bool НеполныйРабочийДень {get;set;}//Неполный рабочий день
		///<summary>
		///Учитывать праздники при автозаполнении графика
		///</summary>
		public bool УчитыватьПраздники {get;set;}//Учитывать праздники
		public bool УчитыватьВечерниеЧасы {get;set;}//Учитывать вечерние часы
		public bool УчитыватьНочныеЧасы {get;set;}//Учитывать ночные часы
		public V82.Перечисления/*Ссылка*/.ШаблонЗаполненияГрафикаРаботы ШаблонЗаполнения {get;set;}//Шаблон заполнения
		public bool УдалитьВыходныеПоСкользящемуГрафику {get;set;}//Удалить выходные по скользящему графику
		
		public ГрафикиРаботы()
		{
		}
		
		public ГрафикиРаботы(byte[] УникальныйИдентификатор)
			: this(УникальныйИдентификатор,0)
		{
		}
		
		public ГрафикиРаботы(byte[] УникальныйИдентификатор,int Глубина)
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
					,_Description [Наименование]
					,_Fld1007RRef [ВидГрафика]
					,_Fld1008 [СуммированныйУчетРабочегоВремени]
					,_Fld1009RRef [ПервыйВыходной]
					,_Fld1010RRef [ВторойВыходной]
					,_Fld1011 [ДатаОтсчета]
					,_Fld1012 [ДлительностьРабочейНедели]
					,_Fld1013 [СокращенноеРабочееВремя]
					,_Fld1014RRef [ГрафикПолногоРабочегоВремени]
					,_Fld1015 [НачалоДневныхЧасов]
					,_Fld1016 [НачалоВечернихЧасов]
					,_Fld1017 [НачалоНочныхЧасов]
					,_Fld21225 [СокращеннаяРабочаяНеделя]
					,_Fld21226 [НеполныйРабочийДень]
					,_Fld26515 [УчитыватьПраздники]
					,_Fld26516 [УчитыватьВечерниеЧасы]
					,_Fld26517 [УчитыватьНочныеЧасы]
					,_Fld26518RRef [ШаблонЗаполнения]
					,_Fld21224 [УдалитьВыходныеПоСкользящемуГрафику]
					From _Reference36(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор  ";
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
							Наименование = Читалка.GetString(4);
								ВидГрафика = V82.Перечисления/*Ссылка*/.ВидыРабочихГрафиков.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
								СуммированныйУчетРабочегоВремени = ((byte[])Читалка.GetValue(6))[0]==1;
								ПервыйВыходной = V82.Перечисления/*Ссылка*/.ДниНедели.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
								ВторойВыходной = V82.Перечисления/*Ссылка*/.ДниНедели.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
								ДатаОтсчета = Читалка.GetDateTime(9);
								ДлительностьРабочейНедели = Читалка.GetDecimal(10);
								СокращенноеРабочееВремя = ((byte[])Читалка.GetValue(11))[0]==1;
								ГрафикПолногоРабочегоВремени = new V82.СправочникиСсылка.ГрафикиРаботы((byte[])Читалка.GetValue(12),Глубина+1);
								НачалоДневныхЧасов = Читалка.GetDateTime(13);
								НачалоВечернихЧасов = Читалка.GetDateTime(14);
								НачалоНочныхЧасов = Читалка.GetDateTime(15);
								СокращеннаяРабочаяНеделя = ((byte[])Читалка.GetValue(16))[0]==1;
								НеполныйРабочийДень = ((byte[])Читалка.GetValue(17))[0]==1;
								УчитыватьПраздники = ((byte[])Читалка.GetValue(18))[0]==1;
								УчитыватьВечерниеЧасы = ((byte[])Читалка.GetValue(19))[0]==1;
								УчитыватьНочныеЧасы = ((byte[])Читалка.GetValue(20))[0]==1;
								ШаблонЗаполнения = V82.Перечисления/*Ссылка*/.ШаблонЗаполненияГрафикаРаботы.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
								УдалитьВыходныеПоСкользящемуГрафику = ((byte[])Читалка.GetValue(22))[0]==1;
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
		
		public V82.СправочникиОбъект.ГрафикиРаботы  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.ГрафикиРаботы();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Наименование = Наименование;
			Объект.ВидГрафика = ВидГрафика;
			Объект.СуммированныйУчетРабочегоВремени = СуммированныйУчетРабочегоВремени;
			Объект.ПервыйВыходной = ПервыйВыходной;
			Объект.ВторойВыходной = ВторойВыходной;
			Объект.ДатаОтсчета = ДатаОтсчета;
			Объект.ДлительностьРабочейНедели = ДлительностьРабочейНедели;
			Объект.СокращенноеРабочееВремя = СокращенноеРабочееВремя;
			Объект.ГрафикПолногоРабочегоВремени = ГрафикПолногоРабочегоВремени;
			Объект.НачалоДневныхЧасов = НачалоДневныхЧасов;
			Объект.НачалоВечернихЧасов = НачалоВечернихЧасов;
			Объект.НачалоНочныхЧасов = НачалоНочныхЧасов;
			Объект.СокращеннаяРабочаяНеделя = СокращеннаяРабочаяНеделя;
			Объект.НеполныйРабочийДень = НеполныйРабочийДень;
			Объект.УчитыватьПраздники = УчитыватьПраздники;
			Объект.УчитыватьВечерниеЧасы = УчитыватьВечерниеЧасы;
			Объект.УчитыватьНочныеЧасы = УчитыватьНочныеЧасы;
			Объект.ШаблонЗаполнения = ШаблонЗаполнения;
			Объект.УдалитьВыходныеПоСкользящемуГрафику = УдалитьВыходныеПоСкользящемуГрафику;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.ГрафикиРаботы ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.ГрафикиРаботы)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.ГрафикиРаботы(УникальныйИдентификатор);
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