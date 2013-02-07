
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum СпособыРасчетаОстаткаОтпуска
	{
		ПустаяСсылка = - 1,
		ПоКалендарнымДням = 0,//По календарным дням
		ПоРабочимДням = 1,//По рабочим дням
	}
	public static partial class СпособыРасчетаОстаткаОтпуска_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоКалендарнымДням = new Guid("ee7cb187-356e-a59f-422a-7fb27ed7bc8d");//По календарным дням
		public static readonly Guid ПоРабочимДням = new Guid("a3674bad-68d7-1494-4b8a-70d894e15cad");//По рабочим дням
		public static СпособыРасчетаОстаткаОтпуска Получить(this СпособыРасчетаОстаткаОтпуска Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыРасчетаОстаткаОтпуска Получить(this СпособыРасчетаОстаткаОтпуска Значение, Guid Ссылка)
		{
			if(Ссылка == ПоКалендарнымДням)
			{
				return СпособыРасчетаОстаткаОтпуска.ПоКалендарнымДням;
			}
			else if(Ссылка == ПоРабочимДням)
			{
				return СпособыРасчетаОстаткаОтпуска.ПоРабочимДням;
			}
			return СпособыРасчетаОстаткаОтпуска.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыРасчетаОстаткаОтпуска Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыРасчетаОстаткаОтпуска Значение)
		{
			switch (Значение)
			{
				case СпособыРасчетаОстаткаОтпуска.ПоКалендарнымДням: return ПоКалендарнымДням;
				case СпособыРасчетаОстаткаОтпуска.ПоРабочимДням: return ПоРабочимДням;
			}
			return Guid.Empty;
		}
	}
}