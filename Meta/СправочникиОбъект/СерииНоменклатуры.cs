﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.СправочникиОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиОбъект
{
	[ProtoContract]
	[DataContract]
	public partial class СерииНоменклатуры:СправочникОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		[DataMember]
		[ProtoMember(3)]
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(4)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public bool Предопределенный {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public Guid Владелец {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*9*/ Код {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*100*/ Наименование {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public string/*(25)*/ СерийныйНомер {get;set;}//Серийный номер
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public DateTime СрокГодности {get;set;}//Срок годности
		///<summary>
		///(Регл) Номер ГТД по умолчанию
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public V82.СправочникиСсылка.НомераГТД НомерГТД {get;set;}//Номер ГТД
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public V82.СправочникиСсылка.КлассификаторСтранМира СтранаПроисхождения {get;set;}//Страна происхождения
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public V82.СправочникиСсылка.ХранилищеДополнительнойИнформации ОсновноеИзображение {get;set;}//Основное изображение
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public string/*(0)*/ Комментарий {get;set;}
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для справочников.
			//Контроль уникальности номера для документов, в границах префикса.
			//Контроль владельца, он не может быть группой.
			//Контроль владельца он должен быть задан.
			//Контроль родителя он должен быть группой.
			//Контроль количества уровней, должен соотвествовать метаданным.
			//Контроль версии, объект не должен был быть записан перед чтением текущей записи, алгоритм версионника.
			//Контроль уникальности ссылки
			//Контроль зацикливания
			//Опционально контроль битых ссылок.
			//Соблюдейние транзакционности. ПередЗаписью. Открытие транзации. Валидации. ПриЗаписи. Фиксация транзакции. Информирование о записи элемента.
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Reference145(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_OwnerIDRRef
						,_Code
						,_Description
						,_Fld1736
						,_Fld1737
						,_Fld1738RRef
						,_Fld1739RRef
						,_Fld1740RRef
						,_Fld1741)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Владелец
						,@Код
						,@Наименование
						,@СерийныйНомер
						,@СрокГодности
						,@НомерГТД
						,@СтранаПроисхождения
						,@ОсновноеИзображение
						,@Комментарий)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference145
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_OwnerIDRRef	= @Владелец
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld1736	= @СерийныйНомер
						,_Fld1737	= @СрокГодности
						,_Fld1738RRef	= @НомерГТД
						,_Fld1739RRef	= @СтранаПроисхождения
						,_Fld1740RRef	= @ОсновноеИзображение
						,_Fld1741	= @Комментарий
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Владелец", Владелец);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("СерийныйНомер", СерийныйНомер);
					Команда.Parameters.AddWithValue("СрокГодности", СрокГодности);
					Команда.Parameters.AddWithValue("НомерГТД", НомерГТД.Ссылка);
					Команда.Parameters.AddWithValue("СтранаПроисхождения", СтранаПроисхождения.Ссылка);
					Команда.Parameters.AddWithValue("ОсновноеИзображение", ОсновноеИзображение.Ссылка);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Reference145
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		////////////////////////////////////////////////////////////////////////////////
		// ЭКСПОРТИРУЕМЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Функция устанавливает новое наименование серии по значениям реквизитов.
		//
		// Параметры:
		//  Нет.
		//
		// Возвращаемое значение:
		//  Строка - сформированное наименование.
		//

		public object СформироватьНаименование(/**/)
		{
			//Строка = "";
			if(true/*ЗначениеЗаполнено(СерийныйНомер)*/)
			{
				//Строка = Строка + СерийныйНомер + ", ";
			}
			if(true/*ЗначениеЗаполнено(СрокГодности)*/)
			{
				//Строка = Строка + Формат(СрокГодности,"ДФ=""дд.ММ.гггг""") + ", ";
			}
			if(true/*ЗначениеЗаполнено(НомерГТД)*/)
			{
				//Строка = Строка + СокрЛП(НомерГТД.Код) + ", ";
			}
			if(true/*ЗначениеЗаполнено(СтранаПроисхождения)*/)
			{
				//Строка = Строка + СтранаПроисхождения.Наименование + ", ";
			}
			//Строка = Лев(Строка, СтрДлина(Строка) - 2);
			if(true/*ПустаяСтрока(Строка)*/)
			{
				//Строка = "<Свойства не назначены>";
			}
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// ОБРАБОТЧИКИ СОБЫТИЙ

		public void ПриКопировании(/*ОбъектКопирования*/)
		{
			if(true/*Не ЭтоГруппа*/)
			{
				//ОсновноеИзображение = Неопределено;
			}
		}
		// Процедура вызывается перед записью элемента справочника.
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			/*// Проверим можно ли изменять реквизиты договора.
*/
			/*// Проверка осуществляется только если записывается уже существующий договор
*/
			if(true/*НЕ ОбменДанными.Загрузка И НЕ ЭтоНовый()*/)
			{
				/*// Проверим возможность смены способа ведения взаиморасчетов и валюты взаиморасчетов
*/
				if(true/*НомерГТД <> Ссылка.НомерГТД
		 ИЛИ СтранаПроисхождения <> Ссылка.СтранаПроисхождения*/)
				{
					if(true/*ПолныеПрава.СерииНоменклатуры_СуществуютСсылки(Ссылка)*/)
					{
						/*Сообщить("Существуют документы, проведенные по серии """ + Наименование + """.
						 |Реквизиты ""Номер ГТД"" и ""Страна происхождения"" не могут быть изменены, элемент не записан.", 
						 СтатусСообщения.Важное);*/
						//Отказ = Истина;
					}
				}
			}
		}
		// ПередЗаписью()
	}
}