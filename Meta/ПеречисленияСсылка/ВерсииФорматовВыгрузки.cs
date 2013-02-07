
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВерсииФорматовВыгрузки
	{
		ПустаяСсылка = - 1,
		Версия200 = 0,//Версия 2.00
		Версия201 = 1,//Версия 2.01
		Версия300 = 2,//Версия 3.00
		Версия201алко = 3,//Версия 2.01 для деклараций по алкоголю
		Версия300алко = 4,//Версия 3.00 для деклараций по алкоголю
		Версия301алко = 5,//Версия 3.01 для деклараций по алкоголю
		Версия400 = 6,//Версия 4.00
		Версия500 = 7,//Версия 5.00
		Версия302алко = 8,//Версия 3.02 для деклараций по алкоголю
		Версия700ПФР = 9,//Версия 7.00 ПФР
		ВерсияФСС = 10,//Версия ФСС
		Версия401алко = 11,//Версия 4.01 для деклараций по алкоголю
	///<summary>
	///Для статотчетности
	///</summary>
		ВерсияФСГС = 12,//Версия ФСГС
	}
	public static partial class ВерсииФорматовВыгрузки_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Версия200 = new Guid("0623d8bf-b538-dbdf-4609-b3cdb7f3eb9c");//Версия 2.00
		public static readonly Guid Версия201 = new Guid("1dfadba0-a11d-f978-495d-140232e7c757");//Версия 2.01
		public static readonly Guid Версия300 = new Guid("8c7c99ae-ba75-0672-4395-ab8ae2ab021a");//Версия 3.00
		public static readonly Guid Версия201алко = new Guid("8ee498b6-62c8-1900-4852-f03a63a61c39");//Версия 2.01 для деклараций по алкоголю
		public static readonly Guid Версия300алко = new Guid("4f98a487-51d1-de9f-4427-a9b66e110bdf");//Версия 3.00 для деклараций по алкоголю
		public static readonly Guid Версия301алко = new Guid("401d48aa-94b0-1a28-40a9-c8f58a017bac");//Версия 3.01 для деклараций по алкоголю
		public static readonly Guid Версия400 = new Guid("0f995c8a-332c-a742-4614-9d7885c99c2e");//Версия 4.00
		public static readonly Guid Версия500 = new Guid("0a6f00b7-99c9-d639-4495-ab0c85f2911e");//Версия 5.00
		public static readonly Guid Версия302алко = new Guid("ba4814b4-6a7b-589c-4d46-6717b8fee401");//Версия 3.02 для деклараций по алкоголю
		public static readonly Guid Версия700ПФР = new Guid("39f85bbd-f5f6-cfc1-4dcb-d13e05e1abb5");//Версия 7.00 ПФР
		public static readonly Guid ВерсияФСС = new Guid("e5027c88-13e8-fcfa-45c9-6559eceafe2e");//Версия ФСС
		public static readonly Guid Версия401алко = new Guid("a37d688a-aa84-b23e-4d96-e8bf7be724b0");//Версия 4.01 для деклараций по алкоголю
		///<summary>
		///Для статотчетности
		///</summary>
		public static readonly Guid ВерсияФСГС = new Guid("17c6ac87-0fef-9204-42b8-967fc6fa63e9");//Версия ФСГС
		public static ВерсииФорматовВыгрузки Получить(this ВерсииФорматовВыгрузки Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВерсииФорматовВыгрузки Получить(this ВерсииФорматовВыгрузки Значение, Guid Ссылка)
		{
			if(Ссылка == Версия200)
			{
				return ВерсииФорматовВыгрузки.Версия200;
			}
			else if(Ссылка == Версия201)
			{
				return ВерсииФорматовВыгрузки.Версия201;
			}
			else if(Ссылка == Версия300)
			{
				return ВерсииФорматовВыгрузки.Версия300;
			}
			else if(Ссылка == Версия201алко)
			{
				return ВерсииФорматовВыгрузки.Версия201алко;
			}
			else if(Ссылка == Версия300алко)
			{
				return ВерсииФорматовВыгрузки.Версия300алко;
			}
			else if(Ссылка == Версия301алко)
			{
				return ВерсииФорматовВыгрузки.Версия301алко;
			}
			else if(Ссылка == Версия400)
			{
				return ВерсииФорматовВыгрузки.Версия400;
			}
			else if(Ссылка == Версия500)
			{
				return ВерсииФорматовВыгрузки.Версия500;
			}
			else if(Ссылка == Версия302алко)
			{
				return ВерсииФорматовВыгрузки.Версия302алко;
			}
			else if(Ссылка == Версия700ПФР)
			{
				return ВерсииФорматовВыгрузки.Версия700ПФР;
			}
			else if(Ссылка == ВерсияФСС)
			{
				return ВерсииФорматовВыгрузки.ВерсияФСС;
			}
			else if(Ссылка == Версия401алко)
			{
				return ВерсииФорматовВыгрузки.Версия401алко;
			}
			else if(Ссылка == ВерсияФСГС)
			{
				return ВерсииФорматовВыгрузки.ВерсияФСГС;
			}
			return ВерсииФорматовВыгрузки.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВерсииФорматовВыгрузки Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВерсииФорматовВыгрузки Значение)
		{
			switch (Значение)
			{
				case ВерсииФорматовВыгрузки.Версия200: return Версия200;
				case ВерсииФорматовВыгрузки.Версия201: return Версия201;
				case ВерсииФорматовВыгрузки.Версия300: return Версия300;
				case ВерсииФорматовВыгрузки.Версия201алко: return Версия201алко;
				case ВерсииФорматовВыгрузки.Версия300алко: return Версия300алко;
				case ВерсииФорматовВыгрузки.Версия301алко: return Версия301алко;
				case ВерсииФорматовВыгрузки.Версия400: return Версия400;
				case ВерсииФорматовВыгрузки.Версия500: return Версия500;
				case ВерсииФорматовВыгрузки.Версия302алко: return Версия302алко;
				case ВерсииФорматовВыгрузки.Версия700ПФР: return Версия700ПФР;
				case ВерсииФорматовВыгрузки.ВерсияФСС: return ВерсияФСС;
				case ВерсииФорматовВыгрузки.Версия401алко: return Версия401алко;
				case ВерсииФорматовВыгрузки.ВерсияФСГС: return ВерсияФСГС;
			}
			return Guid.Empty;
		}
	}
}