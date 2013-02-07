
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum ВидыОтклоненийКонтролируемыхЗначенийБюджетов
	{
		ПустаяСсылка = - 1,
		Абсолютное = 0,
		Относительное = 1,
	}
	public static partial class ВидыОтклоненийКонтролируемыхЗначенийБюджетов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Абсолютное = new Guid("8c92d8b0-f897-5143-4592-43dd210a21b3");
		public static readonly Guid Относительное = new Guid("2b7a28b5-7b11-a0b7-42d0-77c6f3adcb27");
		public static ВидыОтклоненийКонтролируемыхЗначенийБюджетов Получить(this ВидыОтклоненийКонтролируемыхЗначенийБюджетов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОтклоненийКонтролируемыхЗначенийБюджетов Получить(this ВидыОтклоненийКонтролируемыхЗначенийБюджетов Значение, Guid Ссылка)
		{
			if(Ссылка == Абсолютное)
			{
				return ВидыОтклоненийКонтролируемыхЗначенийБюджетов.Абсолютное;
			}
			else if(Ссылка == Относительное)
			{
				return ВидыОтклоненийКонтролируемыхЗначенийБюджетов.Относительное;
			}
			return ВидыОтклоненийКонтролируемыхЗначенийБюджетов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОтклоненийКонтролируемыхЗначенийБюджетов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОтклоненийКонтролируемыхЗначенийБюджетов Значение)
		{
			switch (Значение)
			{
				case ВидыОтклоненийКонтролируемыхЗначенийБюджетов.Абсолютное: return Абсолютное;
				case ВидыОтклоненийКонтролируемыхЗначенийБюджетов.Относительное: return Относительное;
			}
			return Guid.Empty;
		}
	}
}