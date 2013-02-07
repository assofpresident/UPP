
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum ВидыИсточниковДанныхРасчетаПриБюджетировании
	{
		ПустаяСсылка = - 1,
		БюджетнаяОперация = 0,//Бюджетная операция
		ИсточникДанныхДляРасчетов = 1,//Источник данных для расчетов
		Произвольный = 2,
	}
	public static partial class ВидыИсточниковДанныхРасчетаПриБюджетировании_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid БюджетнаяОперация = new Guid("52eca188-2d8d-a785-4b54-7e19018ac9ce");//Бюджетная операция
		public static readonly Guid ИсточникДанныхДляРасчетов = new Guid("1bdb98b9-853e-f896-4610-5e01b7439e26");//Источник данных для расчетов
		public static readonly Guid Произвольный = new Guid("348d4da7-5c35-83fc-4433-3a9acf65d15a");
		public static ВидыИсточниковДанныхРасчетаПриБюджетировании Получить(this ВидыИсточниковДанныхРасчетаПриБюджетировании Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыИсточниковДанныхРасчетаПриБюджетировании Получить(this ВидыИсточниковДанныхРасчетаПриБюджетировании Значение, Guid Ссылка)
		{
			if(Ссылка == БюджетнаяОперация)
			{
				return ВидыИсточниковДанныхРасчетаПриБюджетировании.БюджетнаяОперация;
			}
			else if(Ссылка == ИсточникДанныхДляРасчетов)
			{
				return ВидыИсточниковДанныхРасчетаПриБюджетировании.ИсточникДанныхДляРасчетов;
			}
			else if(Ссылка == Произвольный)
			{
				return ВидыИсточниковДанныхРасчетаПриБюджетировании.Произвольный;
			}
			return ВидыИсточниковДанныхРасчетаПриБюджетировании.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыИсточниковДанныхРасчетаПриБюджетировании Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыИсточниковДанныхРасчетаПриБюджетировании Значение)
		{
			switch (Значение)
			{
				case ВидыИсточниковДанныхРасчетаПриБюджетировании.БюджетнаяОперация: return БюджетнаяОперация;
				case ВидыИсточниковДанныхРасчетаПриБюджетировании.ИсточникДанныхДляРасчетов: return ИсточникДанныхДляРасчетов;
				case ВидыИсточниковДанныхРасчетаПриБюджетировании.Произвольный: return Произвольный;
			}
			return Guid.Empty;
		}
	}
}