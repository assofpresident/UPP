
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum РезультатРассмотренияКоллизии
	{
		ПустаяСсылка = - 1,
		ОбъектЗамененНаВерсиюПоступившуюПриОбмене = 0,//Объект заменен на версию объекта обмена
		ОбъектНеБылИзменен = 1,//Объект не изменен
	}
	public static partial class РезультатРассмотренияКоллизии_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ОбъектЗамененНаВерсиюПоступившуюПриОбмене = new Guid("d3f051a7-5499-9af3-4be1-1bea4605aca6");//Объект заменен на версию объекта обмена
		public static readonly Guid ОбъектНеБылИзменен = new Guid("a8a1f5b6-6ead-5baa-4ea2-2731ab9746ff");//Объект не изменен
		public static РезультатРассмотренияКоллизии Получить(this РезультатРассмотренияКоллизии Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static РезультатРассмотренияКоллизии Получить(this РезультатРассмотренияКоллизии Значение, Guid Ссылка)
		{
			if(Ссылка == ОбъектЗамененНаВерсиюПоступившуюПриОбмене)
			{
				return РезультатРассмотренияКоллизии.ОбъектЗамененНаВерсиюПоступившуюПриОбмене;
			}
			else if(Ссылка == ОбъектНеБылИзменен)
			{
				return РезультатРассмотренияКоллизии.ОбъектНеБылИзменен;
			}
			return РезультатРассмотренияКоллизии.ПустаяСсылка;
		}
		public static byte[] Ключ(this РезультатРассмотренияКоллизии Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this РезультатРассмотренияКоллизии Значение)
		{
			switch (Значение)
			{
				case РезультатРассмотренияКоллизии.ОбъектЗамененНаВерсиюПоступившуюПриОбмене: return ОбъектЗамененНаВерсиюПоступившуюПриОбмене;
				case РезультатРассмотренияКоллизии.ОбъектНеБылИзменен: return ОбъектНеБылИзменен;
			}
			return Guid.Empty;
		}
	}
}