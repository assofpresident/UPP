
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам
	{
		ПустаяСсылка = - 1,
		РасчетыСПоставщиками = 0,//Расчеты с поставщиками
		РасчетыСПокупателями = 1,//Расчеты с покупателями
		РасчетыПоПрочимОперациям = 2,//Расчеты по прочим операциям
		РезервыПоСомнительнымДолгам = 3,//Резервы по сомнительным долгам
	}
	public static partial class ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid РасчетыСПоставщиками = new Guid("fc1c9c93-a304-3645-41ab-1659c55d607c");//Расчеты с поставщиками
		public static readonly Guid РасчетыСПокупателями = new Guid("3b4b1a86-75b4-2b65-42dc-d4b781174d5f");//Расчеты с покупателями
		public static readonly Guid РасчетыПоПрочимОперациям = new Guid("4e332f92-14ab-db95-4646-21eefc6fc8a2");//Расчеты по прочим операциям
		public static readonly Guid РезервыПоСомнительнымДолгам = new Guid("987e30a9-d908-19f0-4d20-c4bbe2bfa3b5");//Резервы по сомнительным долгам
		public static ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам Получить(this ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам Получить(this ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам Значение, Guid Ссылка)
		{
			if(Ссылка == РасчетыСПоставщиками)
			{
				return ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам.РасчетыСПоставщиками;
			}
			else if(Ссылка == РасчетыСПокупателями)
			{
				return ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам.РасчетыСПокупателями;
			}
			else if(Ссылка == РасчетыПоПрочимОперациям)
			{
				return ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам.РасчетыПоПрочимОперациям;
			}
			else if(Ссылка == РезервыПоСомнительнымДолгам)
			{
				return ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам.РезервыПоСомнительнымДолгам;
			}
			return ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам.РасчетыСПоставщиками: return РасчетыСПоставщиками;
				case ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам.РасчетыСПокупателями: return РасчетыСПокупателями;
				case ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам.РасчетыПоПрочимОперациям: return РасчетыПоПрочимОперациям;
				case ВидыОперацийВводНачальныхОстатковПоВзаиморасчетам.РезервыПоСомнительнымДолгам: return РезервыПоСомнительнымДолгам;
			}
			return Guid.Empty;
		}
	}
}