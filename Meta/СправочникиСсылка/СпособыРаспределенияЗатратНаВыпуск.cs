
using System;
using System.IO;
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
	public partial class СпособыРаспределенияЗатратНаВыпуск:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("4ca01eb0-049f-4508-8dce-838d931e2725");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191455.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(3)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(4)]
		public bool Предопределенный {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public string/*9*/ Код {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*50*/ Наименование {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(7)]
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(8)]
		public V82.Перечисления/*Ссылка*/.СпособыРаспределенияЗатратНаВыпуск СпособРаспределенияЗатратНаВыпуск {get;set;}//Способ распределения затрат на выпуск
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public V82.Перечисления/*Ссылка*/.ТипыФильтровПриРаспределенииЗатратНаВыпуск ТипФильтраПриРаспределенииЗатратНаВыпуск {get;set;}//Тип фильтра при распределении затрат на выпуск
		[DataMember]
		[ProtoMember(10)]
		public V82.Перечисления/*Ссылка*/.БазыРаспределенияЗатрат БазаРаспределенияЗатрат {get;set;}//База распределения затрат
		[DataMember]
		[ProtoMember(11)]
		public V82.Перечисления/*Ссылка*/.ВидыПоказателейБазыРаспределения ПоказательБазыРаспределения {get;set;}//Показатель базы распределения
		[DataMember]
		[ProtoMember(12)]
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры ТипЦен {get;set;}//Тип цен
		[DataMember]
		[ProtoMember(13)]
		public V82.СправочникиСсылка.ОсновноеСырье ОсновноеСырье {get;set;}//Основное сырье
		[DataMember]
		[ProtoMember(14)]
		public V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск СпособРаспределенияЗатратПоПодразделениям {get;set;}//Способ распределения затрат по подразделениям
		[DataMember]
		[ProtoMember(15)]
		public bool РаспределятьНаСобственнуюПродукцию {get;set;}//Распределять на собственную продукцию
		[DataMember]
		[ProtoMember(16)]
		public bool РаспределятьНаПродукциюСтороннегоПереработчика {get;set;}//Распределять на продукцию стороннего переработчика
		[DataMember]
		[ProtoMember(17)]
		public bool РаспределятьНаПродукциюИзДавальческогоСырья {get;set;}//Распределять на продукцию из давальческого сырья
		[DataMember]
		[ProtoMember(18)]
		public bool РаспределятьНаПодчиненныеПодразделения {get;set;}//Распределять на подчиненные подразделения
		[DataMember]
		[ProtoMember(19)]
		public bool РаспределятьНаНаработку {get;set;}//Распределять на наработку
		[DataMember]
		[ProtoMember(20)]
		public decimal/*(5.2)*/ Процент {get;set;}
		[DataMember]
		[ProtoMember(21)]
		public decimal/*(15.3)*/ Коэффициент {get;set;}
		[DataMember]
		[ProtoMember(22)]
		public V82.Перечисления/*Ссылка*/.ПорядкиОкругления ПорядокОкругления {get;set;}//Порядок округления
		[DataMember]
		[ProtoMember(23)]
		public ХранилищеЗначения НастройкиПостроителя {get;set;}//Настройки построителя
		[DataMember]
		[ProtoMember(24)]
		public bool ИзменитьНаПроцент {get;set;}//Изменить на процент
		[DataMember]
		[ProtoMember(25)]
		public bool ИзменитьНаКоэффициент {get;set;}//Изменить на коэффициент
		[DataMember]
		[ProtoMember(26)]
		public bool ОкруглитьДо {get;set;}//Округлить до
		[DataMember]
		[ProtoMember(27)]
		public ХранилищеЗначения СхемаКомпоновкиДанных {get;set;}//Схема компоновки данных
		[DataMember]
		[ProtoMember(28)]
		public V82.Перечисления/*Ссылка*/.ХарактерЗатрат Применимость {get;set;}//Для каких расходов применять
		///<summary>
		///При использовании этой базы распределение будет выполняться алгоритмом, основанным на схемах компоновки данных
		///</summary>
		[DataMember]
		[ProtoMember(29)]
		public bool ИспользоватьПростоеРаспределение {get;set;}//Использовать упрощенный алгоритм распределения расходов
		[DataMember]
		[ProtoMember(30)]
		public V82.Перечисления/*Ссылка*/.НаправленияРаспределенияЗатрат НаправлениеРаспределения {get;set;}//Куда распределять
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(31)]
		public string/*(0)*/ КогдаПрименять {get;set;}//Область, условия применения
		[DataMember]
		[ProtoMember(32)]
		public V82.Перечисления/*Ссылка*/.ТипыБазРаспределения ТипБазыРаспределения {get;set;}//Тип базы

		public V82.СправочникиОбъект.СпособыРаспределенияЗатратНаВыпуск  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.СпособыРаспределенияЗатратНаВыпуск();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.Комментарий = Комментарий;
			Объект.СпособРаспределенияЗатратНаВыпуск = СпособРаспределенияЗатратНаВыпуск;
			Объект.ТипФильтраПриРаспределенииЗатратНаВыпуск = ТипФильтраПриРаспределенииЗатратНаВыпуск;
			Объект.БазаРаспределенияЗатрат = БазаРаспределенияЗатрат;
			Объект.ПоказательБазыРаспределения = ПоказательБазыРаспределения;
			Объект.ТипЦен = ТипЦен;
			Объект.ОсновноеСырье = ОсновноеСырье;
			Объект.СпособРаспределенияЗатратПоПодразделениям = СпособРаспределенияЗатратПоПодразделениям;
			Объект.РаспределятьНаСобственнуюПродукцию = РаспределятьНаСобственнуюПродукцию;
			Объект.РаспределятьНаПродукциюСтороннегоПереработчика = РаспределятьНаПродукциюСтороннегоПереработчика;
			Объект.РаспределятьНаПродукциюИзДавальческогоСырья = РаспределятьНаПродукциюИзДавальческогоСырья;
			Объект.РаспределятьНаПодчиненныеПодразделения = РаспределятьНаПодчиненныеПодразделения;
			Объект.РаспределятьНаНаработку = РаспределятьНаНаработку;
			Объект.Процент = Процент;
			Объект.Коэффициент = Коэффициент;
			Объект.ПорядокОкругления = ПорядокОкругления;
			Объект.НастройкиПостроителя = НастройкиПостроителя;
			Объект.ИзменитьНаПроцент = ИзменитьНаПроцент;
			Объект.ИзменитьНаКоэффициент = ИзменитьНаКоэффициент;
			Объект.ОкруглитьДо = ОкруглитьДо;
			Объект.СхемаКомпоновкиДанных = СхемаКомпоновкиДанных;
			Объект.Применимость = Применимость;
			Объект.ИспользоватьПростоеРаспределение = ИспользоватьПростоеРаспределение;
			Объект.НаправлениеРаспределения = НаправлениеРаспределения;
			Объект.КогдаПрименять = КогдаПрименять;
			Объект.ТипБазыРаспределения = ТипБазыРаспределения;
			return Объект;
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