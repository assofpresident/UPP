
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ТипыЭлементовВерсииЭД
	{
		ПустаяСсылка = - 1,
		ИОП = 0,//Извещение о получении
		ИППДОИПЭСФ = 1,//Извещение о получении подтверждения даты отправки извещения о получении электронного счета-фактуры
		ИППДОЭСФ = 2,//Извещение о получении подтверждения даты отправки электронного счета-фактуры
		ИППДПЭСФ = 3,//Извещение о получении подтверждения даты получения электронного счета-фактуры
		ИПУУЭСФ = 4,//Извещение о получении уведомления об уточнении электронного счета-фактуры
		ИПЭСФ = 5,//Извещение о получении электронного счета-фактуры
		ПДО = 6,//Подтверждение даты отправки
		ПДОИПЭСФ = 7,//Подтверждение даты отправки извещения о получении электронного счета-фактуры
		ПДОЭСФ = 8,//Подтверждение даты отправки электронного счета-фактуры
		ПДПЭСФ = 9,//Подтверждение даты получения электронного счета-фактуры
		ПервичныйЭД = 10,//Первичный электронный документ
		УОУ = 11,//Уведомление об уточнении
		УУЭСФ = 12,//Уведомление об уточнении электронного счета-фактуры
		ЭСФ = 13,//Электронный счет-фактура
		Ошибка = 14,
		ДополнительныйЭД = 15,//Дополнительный ЭД
	}
	public static partial class ТипыЭлементовВерсииЭД_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ИОП = new Guid("27252598-5eba-d0e8-418d-80ded378a942");//Извещение о получении
		public static readonly Guid ИППДОИПЭСФ = new Guid("ddfa2a83-406b-26f9-4fce-0e465c575846");//Извещение о получении подтверждения даты отправки извещения о получении электронного счета-фактуры
		public static readonly Guid ИППДОЭСФ = new Guid("96ca83b1-a325-ae03-4ce5-155f84c982d1");//Извещение о получении подтверждения даты отправки электронного счета-фактуры
		public static readonly Guid ИППДПЭСФ = new Guid("26e23e82-9980-b3cc-4a15-4984667f4b5c");//Извещение о получении подтверждения даты получения электронного счета-фактуры
		public static readonly Guid ИПУУЭСФ = new Guid("8256e9a4-93c2-42a6-4165-48a1036c5fc4");//Извещение о получении уведомления об уточнении электронного счета-фактуры
		public static readonly Guid ИПЭСФ = new Guid("e94a5ab1-c8bd-6c52-45d1-b2943d93ff5d");//Извещение о получении электронного счета-фактуры
		public static readonly Guid ПДО = new Guid("5deceb9d-8acf-575c-46f1-ca70d2f8d4f2");//Подтверждение даты отправки
		public static readonly Guid ПДОИПЭСФ = new Guid("19ec5abc-9667-1b38-41d8-b9d8f1424676");//Подтверждение даты отправки извещения о получении электронного счета-фактуры
		public static readonly Guid ПДОЭСФ = new Guid("8d1712a6-d190-ba39-4555-4b6cb1b7f9bf");//Подтверждение даты отправки электронного счета-фактуры
		public static readonly Guid ПДПЭСФ = new Guid("4f529586-d737-473c-43b5-199464bb4064");//Подтверждение даты получения электронного счета-фактуры
		public static readonly Guid ПервичныйЭД = new Guid("2433ac8f-d2a5-917e-4322-5b71cc9257be");//Первичный электронный документ
		public static readonly Guid УОУ = new Guid("16633e85-396f-d493-446a-d75ec37c4ee9");//Уведомление об уточнении
		public static readonly Guid УУЭСФ = new Guid("118b4d88-c26a-7640-4589-35936f40de15");//Уведомление об уточнении электронного счета-фактуры
		public static readonly Guid ЭСФ = new Guid("3dc5e0a1-20c1-1ec7-44b9-199d4fc5ac33");//Электронный счет-фактура
		public static readonly Guid Ошибка = new Guid("b4b689a4-3d93-226d-4d84-1c263259e998");
		public static readonly Guid ДополнительныйЭД = new Guid("3c2d62b9-7433-72a7-4de5-2af7c283700a");//Дополнительный ЭД
		public static ТипыЭлементовВерсииЭД Получить(this ТипыЭлементовВерсииЭД Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТипыЭлементовВерсииЭД Получить(this ТипыЭлементовВерсииЭД Значение, Guid Ссылка)
		{
			if(Ссылка == ИОП)
			{
				return ТипыЭлементовВерсииЭД.ИОП;
			}
			else if(Ссылка == ИППДОИПЭСФ)
			{
				return ТипыЭлементовВерсииЭД.ИППДОИПЭСФ;
			}
			else if(Ссылка == ИППДОЭСФ)
			{
				return ТипыЭлементовВерсииЭД.ИППДОЭСФ;
			}
			else if(Ссылка == ИППДПЭСФ)
			{
				return ТипыЭлементовВерсииЭД.ИППДПЭСФ;
			}
			else if(Ссылка == ИПУУЭСФ)
			{
				return ТипыЭлементовВерсииЭД.ИПУУЭСФ;
			}
			else if(Ссылка == ИПЭСФ)
			{
				return ТипыЭлементовВерсииЭД.ИПЭСФ;
			}
			else if(Ссылка == ПДО)
			{
				return ТипыЭлементовВерсииЭД.ПДО;
			}
			else if(Ссылка == ПДОИПЭСФ)
			{
				return ТипыЭлементовВерсииЭД.ПДОИПЭСФ;
			}
			else if(Ссылка == ПДОЭСФ)
			{
				return ТипыЭлементовВерсииЭД.ПДОЭСФ;
			}
			else if(Ссылка == ПДПЭСФ)
			{
				return ТипыЭлементовВерсииЭД.ПДПЭСФ;
			}
			else if(Ссылка == ПервичныйЭД)
			{
				return ТипыЭлементовВерсииЭД.ПервичныйЭД;
			}
			else if(Ссылка == УОУ)
			{
				return ТипыЭлементовВерсииЭД.УОУ;
			}
			else if(Ссылка == УУЭСФ)
			{
				return ТипыЭлементовВерсииЭД.УУЭСФ;
			}
			else if(Ссылка == ЭСФ)
			{
				return ТипыЭлементовВерсииЭД.ЭСФ;
			}
			else if(Ссылка == Ошибка)
			{
				return ТипыЭлементовВерсииЭД.Ошибка;
			}
			else if(Ссылка == ДополнительныйЭД)
			{
				return ТипыЭлементовВерсииЭД.ДополнительныйЭД;
			}
			return ТипыЭлементовВерсииЭД.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТипыЭлементовВерсииЭД Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТипыЭлементовВерсииЭД Значение)
		{
			switch (Значение)
			{
				case ТипыЭлементовВерсииЭД.ИОП: return ИОП;
				case ТипыЭлементовВерсииЭД.ИППДОИПЭСФ: return ИППДОИПЭСФ;
				case ТипыЭлементовВерсииЭД.ИППДОЭСФ: return ИППДОЭСФ;
				case ТипыЭлементовВерсииЭД.ИППДПЭСФ: return ИППДПЭСФ;
				case ТипыЭлементовВерсииЭД.ИПУУЭСФ: return ИПУУЭСФ;
				case ТипыЭлементовВерсииЭД.ИПЭСФ: return ИПЭСФ;
				case ТипыЭлементовВерсииЭД.ПДО: return ПДО;
				case ТипыЭлементовВерсииЭД.ПДОИПЭСФ: return ПДОИПЭСФ;
				case ТипыЭлементовВерсииЭД.ПДОЭСФ: return ПДОЭСФ;
				case ТипыЭлементовВерсииЭД.ПДПЭСФ: return ПДПЭСФ;
				case ТипыЭлементовВерсииЭД.ПервичныйЭД: return ПервичныйЭД;
				case ТипыЭлементовВерсииЭД.УОУ: return УОУ;
				case ТипыЭлементовВерсииЭД.УУЭСФ: return УУЭСФ;
				case ТипыЭлементовВерсииЭД.ЭСФ: return ЭСФ;
				case ТипыЭлементовВерсииЭД.Ошибка: return Ошибка;
				case ТипыЭлементовВерсииЭД.ДополнительныйЭД: return ДополнительныйЭД;
			}
			return Guid.Empty;
		}
	}
}