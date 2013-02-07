
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыДополнительныхСтатейЗатрат
	{
		ПустаяСсылка = - 1,
		СтраховыеВзносы = 0,//Страховые взносы
		ФСС_НС = 1,//ФСС НС 
		ПособияЗаСчетРаботодателя = 2,//Пособия за счет работодателя
		ЕСН = 3,//ЕСН (по 2009 год)
		ПФР = 4,//Отчисления в ПФР (по 2009 год)
		ФСС_БЛ = 5,//ФСС БЛ (по 2009 год)
	}
	public static partial class ВидыДополнительныхСтатейЗатрат_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid СтраховыеВзносы = new Guid("1c5bbd8e-08a0-4ce9-4216-1f9fa737a150");//Страховые взносы
		public static readonly Guid ФСС_НС = new Guid("5d2259b8-d8b9-60a9-449a-6d6e731dda1e");//ФСС НС 
		public static readonly Guid ПособияЗаСчетРаботодателя = new Guid("efcf09b9-a754-20cd-4ae6-e292b4de33fd");//Пособия за счет работодателя
		public static readonly Guid ЕСН = new Guid("f9a60484-02fe-82b4-43dd-3809f0a01508");//ЕСН (по 2009 год)
		public static readonly Guid ПФР = new Guid("f1de9c89-0891-2a7f-4585-d4fc2fe5b460");//Отчисления в ПФР (по 2009 год)
		public static readonly Guid ФСС_БЛ = new Guid("ced47396-e1d7-a113-4246-6512b69a169e");//ФСС БЛ (по 2009 год)
		public static ВидыДополнительныхСтатейЗатрат Получить(this ВидыДополнительныхСтатейЗатрат Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыДополнительныхСтатейЗатрат Получить(this ВидыДополнительныхСтатейЗатрат Значение, Guid Ссылка)
		{
			if(Ссылка == СтраховыеВзносы)
			{
				return ВидыДополнительныхСтатейЗатрат.СтраховыеВзносы;
			}
			else if(Ссылка == ФСС_НС)
			{
				return ВидыДополнительныхСтатейЗатрат.ФСС_НС;
			}
			else if(Ссылка == ПособияЗаСчетРаботодателя)
			{
				return ВидыДополнительныхСтатейЗатрат.ПособияЗаСчетРаботодателя;
			}
			else if(Ссылка == ЕСН)
			{
				return ВидыДополнительныхСтатейЗатрат.ЕСН;
			}
			else if(Ссылка == ПФР)
			{
				return ВидыДополнительныхСтатейЗатрат.ПФР;
			}
			else if(Ссылка == ФСС_БЛ)
			{
				return ВидыДополнительныхСтатейЗатрат.ФСС_БЛ;
			}
			return ВидыДополнительныхСтатейЗатрат.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыДополнительныхСтатейЗатрат Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыДополнительныхСтатейЗатрат Значение)
		{
			switch (Значение)
			{
				case ВидыДополнительныхСтатейЗатрат.СтраховыеВзносы: return СтраховыеВзносы;
				case ВидыДополнительныхСтатейЗатрат.ФСС_НС: return ФСС_НС;
				case ВидыДополнительныхСтатейЗатрат.ПособияЗаСчетРаботодателя: return ПособияЗаСчетРаботодателя;
				case ВидыДополнительныхСтатейЗатрат.ЕСН: return ЕСН;
				case ВидыДополнительныхСтатейЗатрат.ПФР: return ПФР;
				case ВидыДополнительныхСтатейЗатрат.ФСС_БЛ: return ФСС_БЛ;
			}
			return Guid.Empty;
		}
	}
}