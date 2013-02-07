
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Регл)
		///</summary>
	public enum ВидыСобытийОС
	{
		ПустаяСсылка = - 1,
		ПринятиеКУчету = 0,//Принятие к учету
		ВводВЭксплуатацию = 1,//Ввод в эксплуатацию
		ВнутреннееПеремещение = 2,//Внутреннее перемещение
		ТекущийРемонт = 3,//Текущий ремонт
		СреднийРемонт = 4,//Средний ремонт
		КапитальныйРемонт = 5,//Капитальный ремонт
		Переоценка = 6,
		Реконструкция = 7,
		Достройка = 8,
		Дооборудование = 9,
		ЧастичнаяЛиквидация = 10,//Частичная ликвидация
		Модернизация = 11,
		ПодготовкаКПередаче = 12,//Подготовка к передаче
		Передача = 13,
	///<summary>
	///Списание
	///</summary>
		Списание = 14,
	///<summary>
	///Прочее
	///</summary>
		Прочее = 15,
	}
	public static partial class ВидыСобытийОС_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПринятиеКУчету = new Guid("47f87f9f-c30f-4169-4e56-f0041d0d5a1f");//Принятие к учету
		public static readonly Guid ВводВЭксплуатацию = new Guid("629ab8ac-fb31-a2ff-4db9-563dae8e3eb0");//Ввод в эксплуатацию
		public static readonly Guid ВнутреннееПеремещение = new Guid("35678dbf-5f34-a237-4953-96ae9adddb54");//Внутреннее перемещение
		public static readonly Guid ТекущийРемонт = new Guid("a627caa3-11d4-7db1-4558-4b7881382f6c");//Текущий ремонт
		public static readonly Guid СреднийРемонт = new Guid("a2900189-54f0-d559-4b77-50bac2e60da5");//Средний ремонт
		public static readonly Guid КапитальныйРемонт = new Guid("7e16c7ae-3041-293c-441f-6a053f9680e4");//Капитальный ремонт
		public static readonly Guid Переоценка = new Guid("3d8fa3aa-86a7-401d-4f56-afed40670a3b");
		public static readonly Guid Реконструкция = new Guid("a84c5a9c-9a66-440a-405a-fe61c6ab6eb1");
		public static readonly Guid Достройка = new Guid("8d4856ab-aa5e-f22b-48d3-8f059e570485");
		public static readonly Guid Дооборудование = new Guid("c0e975b3-ba64-3c87-409b-ccfd0c7c8ed9");
		public static readonly Guid ЧастичнаяЛиквидация = new Guid("49191e98-2bdb-1596-49bd-b97eeb4a7d59");//Частичная ликвидация
		public static readonly Guid Модернизация = new Guid("9a065593-b403-b5a6-4ab1-1e2d893fe02e");
		public static readonly Guid ПодготовкаКПередаче = new Guid("b48cc298-41eb-86a2-4cf1-f2a710cd30c6");//Подготовка к передаче
		public static readonly Guid Передача = new Guid("d52963a1-a684-77d0-4f17-80d2eb825288");
		///<summary>
		///Списание
		///</summary>
		public static readonly Guid Списание = new Guid("e54077ab-142e-036c-4fe3-78ac14b7f1bd");
		///<summary>
		///Прочее
		///</summary>
		public static readonly Guid Прочее = new Guid("c577e1a8-4d79-da89-4832-e264ca616cc6");
		public static ВидыСобытийОС Получить(this ВидыСобытийОС Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыСобытийОС Получить(this ВидыСобытийОС Значение, Guid Ссылка)
		{
			if(Ссылка == ПринятиеКУчету)
			{
				return ВидыСобытийОС.ПринятиеКУчету;
			}
			else if(Ссылка == ВводВЭксплуатацию)
			{
				return ВидыСобытийОС.ВводВЭксплуатацию;
			}
			else if(Ссылка == ВнутреннееПеремещение)
			{
				return ВидыСобытийОС.ВнутреннееПеремещение;
			}
			else if(Ссылка == ТекущийРемонт)
			{
				return ВидыСобытийОС.ТекущийРемонт;
			}
			else if(Ссылка == СреднийРемонт)
			{
				return ВидыСобытийОС.СреднийРемонт;
			}
			else if(Ссылка == КапитальныйРемонт)
			{
				return ВидыСобытийОС.КапитальныйРемонт;
			}
			else if(Ссылка == Переоценка)
			{
				return ВидыСобытийОС.Переоценка;
			}
			else if(Ссылка == Реконструкция)
			{
				return ВидыСобытийОС.Реконструкция;
			}
			else if(Ссылка == Достройка)
			{
				return ВидыСобытийОС.Достройка;
			}
			else if(Ссылка == Дооборудование)
			{
				return ВидыСобытийОС.Дооборудование;
			}
			else if(Ссылка == ЧастичнаяЛиквидация)
			{
				return ВидыСобытийОС.ЧастичнаяЛиквидация;
			}
			else if(Ссылка == Модернизация)
			{
				return ВидыСобытийОС.Модернизация;
			}
			else if(Ссылка == ПодготовкаКПередаче)
			{
				return ВидыСобытийОС.ПодготовкаКПередаче;
			}
			else if(Ссылка == Передача)
			{
				return ВидыСобытийОС.Передача;
			}
			else if(Ссылка == Списание)
			{
				return ВидыСобытийОС.Списание;
			}
			else if(Ссылка == Прочее)
			{
				return ВидыСобытийОС.Прочее;
			}
			return ВидыСобытийОС.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыСобытийОС Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыСобытийОС Значение)
		{
			switch (Значение)
			{
				case ВидыСобытийОС.ПринятиеКУчету: return ПринятиеКУчету;
				case ВидыСобытийОС.ВводВЭксплуатацию: return ВводВЭксплуатацию;
				case ВидыСобытийОС.ВнутреннееПеремещение: return ВнутреннееПеремещение;
				case ВидыСобытийОС.ТекущийРемонт: return ТекущийРемонт;
				case ВидыСобытийОС.СреднийРемонт: return СреднийРемонт;
				case ВидыСобытийОС.КапитальныйРемонт: return КапитальныйРемонт;
				case ВидыСобытийОС.Переоценка: return Переоценка;
				case ВидыСобытийОС.Реконструкция: return Реконструкция;
				case ВидыСобытийОС.Достройка: return Достройка;
				case ВидыСобытийОС.Дооборудование: return Дооборудование;
				case ВидыСобытийОС.ЧастичнаяЛиквидация: return ЧастичнаяЛиквидация;
				case ВидыСобытийОС.Модернизация: return Модернизация;
				case ВидыСобытийОС.ПодготовкаКПередаче: return ПодготовкаКПередаче;
				case ВидыСобытийОС.Передача: return Передача;
				case ВидыСобытийОС.Списание: return Списание;
				case ВидыСобытийОС.Прочее: return Прочее;
			}
			return Guid.Empty;
		}
	}
}