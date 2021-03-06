﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Регл)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class РасчетПриУвольненииРаботникаОрганизаций:ДокументОбъект
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
		public DateTime Дата {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public DateTime ПрефиксНомера {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*11*/ Номер {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public bool Проведен {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public DateTime ПериодРегистрации {get;set;}//Период регистрации
		[DataMember]
		[ProtoMember(10)]
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public string/*(0)*/ Комментарий {get;set;}
		[DataMember]
		[ProtoMember(12)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		[DataMember]
		[ProtoMember(13)]
		public V82.СправочникиСсылка.СотрудникиОрганизаций Сотрудник {get;set;}
		[DataMember]
		[ProtoMember(14)]
		public V82.СправочникиСсылка.ФизическиеЛица Физлицо {get;set;}//Физическое лицо
		[DataMember]
		[ProtoMember(15)]
		public DateTime ДатаУвольнения {get;set;}//Дата увольнения
		[DataMember]
		[ProtoMember(16)]
		public decimal/*(3)*/ ДнейЧасовВыходногоПособия {get;set;}//Дней часов выходного пособия
		[DataMember]
		[ProtoMember(17)]
		public decimal/*(5.2)*/ ДнейЧасовКомпенсацииУдержанияОтпуска {get;set;}//Дней часов компенсации удержания отпуска
		[DataMember]
		[ProtoMember(18)]
		public decimal/*(3)*/ ДнейЧасовСохраненияСреднегоЗаработка {get;set;}//Дней часов сохранения среднего заработка
		[DataMember]
		[ProtoMember(19)]
		public bool ПризнакКомпенсацииОтпуска {get;set;}//Признак компенсации отпуска
		[DataMember]
		[ProtoMember(20)]
		public V82.ДокументыСсылка.УвольнениеИзОрганизаций ДокументОснование {get;set;}//Документ основание
		[DataMember]
		[ProtoMember(21)]
		public V82.Перечисления/*Ссылка*/.ПорядокРасчетаОтпуска ПорядокРасчетаОтпуска {get;set;}//Порядок расчета отпуска
		[DataMember]
		[ProtoMember(22)]
		public V82.ДокументыСсылка.РасчетПриУвольненииРаботникаОрганизаций ПерерассчитываемыйДокумент {get;set;}//Перерассчитываемый документ
		[DataMember]
		[ProtoMember(23)]
		public DateTime РабочийГодС {get;set;}//Рабочий год с
		[DataMember]
		[ProtoMember(24)]
		public DateTime РабочийГодПо {get;set;}//Рабочий год по
		[DataMember]
		[ProtoMember(25)]
		public bool ИспользоватьСреднеЧасовойЗаработок {get;set;}//Использовать среднечасовой заработок
		[DataMember]
		[ProtoMember(26)]
		public V82.ДокументыСсылка.ПриемНаРаботуВОрганизацию УдалитьПриказ {get;set;}//Удалить приказ
		///<summary>
		///Дата начала расчетного периода
		///</summary>
		[DataMember]
		[ProtoMember(27)]
		public DateTime ПериодРасчетаСреднегоЗаработкаНачало {get;set;}//Период расчета среднего заработка начало
		///<summary>
		///Дата окончания расчетного периода
		///</summary>
		[DataMember]
		[ProtoMember(28)]
		public DateTime ПериодРасчетаСреднегоЗаработкаОкончание {get;set;}//Период расчета среднего заработка окончание
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для Документов.
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
						Insert Into _Document427(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld10732
						,_Fld10733RRef
						,_Fld10734
						,_Fld10735RRef
						,_Fld21973RRef
						,_Fld10736RRef
						,_Fld10738
						,_Fld10739
						,_Fld10740
						,_Fld10741
						,_Fld10742
						,_Fld10743RRef
						,_Fld10744RRef
						,_Fld10745RRef
						,_Fld10746
						,_Fld10747
						,_Fld18527
						,_Fld10737RRef
						,_Fld27269
						,_Fld27270)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@ПериодРегистрации
						,@Организация
						,@Комментарий
						,@Ответственный
						,@Сотрудник
						,@Физлицо
						,@ДатаУвольнения
						,@ДнейЧасовВыходногоПособия
						,@ДнейЧасовКомпенсацииУдержанияОтпуска
						,@ДнейЧасовСохраненияСреднегоЗаработка
						,@ПризнакКомпенсацииОтпуска
						,@ДокументОснование
						,@ПорядокРасчетаОтпуска
						,@ПерерассчитываемыйДокумент
						,@РабочийГодС
						,@РабочийГодПо
						,@ИспользоватьСреднеЧасовойЗаработок
						,@УдалитьПриказ
						,@ПериодРасчетаСреднегоЗаработкаНачало
						,@ПериодРасчетаСреднегоЗаработкаОкончание)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document427
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld10732	= @ПериодРегистрации
						,_Fld10733RRef	= @Организация
						,_Fld10734	= @Комментарий
						,_Fld10735RRef	= @Ответственный
						,_Fld21973RRef	= @Сотрудник
						,_Fld10736RRef	= @Физлицо
						,_Fld10738	= @ДатаУвольнения
						,_Fld10739	= @ДнейЧасовВыходногоПособия
						,_Fld10740	= @ДнейЧасовКомпенсацииУдержанияОтпуска
						,_Fld10741	= @ДнейЧасовСохраненияСреднегоЗаработка
						,_Fld10742	= @ПризнакКомпенсацииОтпуска
						,_Fld10743RRef	= @ДокументОснование
						,_Fld10744RRef	= @ПорядокРасчетаОтпуска
						,_Fld10745RRef	= @ПерерассчитываемыйДокумент
						,_Fld10746	= @РабочийГодС
						,_Fld10747	= @РабочийГодПо
						,_Fld18527	= @ИспользоватьСреднеЧасовойЗаработок
						,_Fld10737RRef	= @УдалитьПриказ
						,_Fld27269	= @ПериодРасчетаСреднегоЗаработкаНачало
						,_Fld27270	= @ПериодРасчетаСреднегоЗаработкаОкончание
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("ПериодРегистрации", ПериодРегистрации);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("ДатаУвольнения", ДатаУвольнения);
					Команда.Parameters.AddWithValue("ДнейЧасовВыходногоПособия", ДнейЧасовВыходногоПособия);
					Команда.Parameters.AddWithValue("ДнейЧасовКомпенсацииУдержанияОтпуска", ДнейЧасовКомпенсацииУдержанияОтпуска);
					Команда.Parameters.AddWithValue("ДнейЧасовСохраненияСреднегоЗаработка", ДнейЧасовСохраненияСреднегоЗаработка);
					Команда.Parameters.AddWithValue("ПризнакКомпенсацииОтпуска", ПризнакКомпенсацииОтпуска);
					Команда.Parameters.AddWithValue("ДокументОснование", ДокументОснование.Ссылка);
					Команда.Parameters.AddWithValue("ПорядокРасчетаОтпуска", ПорядокРасчетаОтпуска.Ключ());
					Команда.Parameters.AddWithValue("ПерерассчитываемыйДокумент", ПерерассчитываемыйДокумент.Ссылка);
					Команда.Parameters.AddWithValue("РабочийГодС", РабочийГодС);
					Команда.Parameters.AddWithValue("РабочийГодПо", РабочийГодПо);
					Команда.Parameters.AddWithValue("ИспользоватьСреднеЧасовойЗаработок", ИспользоватьСреднеЧасовойЗаработок);
					Команда.Parameters.AddWithValue("УдалитьПриказ", УдалитьПриказ.Ссылка);
					Команда.Parameters.AddWithValue("ПериодРасчетаСреднегоЗаработкаНачало", ПериодРасчетаСреднегоЗаработкаНачало);
					Команда.Parameters.AddWithValue("ПериодРасчетаСреднегоЗаработкаОкончание", ПериодРасчетаСреднегоЗаработкаОкончание);
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
					Команда.CommandText = @"Delete _Document427
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}