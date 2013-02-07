
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum РазделыУчета
	{
		ПустаяСсылка = - 1,
		МПЗ = 0,
		Затраты = 1,
		ЗатратыНаВыпуск = 2,//Затраты на выпуск
		ЗатратыПоНаработке = 3,//Затраты по наработке
		ТоварыОтгруженные = 4,//Товары отгруженные
		МатериалыВЭксплуатации = 5,//Материалы в эксплуатации
		Выпуск = 6,
		Наработка = 7,
		ПогашеннаяСтоимость = 8,//Погашенная стоимость
		ОтложенныеТЗР = 9,//Отложенные ТЗР
	}
	public static partial class РазделыУчета_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid МПЗ = new Guid("958d8e9d-9eb9-a39c-4516-25f09af5e360");
		public static readonly Guid Затраты = new Guid("8153e4b1-be15-1c4a-415e-3f71107afb6c");
		public static readonly Guid ЗатратыНаВыпуск = new Guid("783f09b4-fed6-ac54-421e-ea26ff652293");//Затраты на выпуск
		public static readonly Guid ЗатратыПоНаработке = new Guid("32663599-ddb4-7b83-4747-24039b46cd73");//Затраты по наработке
		public static readonly Guid ТоварыОтгруженные = new Guid("a2e99ca1-11e8-517f-4c4f-b0aea94f67c7");//Товары отгруженные
		public static readonly Guid МатериалыВЭксплуатации = new Guid("e1e6b08b-1e12-b101-4041-54cef52037a6");//Материалы в эксплуатации
		public static readonly Guid Выпуск = new Guid("ea55fbad-db15-3762-4f38-a37eaf53eabf");
		public static readonly Guid Наработка = new Guid("03398288-975e-f42b-46df-755f16d1832d");
		public static readonly Guid ПогашеннаяСтоимость = new Guid("611ea0ab-44d9-b04f-402b-af83650cc4e4");//Погашенная стоимость
		public static readonly Guid ОтложенныеТЗР = new Guid("0c75ccb8-c0c1-60c2-44eb-26bc9502356b");//Отложенные ТЗР
		public static РазделыУчета Получить(this РазделыУчета Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static РазделыУчета Получить(this РазделыУчета Значение, Guid Ссылка)
		{
			if(Ссылка == МПЗ)
			{
				return РазделыУчета.МПЗ;
			}
			else if(Ссылка == Затраты)
			{
				return РазделыУчета.Затраты;
			}
			else if(Ссылка == ЗатратыНаВыпуск)
			{
				return РазделыУчета.ЗатратыНаВыпуск;
			}
			else if(Ссылка == ЗатратыПоНаработке)
			{
				return РазделыУчета.ЗатратыПоНаработке;
			}
			else if(Ссылка == ТоварыОтгруженные)
			{
				return РазделыУчета.ТоварыОтгруженные;
			}
			else if(Ссылка == МатериалыВЭксплуатации)
			{
				return РазделыУчета.МатериалыВЭксплуатации;
			}
			else if(Ссылка == Выпуск)
			{
				return РазделыУчета.Выпуск;
			}
			else if(Ссылка == Наработка)
			{
				return РазделыУчета.Наработка;
			}
			else if(Ссылка == ПогашеннаяСтоимость)
			{
				return РазделыУчета.ПогашеннаяСтоимость;
			}
			else if(Ссылка == ОтложенныеТЗР)
			{
				return РазделыУчета.ОтложенныеТЗР;
			}
			return РазделыУчета.ПустаяСсылка;
		}
		public static byte[] Ключ(this РазделыУчета Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this РазделыУчета Значение)
		{
			switch (Значение)
			{
				case РазделыУчета.МПЗ: return МПЗ;
				case РазделыУчета.Затраты: return Затраты;
				case РазделыУчета.ЗатратыНаВыпуск: return ЗатратыНаВыпуск;
				case РазделыУчета.ЗатратыПоНаработке: return ЗатратыПоНаработке;
				case РазделыУчета.ТоварыОтгруженные: return ТоварыОтгруженные;
				case РазделыУчета.МатериалыВЭксплуатации: return МатериалыВЭксплуатации;
				case РазделыУчета.Выпуск: return Выпуск;
				case РазделыУчета.Наработка: return Наработка;
				case РазделыУчета.ПогашеннаяСтоимость: return ПогашеннаяСтоимость;
				case РазделыУчета.ОтложенныеТЗР: return ОтложенныеТЗР;
			}
			return Guid.Empty;
		}
	}
}