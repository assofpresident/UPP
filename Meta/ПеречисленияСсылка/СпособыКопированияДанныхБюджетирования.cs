
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum СпособыКопированияДанныхБюджетирования
	{
		ПустаяСсылка = - 1,
		ИнтервалВИнтервал = 0,//Из интервала в интервал
		РаспределениеНормированныхЗначений = 1,//Распределение нормированных значений
	}
	public static partial class СпособыКопированияДанныхБюджетирования_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ИнтервалВИнтервал = new Guid("bec52885-722f-7dd4-4480-b0c229386d7e");//Из интервала в интервал
		public static readonly Guid РаспределениеНормированныхЗначений = new Guid("811e4fb6-bc1a-5cb2-4b0c-45c296ab76b5");//Распределение нормированных значений
		public static СпособыКопированияДанныхБюджетирования Получить(this СпособыКопированияДанныхБюджетирования Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыКопированияДанныхБюджетирования Получить(this СпособыКопированияДанныхБюджетирования Значение, Guid Ссылка)
		{
			if(Ссылка == ИнтервалВИнтервал)
			{
				return СпособыКопированияДанныхБюджетирования.ИнтервалВИнтервал;
			}
			else if(Ссылка == РаспределениеНормированныхЗначений)
			{
				return СпособыКопированияДанныхБюджетирования.РаспределениеНормированныхЗначений;
			}
			return СпособыКопированияДанныхБюджетирования.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыКопированияДанныхБюджетирования Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыКопированияДанныхБюджетирования Значение)
		{
			switch (Значение)
			{
				case СпособыКопированияДанныхБюджетирования.ИнтервалВИнтервал: return ИнтервалВИнтервал;
				case СпособыКопированияДанныхБюджетирования.РаспределениеНормированныхЗначений: return РаспределениеНормированныхЗначений;
			}
			return Guid.Empty;
		}
	}
}