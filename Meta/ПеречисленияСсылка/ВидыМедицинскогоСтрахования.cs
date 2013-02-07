
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыМедицинскогоСтрахования
	{
		ПустаяСсылка = - 1,
		Обязательное = 0,
		Добровольное = 1,
	}
	public static partial class ВидыМедицинскогоСтрахования_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Обязательное = new Guid("3deea286-0642-1121-4142-556d3d6103d8");
		public static readonly Guid Добровольное = new Guid("4e4661a4-d63d-d4d5-4703-146a6c2ea03e");
		public static ВидыМедицинскогоСтрахования Получить(this ВидыМедицинскогоСтрахования Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыМедицинскогоСтрахования Получить(this ВидыМедицинскогоСтрахования Значение, Guid Ссылка)
		{
			if(Ссылка == Обязательное)
			{
				return ВидыМедицинскогоСтрахования.Обязательное;
			}
			else if(Ссылка == Добровольное)
			{
				return ВидыМедицинскогоСтрахования.Добровольное;
			}
			return ВидыМедицинскогоСтрахования.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыМедицинскогоСтрахования Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыМедицинскогоСтрахования Значение)
		{
			switch (Значение)
			{
				case ВидыМедицинскогоСтрахования.Обязательное: return Обязательное;
				case ВидыМедицинскогоСтрахования.Добровольное: return Добровольное;
			}
			return Guid.Empty;
		}
	}
}