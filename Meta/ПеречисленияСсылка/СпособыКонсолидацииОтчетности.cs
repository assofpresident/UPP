
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum СпособыКонсолидацииОтчетности
	{
		ПустаяСсылка = - 1,
		Полная = 0,//Полная консолидация
		СпособДолевогоУчастия = 1,//Способ долевого участия
		ПропорциональноВключению = 2,//Пропорционально включению
	}
	public static partial class СпособыКонсолидацииОтчетности_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Полная = new Guid("2fabd2a8-b169-69d0-437f-e43d77bfda61");//Полная консолидация
		public static readonly Guid СпособДолевогоУчастия = new Guid("3448a682-027d-452c-4127-7f0dd3018e18");//Способ долевого участия
		public static readonly Guid ПропорциональноВключению = new Guid("04c8abb2-da57-5426-49bb-cd8f34344ca1");//Пропорционально включению
		public static СпособыКонсолидацииОтчетности Получить(this СпособыКонсолидацииОтчетности Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыКонсолидацииОтчетности Получить(this СпособыКонсолидацииОтчетности Значение, Guid Ссылка)
		{
			if(Ссылка == Полная)
			{
				return СпособыКонсолидацииОтчетности.Полная;
			}
			else if(Ссылка == СпособДолевогоУчастия)
			{
				return СпособыКонсолидацииОтчетности.СпособДолевогоУчастия;
			}
			else if(Ссылка == ПропорциональноВключению)
			{
				return СпособыКонсолидацииОтчетности.ПропорциональноВключению;
			}
			return СпособыКонсолидацииОтчетности.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыКонсолидацииОтчетности Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыКонсолидацииОтчетности Значение)
		{
			switch (Значение)
			{
				case СпособыКонсолидацииОтчетности.Полная: return Полная;
				case СпособыКонсолидацииОтчетности.СпособДолевогоУчастия: return СпособДолевогоУчастия;
				case СпособыКонсолидацииОтчетности.ПропорциональноВключению: return ПропорциональноВключению;
			}
			return Guid.Empty;
		}
	}
}