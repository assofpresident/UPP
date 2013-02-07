
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum ВидыОперацийПоступлениеТоваровУслуг
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		ПокупкаКомиссия = 0,//покупка, комиссия
	///<summary>
	///(Общ)
	///</summary>
		ВПереработку = 1,//в переработку
	///<summary>
	///(Общ)
	///</summary>
		Оборудование = 2,
		ОбъектыСтроительства = 3,//объекты строительства
	}
	public static partial class ВидыОперацийПоступлениеТоваровУслуг_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПокупкаКомиссия = new Guid("80f5698d-f64c-152f-4814-7e32a1b85623");//покупка, комиссия
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВПереработку = new Guid("4e59aaab-f82b-2497-4adf-c2ee2d3dbfd4");//в переработку
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Оборудование = new Guid("a29f9ebb-f24f-5660-445c-a48d10c0b148");
		public static readonly Guid ОбъектыСтроительства = new Guid("e98bf7a6-8b48-cabe-4cd8-bb7f8a01e996");//объекты строительства
		public static ВидыОперацийПоступлениеТоваровУслуг Получить(this ВидыОперацийПоступлениеТоваровУслуг Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийПоступлениеТоваровУслуг Получить(this ВидыОперацийПоступлениеТоваровУслуг Значение, Guid Ссылка)
		{
			if(Ссылка == ПокупкаКомиссия)
			{
				return ВидыОперацийПоступлениеТоваровУслуг.ПокупкаКомиссия;
			}
			else if(Ссылка == ВПереработку)
			{
				return ВидыОперацийПоступлениеТоваровУслуг.ВПереработку;
			}
			else if(Ссылка == Оборудование)
			{
				return ВидыОперацийПоступлениеТоваровУслуг.Оборудование;
			}
			else if(Ссылка == ОбъектыСтроительства)
			{
				return ВидыОперацийПоступлениеТоваровУслуг.ОбъектыСтроительства;
			}
			return ВидыОперацийПоступлениеТоваровУслуг.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийПоступлениеТоваровУслуг Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийПоступлениеТоваровУслуг Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийПоступлениеТоваровУслуг.ПокупкаКомиссия: return ПокупкаКомиссия;
				case ВидыОперацийПоступлениеТоваровУслуг.ВПереработку: return ВПереработку;
				case ВидыОперацийПоступлениеТоваровУслуг.Оборудование: return Оборудование;
				case ВидыОперацийПоступлениеТоваровУслуг.ОбъектыСтроительства: return ОбъектыСтроительства;
			}
			return Guid.Empty;
		}
	}
}