
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum ВидыОперацийОплатаОтПокупателяПлатежнойКартой
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		ОплатаПокупателя = 0,//Оплата от покупателя
	///<summary>
	///(Общ)
	///</summary>
		ВозвратДенежныхСредствПокупателю = 1,//Возврат денежных средств покупателю
	}
	public static partial class ВидыОперацийОплатаОтПокупателяПлатежнойКартой_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ОплатаПокупателя = new Guid("5ee86ba6-79c3-9cc7-440e-e4c20534815e");//Оплата от покупателя
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВозвратДенежныхСредствПокупателю = new Guid("944bef8e-fc52-71ea-4026-41b6a0d63ad4");//Возврат денежных средств покупателю
		public static ВидыОперацийОплатаОтПокупателяПлатежнойКартой Получить(this ВидыОперацийОплатаОтПокупателяПлатежнойКартой Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийОплатаОтПокупателяПлатежнойКартой Получить(this ВидыОперацийОплатаОтПокупателяПлатежнойКартой Значение, Guid Ссылка)
		{
			if(Ссылка == ОплатаПокупателя)
			{
				return ВидыОперацийОплатаОтПокупателяПлатежнойКартой.ОплатаПокупателя;
			}
			else if(Ссылка == ВозвратДенежныхСредствПокупателю)
			{
				return ВидыОперацийОплатаОтПокупателяПлатежнойКартой.ВозвратДенежныхСредствПокупателю;
			}
			return ВидыОперацийОплатаОтПокупателяПлатежнойКартой.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийОплатаОтПокупателяПлатежнойКартой Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийОплатаОтПокупателяПлатежнойКартой Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийОплатаОтПокупателяПлатежнойКартой.ОплатаПокупателя: return ОплатаПокупателя;
				case ВидыОперацийОплатаОтПокупателяПлатежнойКартой.ВозвратДенежныхСредствПокупателю: return ВозвратДенежныхСредствПокупателю;
			}
			return Guid.Empty;
		}
	}
}