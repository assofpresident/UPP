
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Регл)
		///</summary>
	public enum ПорядокФормированияСправкиОДоходахФизлица
	{
		ПустаяСсылка = - 1,
		ДляПередачиВИФНС = 0,//Для передачи в ИФНС
		ФизлицуСводно = 1,//Физлицу сводно
		ФизлицуВРазрезеКодовОКАТО = 2,//Физлицу в разрезе кодов ОКАТО
	}
	public static partial class ПорядокФормированияСправкиОДоходахФизлица_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ДляПередачиВИФНС = new Guid("454738bd-7bcc-57e7-4d58-ced2a4a2bfc6");//Для передачи в ИФНС
		public static readonly Guid ФизлицуСводно = new Guid("a1aa52a4-2fa1-6d79-419a-7b6cb574b463");//Физлицу сводно
		public static readonly Guid ФизлицуВРазрезеКодовОКАТО = new Guid("a4eccea9-ca7d-367b-4ece-1e678ef31f22");//Физлицу в разрезе кодов ОКАТО
		public static ПорядокФормированияСправкиОДоходахФизлица Получить(this ПорядокФормированияСправкиОДоходахФизлица Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ПорядокФормированияСправкиОДоходахФизлица Получить(this ПорядокФормированияСправкиОДоходахФизлица Значение, Guid Ссылка)
		{
			if(Ссылка == ДляПередачиВИФНС)
			{
				return ПорядокФормированияСправкиОДоходахФизлица.ДляПередачиВИФНС;
			}
			else if(Ссылка == ФизлицуСводно)
			{
				return ПорядокФормированияСправкиОДоходахФизлица.ФизлицуСводно;
			}
			else if(Ссылка == ФизлицуВРазрезеКодовОКАТО)
			{
				return ПорядокФормированияСправкиОДоходахФизлица.ФизлицуВРазрезеКодовОКАТО;
			}
			return ПорядокФормированияСправкиОДоходахФизлица.ПустаяСсылка;
		}
		public static byte[] Ключ(this ПорядокФормированияСправкиОДоходахФизлица Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ПорядокФормированияСправкиОДоходахФизлица Значение)
		{
			switch (Значение)
			{
				case ПорядокФормированияСправкиОДоходахФизлица.ДляПередачиВИФНС: return ДляПередачиВИФНС;
				case ПорядокФормированияСправкиОДоходахФизлица.ФизлицуСводно: return ФизлицуСводно;
				case ПорядокФормированияСправкиОДоходахФизлица.ФизлицуВРазрезеКодовОКАТО: return ФизлицуВРазрезеКодовОКАТО;
			}
			return Guid.Empty;
		}
	}
}