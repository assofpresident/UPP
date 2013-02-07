
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыСтажаСЗВ4
	{
		ПустаяСсылка = - 1,
		ВключаетсяВСтажДляДосрочногоНазначенияПенсии = 0,//Включается в стаж для досрочного назначения пенсии
		ВключаетсяВСтраховойСтаж = 1,//Включается в страховой стаж
		ВременнаяНетрудоспособность = 2,//Временная нетрудоспособность
		ЧАЭС = 3,//Доп. отпуск, пострадавших в аварии на Чернобыльской АЭС
		ОтпускБезСохраненияЗарплаты = 4,//Отпуск без сохранения зарплаты
		НЕОПЛ = 5,//Неоплачиваемый период
		Дети = 6,
		Декрет = 7,
		ДЛДЕТИ = 8,//Отпуск по уходу за ребенком (ДЛДЕТИ)
		НеВключаетсяВСтраховойСтаж = 9,//Не включается в страховой стаж
	}
	public static partial class ВидыСтажаСЗВ4_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ВключаетсяВСтажДляДосрочногоНазначенияПенсии = new Guid("e4c7f6a2-721c-2fa7-4d9e-a72e40bd639e");//Включается в стаж для досрочного назначения пенсии
		public static readonly Guid ВключаетсяВСтраховойСтаж = new Guid("024e40bb-f1e7-d8c4-401c-870a1c8719fd");//Включается в страховой стаж
		public static readonly Guid ВременнаяНетрудоспособность = new Guid("083d3093-4efc-c821-4aac-ee14703655d1");//Временная нетрудоспособность
		public static readonly Guid ЧАЭС = new Guid("201cffa4-7975-e974-44b7-2326c470b387");//Доп. отпуск, пострадавших в аварии на Чернобыльской АЭС
		public static readonly Guid ОтпускБезСохраненияЗарплаты = new Guid("395d8194-7453-8377-4c3c-5861b3a3e3a6");//Отпуск без сохранения зарплаты
		public static readonly Guid НЕОПЛ = new Guid("49f595b7-ea79-75ee-4cd0-95759dffe1e2");//Неоплачиваемый период
		public static readonly Guid Дети = new Guid("fd112abb-00d9-efa4-4efc-7e46f3a14d7c");
		public static readonly Guid Декрет = new Guid("0b03ab81-9ea4-0c88-4001-3b5ef68eb6ed");
		public static readonly Guid ДЛДЕТИ = new Guid("2ed8f8b2-0217-2281-496e-336bf0c41354");//Отпуск по уходу за ребенком (ДЛДЕТИ)
		public static readonly Guid НеВключаетсяВСтраховойСтаж = new Guid("0fb00382-50c7-f284-4000-0e7d750ccd33");//Не включается в страховой стаж
		public static ВидыСтажаСЗВ4 Получить(this ВидыСтажаСЗВ4 Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыСтажаСЗВ4 Получить(this ВидыСтажаСЗВ4 Значение, Guid Ссылка)
		{
			if(Ссылка == ВключаетсяВСтажДляДосрочногоНазначенияПенсии)
			{
				return ВидыСтажаСЗВ4.ВключаетсяВСтажДляДосрочногоНазначенияПенсии;
			}
			else if(Ссылка == ВключаетсяВСтраховойСтаж)
			{
				return ВидыСтажаСЗВ4.ВключаетсяВСтраховойСтаж;
			}
			else if(Ссылка == ВременнаяНетрудоспособность)
			{
				return ВидыСтажаСЗВ4.ВременнаяНетрудоспособность;
			}
			else if(Ссылка == ЧАЭС)
			{
				return ВидыСтажаСЗВ4.ЧАЭС;
			}
			else if(Ссылка == ОтпускБезСохраненияЗарплаты)
			{
				return ВидыСтажаСЗВ4.ОтпускБезСохраненияЗарплаты;
			}
			else if(Ссылка == НЕОПЛ)
			{
				return ВидыСтажаСЗВ4.НЕОПЛ;
			}
			else if(Ссылка == Дети)
			{
				return ВидыСтажаСЗВ4.Дети;
			}
			else if(Ссылка == Декрет)
			{
				return ВидыСтажаСЗВ4.Декрет;
			}
			else if(Ссылка == ДЛДЕТИ)
			{
				return ВидыСтажаСЗВ4.ДЛДЕТИ;
			}
			else if(Ссылка == НеВключаетсяВСтраховойСтаж)
			{
				return ВидыСтажаСЗВ4.НеВключаетсяВСтраховойСтаж;
			}
			return ВидыСтажаСЗВ4.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыСтажаСЗВ4 Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыСтажаСЗВ4 Значение)
		{
			switch (Значение)
			{
				case ВидыСтажаСЗВ4.ВключаетсяВСтажДляДосрочногоНазначенияПенсии: return ВключаетсяВСтажДляДосрочногоНазначенияПенсии;
				case ВидыСтажаСЗВ4.ВключаетсяВСтраховойСтаж: return ВключаетсяВСтраховойСтаж;
				case ВидыСтажаСЗВ4.ВременнаяНетрудоспособность: return ВременнаяНетрудоспособность;
				case ВидыСтажаСЗВ4.ЧАЭС: return ЧАЭС;
				case ВидыСтажаСЗВ4.ОтпускБезСохраненияЗарплаты: return ОтпускБезСохраненияЗарплаты;
				case ВидыСтажаСЗВ4.НЕОПЛ: return НЕОПЛ;
				case ВидыСтажаСЗВ4.Дети: return Дети;
				case ВидыСтажаСЗВ4.Декрет: return Декрет;
				case ВидыСтажаСЗВ4.ДЛДЕТИ: return ДЛДЕТИ;
				case ВидыСтажаСЗВ4.НеВключаетсяВСтраховойСтаж: return НеВключаетсяВСтраховойСтаж;
			}
			return Guid.Empty;
		}
	}
}