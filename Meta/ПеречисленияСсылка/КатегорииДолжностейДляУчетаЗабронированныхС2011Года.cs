
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Регл)
		///</summary>
	public enum КатегорииДолжностейДляУчетаЗабронированныхС2011Года
	{
		ПустаяСсылка = - 1,
		Руководители = 0,
		СпециалистыСХ = 1,//Специалисты сельского хозяйства
		СпециалистыПолезныеИскопаемые = 2,//Специалисты по ВЭД Добыча полезных ископаемых
		СпециалистыОбрабатывающиеПроизводства = 3,//Специалисты по ВЭД Обрабатывающие производства
		СпециалистыПроизводствоЭлектроэнергии = 4,//Специалисты по ВЭД Производство и распределение электро-энергии, газа и воды
		СпециалистыСтроительство = 5,//Специалисты по ВЭД Строительство
		СпециалистыТранспорт = 6,//Специалисты по ВЭД Транспорт и связь
		СпециалистыОбразования = 7,//Специалисты по ВЭД Образование, включая студентов, курсантов и пр.
		СпециалистыЗдравоохранение = 8,//Специалисты по ВЭД Здравоохранение и предоставление социальных услуг
		ПрочиеСпециалисты = 9,//Специалисты, работающие в прочих видах экономической деятельности
		ДругиеСлужащие = 10,//Другие служащие (делопроизводители, секретари и др. )
		РабочиеИмеющиеТарифныйРазряд = 11,//Рабочие имеющие тарифный разряд
		РабочиеНеИмеющиеТарифныхРазрядов = 12,//Рабочие не имеющие тарифных разрядов
		РабочиеСХ = 13,//Рабочие сельскохозяйственного производства
		РабочиеЛокомотивныхБригад = 14,//Рабочие локомотивных бригад
		Водители = 15,
		Трактористы = 16,
	}
	public static partial class КатегорииДолжностейДляУчетаЗабронированныхС2011Года_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Руководители = new Guid("c4cc0588-4908-2b97-4058-38076620a80c");
		public static readonly Guid СпециалистыСХ = new Guid("eb91a4ba-7da0-23dd-4c8b-65b740efa928");//Специалисты сельского хозяйства
		public static readonly Guid СпециалистыПолезныеИскопаемые = new Guid("953d8f95-bfb0-29ac-4f55-646088f79ff3");//Специалисты по ВЭД Добыча полезных ископаемых
		public static readonly Guid СпециалистыОбрабатывающиеПроизводства = new Guid("6d057c98-a30a-a7ff-401a-43d18e7667a5");//Специалисты по ВЭД Обрабатывающие производства
		public static readonly Guid СпециалистыПроизводствоЭлектроэнергии = new Guid("41888783-8919-0424-4924-d36a3d9306f8");//Специалисты по ВЭД Производство и распределение электро-энергии, газа и воды
		public static readonly Guid СпециалистыСтроительство = new Guid("b819938f-7f3e-e0f8-4103-a8448c080d70");//Специалисты по ВЭД Строительство
		public static readonly Guid СпециалистыТранспорт = new Guid("057277a8-d6f8-7de4-4da9-1bbae79f578e");//Специалисты по ВЭД Транспорт и связь
		public static readonly Guid СпециалистыОбразования = new Guid("0587568e-2bb9-9792-4811-8888d557b63e");//Специалисты по ВЭД Образование, включая студентов, курсантов и пр.
		public static readonly Guid СпециалистыЗдравоохранение = new Guid("894878a7-9604-7d6a-42c8-0b49709a6d86");//Специалисты по ВЭД Здравоохранение и предоставление социальных услуг
		public static readonly Guid ПрочиеСпециалисты = new Guid("6a94ca9e-3c6f-5779-4e47-8454dd1a4e19");//Специалисты, работающие в прочих видах экономической деятельности
		public static readonly Guid ДругиеСлужащие = new Guid("81b6abab-8491-2156-44fc-be5c7e5e90c0");//Другие служащие (делопроизводители, секретари и др. )
		public static readonly Guid РабочиеИмеющиеТарифныйРазряд = new Guid("3eff27ac-bb9b-8482-46ed-ca5e289d5672");//Рабочие имеющие тарифный разряд
		public static readonly Guid РабочиеНеИмеющиеТарифныхРазрядов = new Guid("f27a95a5-8e07-56e2-4282-deb7112360d0");//Рабочие не имеющие тарифных разрядов
		public static readonly Guid РабочиеСХ = new Guid("bbcd3997-9056-67dd-42db-2e251977c1a7");//Рабочие сельскохозяйственного производства
		public static readonly Guid РабочиеЛокомотивныхБригад = new Guid("a512d098-c8fc-0eed-4b15-6533f5e10753");//Рабочие локомотивных бригад
		public static readonly Guid Водители = new Guid("247f36a6-223a-6f27-4522-ee444bd1cad5");
		public static readonly Guid Трактористы = new Guid("9c01d3b7-0096-dd5d-4bab-2c5a2aaf9d7b");
		public static КатегорииДолжностейДляУчетаЗабронированныхС2011Года Получить(this КатегорииДолжностейДляУчетаЗабронированныхС2011Года Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static КатегорииДолжностейДляУчетаЗабронированныхС2011Года Получить(this КатегорииДолжностейДляУчетаЗабронированныхС2011Года Значение, Guid Ссылка)
		{
			if(Ссылка == Руководители)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.Руководители;
			}
			else if(Ссылка == СпециалистыСХ)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыСХ;
			}
			else if(Ссылка == СпециалистыПолезныеИскопаемые)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыПолезныеИскопаемые;
			}
			else if(Ссылка == СпециалистыОбрабатывающиеПроизводства)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыОбрабатывающиеПроизводства;
			}
			else if(Ссылка == СпециалистыПроизводствоЭлектроэнергии)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыПроизводствоЭлектроэнергии;
			}
			else if(Ссылка == СпециалистыСтроительство)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыСтроительство;
			}
			else if(Ссылка == СпециалистыТранспорт)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыТранспорт;
			}
			else if(Ссылка == СпециалистыОбразования)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыОбразования;
			}
			else if(Ссылка == СпециалистыЗдравоохранение)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыЗдравоохранение;
			}
			else if(Ссылка == ПрочиеСпециалисты)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.ПрочиеСпециалисты;
			}
			else if(Ссылка == ДругиеСлужащие)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.ДругиеСлужащие;
			}
			else if(Ссылка == РабочиеИмеющиеТарифныйРазряд)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.РабочиеИмеющиеТарифныйРазряд;
			}
			else if(Ссылка == РабочиеНеИмеющиеТарифныхРазрядов)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.РабочиеНеИмеющиеТарифныхРазрядов;
			}
			else if(Ссылка == РабочиеСХ)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.РабочиеСХ;
			}
			else if(Ссылка == РабочиеЛокомотивныхБригад)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.РабочиеЛокомотивныхБригад;
			}
			else if(Ссылка == Водители)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.Водители;
			}
			else if(Ссылка == Трактористы)
			{
				return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.Трактористы;
			}
			return КатегорииДолжностейДляУчетаЗабронированныхС2011Года.ПустаяСсылка;
		}
		public static byte[] Ключ(this КатегорииДолжностейДляУчетаЗабронированныхС2011Года Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this КатегорииДолжностейДляУчетаЗабронированныхС2011Года Значение)
		{
			switch (Значение)
			{
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.Руководители: return Руководители;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыСХ: return СпециалистыСХ;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыПолезныеИскопаемые: return СпециалистыПолезныеИскопаемые;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыОбрабатывающиеПроизводства: return СпециалистыОбрабатывающиеПроизводства;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыПроизводствоЭлектроэнергии: return СпециалистыПроизводствоЭлектроэнергии;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыСтроительство: return СпециалистыСтроительство;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыТранспорт: return СпециалистыТранспорт;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыОбразования: return СпециалистыОбразования;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.СпециалистыЗдравоохранение: return СпециалистыЗдравоохранение;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.ПрочиеСпециалисты: return ПрочиеСпециалисты;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.ДругиеСлужащие: return ДругиеСлужащие;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.РабочиеИмеющиеТарифныйРазряд: return РабочиеИмеющиеТарифныйРазряд;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.РабочиеНеИмеющиеТарифныхРазрядов: return РабочиеНеИмеющиеТарифныхРазрядов;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.РабочиеСХ: return РабочиеСХ;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.РабочиеЛокомотивныхБригад: return РабочиеЛокомотивныхБригад;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.Водители: return Водители;
				case КатегорииДолжностейДляУчетаЗабронированныхС2011Года.Трактористы: return Трактористы;
			}
			return Guid.Empty;
		}
	}
}