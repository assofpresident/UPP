
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum ВидыОперацийВозвратТоваровОтПокупателя
	{
		ПустаяСсылка = - 1,
		ПродажаКомиссия = 0,//продажа, комиссия
		Оборудование = 1,
	}
	public static partial class ВидыОперацийВозвратТоваровОтПокупателя_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПродажаКомиссия = new Guid("0fc67194-6b98-cbfc-4dbb-9bde546cc453");//продажа, комиссия
		public static readonly Guid Оборудование = new Guid("a5de9894-0b72-2c36-4cf0-249f184b70c6");
		public static ВидыОперацийВозвратТоваровОтПокупателя Получить(this ВидыОперацийВозвратТоваровОтПокупателя Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийВозвратТоваровОтПокупателя Получить(this ВидыОперацийВозвратТоваровОтПокупателя Значение, Guid Ссылка)
		{
			if(Ссылка == ПродажаКомиссия)
			{
				return ВидыОперацийВозвратТоваровОтПокупателя.ПродажаКомиссия;
			}
			else if(Ссылка == Оборудование)
			{
				return ВидыОперацийВозвратТоваровОтПокупателя.Оборудование;
			}
			return ВидыОперацийВозвратТоваровОтПокупателя.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийВозвратТоваровОтПокупателя Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийВозвратТоваровОтПокупателя Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийВозвратТоваровОтПокупателя.ПродажаКомиссия: return ПродажаКомиссия;
				case ВидыОперацийВозвратТоваровОтПокупателя.Оборудование: return Оборудование;
			}
			return Guid.Empty;
		}
	}
}