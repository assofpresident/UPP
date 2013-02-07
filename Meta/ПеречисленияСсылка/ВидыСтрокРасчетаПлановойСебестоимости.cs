
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыСтрокРасчетаПлановойСебестоимости
	{
		ПустаяСсылка = - 1,
		ПрямыеМатериальныеЗатраты = 0,//Прямые материальные затраты
		ПрямыеНематериальныеЗатраты = 1,//Прямые нематериальные затраты
		КосвенныеЗатраты = 2,//Косвенные затраты
	}
	public static partial class ВидыСтрокРасчетаПлановойСебестоимости_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПрямыеМатериальныеЗатраты = new Guid("a68adabf-f6d9-3e6f-4ddc-10a2d59e4e4b");//Прямые материальные затраты
		public static readonly Guid ПрямыеНематериальныеЗатраты = new Guid("12444695-afe7-167b-4c6c-895800481a04");//Прямые нематериальные затраты
		public static readonly Guid КосвенныеЗатраты = new Guid("2e1bfb88-1821-5ada-4e4a-fc7f7934103c");//Косвенные затраты
		public static ВидыСтрокРасчетаПлановойСебестоимости Получить(this ВидыСтрокРасчетаПлановойСебестоимости Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыСтрокРасчетаПлановойСебестоимости Получить(this ВидыСтрокРасчетаПлановойСебестоимости Значение, Guid Ссылка)
		{
			if(Ссылка == ПрямыеМатериальныеЗатраты)
			{
				return ВидыСтрокРасчетаПлановойСебестоимости.ПрямыеМатериальныеЗатраты;
			}
			else if(Ссылка == ПрямыеНематериальныеЗатраты)
			{
				return ВидыСтрокРасчетаПлановойСебестоимости.ПрямыеНематериальныеЗатраты;
			}
			else if(Ссылка == КосвенныеЗатраты)
			{
				return ВидыСтрокРасчетаПлановойСебестоимости.КосвенныеЗатраты;
			}
			return ВидыСтрокРасчетаПлановойСебестоимости.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыСтрокРасчетаПлановойСебестоимости Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыСтрокРасчетаПлановойСебестоимости Значение)
		{
			switch (Значение)
			{
				case ВидыСтрокРасчетаПлановойСебестоимости.ПрямыеМатериальныеЗатраты: return ПрямыеМатериальныеЗатраты;
				case ВидыСтрокРасчетаПлановойСебестоимости.ПрямыеНематериальныеЗатраты: return ПрямыеНематериальныеЗатраты;
				case ВидыСтрокРасчетаПлановойСебестоимости.КосвенныеЗатраты: return КосвенныеЗатраты;
			}
			return Guid.Empty;
		}
	}
}