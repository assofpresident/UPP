
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum СтратегииОтраженияВРеглУчетеНачислений
	{
		ПустаяСсылка = - 1,
		КакЗаданоВидуРасчета = 0,//Как задано виду расчета
		КакЗаданоНаНачалоСобытия = 1,//Как задано на начало события
		КакБазовыеНачисления = 2,//Как базовые начисления
	}
	public static partial class СтратегииОтраженияВРеглУчетеНачислений_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid КакЗаданоВидуРасчета = new Guid("5d482387-275a-5406-466f-c98fe3f7fe44");//Как задано виду расчета
		public static readonly Guid КакЗаданоНаНачалоСобытия = new Guid("947d3aa6-7723-1268-4260-014b6c1ce911");//Как задано на начало события
		public static readonly Guid КакБазовыеНачисления = new Guid("e2d253a0-4c11-0fc1-4b04-f2501866a81b");//Как базовые начисления
		public static СтратегииОтраженияВРеглУчетеНачислений Получить(this СтратегииОтраженияВРеглУчетеНачислений Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СтратегииОтраженияВРеглУчетеНачислений Получить(this СтратегииОтраженияВРеглУчетеНачислений Значение, Guid Ссылка)
		{
			if(Ссылка == КакЗаданоВидуРасчета)
			{
				return СтратегииОтраженияВРеглУчетеНачислений.КакЗаданоВидуРасчета;
			}
			else if(Ссылка == КакЗаданоНаНачалоСобытия)
			{
				return СтратегииОтраженияВРеглУчетеНачислений.КакЗаданоНаНачалоСобытия;
			}
			else if(Ссылка == КакБазовыеНачисления)
			{
				return СтратегииОтраженияВРеглУчетеНачислений.КакБазовыеНачисления;
			}
			return СтратегииОтраженияВРеглУчетеНачислений.ПустаяСсылка;
		}
		public static byte[] Ключ(this СтратегииОтраженияВРеглУчетеНачислений Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СтратегииОтраженияВРеглУчетеНачислений Значение)
		{
			switch (Значение)
			{
				case СтратегииОтраженияВРеглУчетеНачислений.КакЗаданоВидуРасчета: return КакЗаданоВидуРасчета;
				case СтратегииОтраженияВРеглУчетеНачислений.КакЗаданоНаНачалоСобытия: return КакЗаданоНаНачалоСобытия;
				case СтратегииОтраженияВРеглУчетеНачислений.КакБазовыеНачисления: return КакБазовыеНачисления;
			}
			return Guid.Empty;
		}
	}
}