
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum ВидыДействийПоЗаказамПокупателей
	{
		ПустаяСсылка = - 1,
		ОтгрузкаПоЗаказу = 0,//Отгрузка по заказу
		ОплатаПоЗаказу = 1,//Оплата по заказу
	}
	public static partial class ВидыДействийПоЗаказамПокупателей_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ОтгрузкаПоЗаказу = new Guid("37f08cad-078a-07d0-412f-591aeb2812e2");//Отгрузка по заказу
		public static readonly Guid ОплатаПоЗаказу = new Guid("dcb14ebe-2068-8713-4170-c843e99ef6f4");//Оплата по заказу
		public static ВидыДействийПоЗаказамПокупателей Получить(this ВидыДействийПоЗаказамПокупателей Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыДействийПоЗаказамПокупателей Получить(this ВидыДействийПоЗаказамПокупателей Значение, Guid Ссылка)
		{
			if(Ссылка == ОтгрузкаПоЗаказу)
			{
				return ВидыДействийПоЗаказамПокупателей.ОтгрузкаПоЗаказу;
			}
			else if(Ссылка == ОплатаПоЗаказу)
			{
				return ВидыДействийПоЗаказамПокупателей.ОплатаПоЗаказу;
			}
			return ВидыДействийПоЗаказамПокупателей.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыДействийПоЗаказамПокупателей Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыДействийПоЗаказамПокупателей Значение)
		{
			switch (Значение)
			{
				case ВидыДействийПоЗаказамПокупателей.ОтгрузкаПоЗаказу: return ОтгрузкаПоЗаказу;
				case ВидыДействийПоЗаказамПокупателей.ОплатаПоЗаказу: return ОплатаПоЗаказу;
			}
			return Guid.Empty;
		}
	}
}