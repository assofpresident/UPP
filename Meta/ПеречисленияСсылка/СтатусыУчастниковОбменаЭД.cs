
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum СтатусыУчастниковОбменаЭД
	{
		ПустаяСсылка = - 1,
		ТребуетсяПригласить = 0,//Требуется пригласить
		ТребуетсяОтсоединить = 1,//Требуется отсоединить
		Присоединен = 2,
		Отсоединен = 3,
		ОжидаемСогласия = 4,//Ожидаем согласия
		ЖдетСогласия = 5,//Ждет согласия
	}
	public static partial class СтатусыУчастниковОбменаЭД_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ТребуетсяПригласить = new Guid("f13cc397-1940-868e-4d06-cf019479fb61");//Требуется пригласить
		public static readonly Guid ТребуетсяОтсоединить = new Guid("9f8b168d-d94f-c500-4a9a-f2a180a9f9da");//Требуется отсоединить
		public static readonly Guid Присоединен = new Guid("753001b9-9bbc-f1f5-475b-b9e128cfcff1");
		public static readonly Guid Отсоединен = new Guid("8d17529e-decc-8e76-486b-a884e65b05bc");
		public static readonly Guid ОжидаемСогласия = new Guid("59ce0aa5-3bc0-58f2-4a92-2da65412cfd0");//Ожидаем согласия
		public static readonly Guid ЖдетСогласия = new Guid("9ffac1ab-327f-d024-4b8a-12f018bb61f9");//Ждет согласия
		public static СтатусыУчастниковОбменаЭД Получить(this СтатусыУчастниковОбменаЭД Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СтатусыУчастниковОбменаЭД Получить(this СтатусыУчастниковОбменаЭД Значение, Guid Ссылка)
		{
			if(Ссылка == ТребуетсяПригласить)
			{
				return СтатусыУчастниковОбменаЭД.ТребуетсяПригласить;
			}
			else if(Ссылка == ТребуетсяОтсоединить)
			{
				return СтатусыУчастниковОбменаЭД.ТребуетсяОтсоединить;
			}
			else if(Ссылка == Присоединен)
			{
				return СтатусыУчастниковОбменаЭД.Присоединен;
			}
			else if(Ссылка == Отсоединен)
			{
				return СтатусыУчастниковОбменаЭД.Отсоединен;
			}
			else if(Ссылка == ОжидаемСогласия)
			{
				return СтатусыУчастниковОбменаЭД.ОжидаемСогласия;
			}
			else if(Ссылка == ЖдетСогласия)
			{
				return СтатусыУчастниковОбменаЭД.ЖдетСогласия;
			}
			return СтатусыУчастниковОбменаЭД.ПустаяСсылка;
		}
		public static byte[] Ключ(this СтатусыУчастниковОбменаЭД Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СтатусыУчастниковОбменаЭД Значение)
		{
			switch (Значение)
			{
				case СтатусыУчастниковОбменаЭД.ТребуетсяПригласить: return ТребуетсяПригласить;
				case СтатусыУчастниковОбменаЭД.ТребуетсяОтсоединить: return ТребуетсяОтсоединить;
				case СтатусыУчастниковОбменаЭД.Присоединен: return Присоединен;
				case СтатусыУчастниковОбменаЭД.Отсоединен: return Отсоединен;
				case СтатусыУчастниковОбменаЭД.ОжидаемСогласия: return ОжидаемСогласия;
				case СтатусыУчастниковОбменаЭД.ЖдетСогласия: return ЖдетСогласия;
			}
			return Guid.Empty;
		}
	}
}