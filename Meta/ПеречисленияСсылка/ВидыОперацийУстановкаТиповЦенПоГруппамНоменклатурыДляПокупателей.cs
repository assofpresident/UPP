
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей
	{
		ПустаяСсылка = - 1,
		ПоЦеновымГруппам = 0,//по ценовым группам
		ПоНоменклатурнымГруппам = 1,//по номенклатурным группам
	}
	public static partial class ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоЦеновымГруппам = new Guid("5f1c74b6-3498-8c62-4dce-2f87d498bc11");//по ценовым группам
		public static readonly Guid ПоНоменклатурнымГруппам = new Guid("5a70aea8-6a3f-e027-4bf6-c718eacfc75b");//по номенклатурным группам
		public static ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей Получить(this ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей Получить(this ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей Значение, Guid Ссылка)
		{
			if(Ссылка == ПоЦеновымГруппам)
			{
				return ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей.ПоЦеновымГруппам;
			}
			else if(Ссылка == ПоНоменклатурнымГруппам)
			{
				return ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей.ПоНоменклатурнымГруппам;
			}
			return ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей.ПоЦеновымГруппам: return ПоЦеновымГруппам;
				case ВидыОперацийУстановкаТиповЦенПоГруппамНоменклатурыДляПокупателей.ПоНоменклатурнымГруппам: return ПоНоменклатурнымГруппам;
			}
			return Guid.Empty;
		}
	}
}