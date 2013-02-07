
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ.)
		///</summary>
	public enum ВариантыУказанияСкладовВТабличнойЧастиДокументов
	{
		ПустаяСсылка = - 1,
		НеИспользовать = 0,//Не указывать
		ДляДокументовПоступления = 1,//Для документов поступления
		ДляДокументовРеализации = 2,//Для документов реализации
		ДляДокументовПоступленияРеализации = 3,//Для документов поступления и реализации
	}
	public static partial class ВариантыУказанияСкладовВТабличнойЧастиДокументов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НеИспользовать = new Guid("28b6dcb7-b8d6-19e1-4ee1-6334e762690c");//Не указывать
		public static readonly Guid ДляДокументовПоступления = new Guid("593c0888-b472-ce60-4daf-0b9dbe1efeed");//Для документов поступления
		public static readonly Guid ДляДокументовРеализации = new Guid("1dd21187-bb61-10a9-4e30-2eff5d16dfc6");//Для документов реализации
		public static readonly Guid ДляДокументовПоступленияРеализации = new Guid("4622f088-a8eb-3789-40de-27e32d029126");//Для документов поступления и реализации
		public static ВариантыУказанияСкладовВТабличнойЧастиДокументов Получить(this ВариантыУказанияСкладовВТабличнойЧастиДокументов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВариантыУказанияСкладовВТабличнойЧастиДокументов Получить(this ВариантыУказанияСкладовВТабличнойЧастиДокументов Значение, Guid Ссылка)
		{
			if(Ссылка == НеИспользовать)
			{
				return ВариантыУказанияСкладовВТабличнойЧастиДокументов.НеИспользовать;
			}
			else if(Ссылка == ДляДокументовПоступления)
			{
				return ВариантыУказанияСкладовВТабличнойЧастиДокументов.ДляДокументовПоступления;
			}
			else if(Ссылка == ДляДокументовРеализации)
			{
				return ВариантыУказанияСкладовВТабличнойЧастиДокументов.ДляДокументовРеализации;
			}
			else if(Ссылка == ДляДокументовПоступленияРеализации)
			{
				return ВариантыУказанияСкладовВТабличнойЧастиДокументов.ДляДокументовПоступленияРеализации;
			}
			return ВариантыУказанияСкладовВТабличнойЧастиДокументов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВариантыУказанияСкладовВТабличнойЧастиДокументов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВариантыУказанияСкладовВТабличнойЧастиДокументов Значение)
		{
			switch (Значение)
			{
				case ВариантыУказанияСкладовВТабличнойЧастиДокументов.НеИспользовать: return НеИспользовать;
				case ВариантыУказанияСкладовВТабличнойЧастиДокументов.ДляДокументовПоступления: return ДляДокументовПоступления;
				case ВариантыУказанияСкладовВТабличнойЧастиДокументов.ДляДокументовРеализации: return ДляДокументовРеализации;
				case ВариантыУказанияСкладовВТабличнойЧастиДокументов.ДляДокументовПоступленияРеализации: return ДляДокументовПоступленияРеализации;
			}
			return Guid.Empty;
		}
	}
}