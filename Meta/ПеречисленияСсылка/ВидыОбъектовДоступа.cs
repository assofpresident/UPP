
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыОбъектовДоступа
	{
		ПустаяСсылка = - 1,
		Контрагенты = 0,
		Организации = 1,
		ФизическиеЛица = 2,//Физические лица
		Проекты = 3,
		Склады = 4,
		ЗаявкиКандидатов = 5,//Кандидаты
		ВнешниеОбработки = 6,//Внешние обработки
		Заметки = 7,
		Подразделения = 8,
		ПодразделенияОрганизаций = 9,//Подразделения организаций
	///<summary>
	///Дополнительный вид объекта доступа
	///</summary>
		Номенклатура = 10,//Номенклатура (только изменение)
		Спецификации = 11,
		ЦеныНоменклатуры = 12,//Цены номенклатуры
	}
	public static partial class ВидыОбъектовДоступа_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Контрагенты = new Guid("588934ac-1c2a-6766-4d56-0056193029ae");
		public static readonly Guid Организации = new Guid("5e009d90-af4c-8d2e-472c-07d30d9d40af");
		public static readonly Guid ФизическиеЛица = new Guid("8e1d07a9-553e-93a0-4411-d266c08c7679");//Физические лица
		public static readonly Guid Проекты = new Guid("0de42c8e-c76a-a8de-4f05-d89fa20bdac9");
		public static readonly Guid Склады = new Guid("116064ac-e4a0-f866-4f24-da95b7fea119");
		public static readonly Guid ЗаявкиКандидатов = new Guid("5441959e-9d44-aca6-4d09-713613c9252b");//Кандидаты
		public static readonly Guid ВнешниеОбработки = new Guid("13985f81-0148-27d8-4d10-1ed63663c390");//Внешние обработки
		public static readonly Guid Заметки = new Guid("79b044a0-1a7b-fea3-4a99-2ec2d109ea1e");
		public static readonly Guid Подразделения = new Guid("70a5809e-b7b3-fb42-4477-0fc3b9c6accd");
		public static readonly Guid ПодразделенияОрганизаций = new Guid("e3ae958c-476d-bac4-4fdc-1eecab7afa8d");//Подразделения организаций
		///<summary>
		///Дополнительный вид объекта доступа
		///</summary>
		public static readonly Guid Номенклатура = new Guid("fb21d184-174d-ac83-4808-4e679e1cc1cc");//Номенклатура (только изменение)
		public static readonly Guid Спецификации = new Guid("b969318f-e291-840c-4058-f3330484cbd7");
		public static readonly Guid ЦеныНоменклатуры = new Guid("c8921491-d486-a494-44ef-e5f04dc6357a");//Цены номенклатуры
		public static ВидыОбъектовДоступа Получить(this ВидыОбъектовДоступа Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОбъектовДоступа Получить(this ВидыОбъектовДоступа Значение, Guid Ссылка)
		{
			if(Ссылка == Контрагенты)
			{
				return ВидыОбъектовДоступа.Контрагенты;
			}
			else if(Ссылка == Организации)
			{
				return ВидыОбъектовДоступа.Организации;
			}
			else if(Ссылка == ФизическиеЛица)
			{
				return ВидыОбъектовДоступа.ФизическиеЛица;
			}
			else if(Ссылка == Проекты)
			{
				return ВидыОбъектовДоступа.Проекты;
			}
			else if(Ссылка == Склады)
			{
				return ВидыОбъектовДоступа.Склады;
			}
			else if(Ссылка == ЗаявкиКандидатов)
			{
				return ВидыОбъектовДоступа.ЗаявкиКандидатов;
			}
			else if(Ссылка == ВнешниеОбработки)
			{
				return ВидыОбъектовДоступа.ВнешниеОбработки;
			}
			else if(Ссылка == Заметки)
			{
				return ВидыОбъектовДоступа.Заметки;
			}
			else if(Ссылка == Подразделения)
			{
				return ВидыОбъектовДоступа.Подразделения;
			}
			else if(Ссылка == ПодразделенияОрганизаций)
			{
				return ВидыОбъектовДоступа.ПодразделенияОрганизаций;
			}
			else if(Ссылка == Номенклатура)
			{
				return ВидыОбъектовДоступа.Номенклатура;
			}
			else if(Ссылка == Спецификации)
			{
				return ВидыОбъектовДоступа.Спецификации;
			}
			else if(Ссылка == ЦеныНоменклатуры)
			{
				return ВидыОбъектовДоступа.ЦеныНоменклатуры;
			}
			return ВидыОбъектовДоступа.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОбъектовДоступа Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОбъектовДоступа Значение)
		{
			switch (Значение)
			{
				case ВидыОбъектовДоступа.Контрагенты: return Контрагенты;
				case ВидыОбъектовДоступа.Организации: return Организации;
				case ВидыОбъектовДоступа.ФизическиеЛица: return ФизическиеЛица;
				case ВидыОбъектовДоступа.Проекты: return Проекты;
				case ВидыОбъектовДоступа.Склады: return Склады;
				case ВидыОбъектовДоступа.ЗаявкиКандидатов: return ЗаявкиКандидатов;
				case ВидыОбъектовДоступа.ВнешниеОбработки: return ВнешниеОбработки;
				case ВидыОбъектовДоступа.Заметки: return Заметки;
				case ВидыОбъектовДоступа.Подразделения: return Подразделения;
				case ВидыОбъектовДоступа.ПодразделенияОрганизаций: return ПодразделенияОрганизаций;
				case ВидыОбъектовДоступа.Номенклатура: return Номенклатура;
				case ВидыОбъектовДоступа.Спецификации: return Спецификации;
				case ВидыОбъектовДоступа.ЦеныНоменклатуры: return ЦеныНоменклатуры;
			}
			return Guid.Empty;
		}
	}
}