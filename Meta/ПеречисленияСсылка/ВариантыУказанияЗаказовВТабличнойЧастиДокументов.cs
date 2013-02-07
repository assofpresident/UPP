
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ.)
		///</summary>
	public enum ВариантыУказанияЗаказовВТабличнойЧастиДокументов
	{
		ПустаяСсылка = - 1,
		НеИспользовать = 0,//Не указывать
		ДляДокументовПоступления = 1,//Для документов поступления
		ДляДокументовРеализации = 2,//Для документов реализации
		ДляДокументовПоступленияРеализации = 3,//Для документов поступления и реализации
	}
	public static partial class ВариантыУказанияЗаказовВТабличнойЧастиДокументов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НеИспользовать = new Guid("5d9903b4-603b-9e24-4a96-da01285ea915");//Не указывать
		public static readonly Guid ДляДокументовПоступления = new Guid("20dea5b6-7f6b-65db-459b-cd78df5bc05d");//Для документов поступления
		public static readonly Guid ДляДокументовРеализации = new Guid("20b3f0b7-26b3-d482-46e3-0c59eda5acfe");//Для документов реализации
		public static readonly Guid ДляДокументовПоступленияРеализации = new Guid("94ced8a5-980c-94d3-4747-e396adfa7594");//Для документов поступления и реализации
		public static ВариантыУказанияЗаказовВТабличнойЧастиДокументов Получить(this ВариантыУказанияЗаказовВТабличнойЧастиДокументов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВариантыУказанияЗаказовВТабличнойЧастиДокументов Получить(this ВариантыУказанияЗаказовВТабличнойЧастиДокументов Значение, Guid Ссылка)
		{
			if(Ссылка == НеИспользовать)
			{
				return ВариантыУказанияЗаказовВТабличнойЧастиДокументов.НеИспользовать;
			}
			else if(Ссылка == ДляДокументовПоступления)
			{
				return ВариантыУказанияЗаказовВТабличнойЧастиДокументов.ДляДокументовПоступления;
			}
			else if(Ссылка == ДляДокументовРеализации)
			{
				return ВариантыУказанияЗаказовВТабличнойЧастиДокументов.ДляДокументовРеализации;
			}
			else if(Ссылка == ДляДокументовПоступленияРеализации)
			{
				return ВариантыУказанияЗаказовВТабличнойЧастиДокументов.ДляДокументовПоступленияРеализации;
			}
			return ВариантыУказанияЗаказовВТабличнойЧастиДокументов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВариантыУказанияЗаказовВТабличнойЧастиДокументов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВариантыУказанияЗаказовВТабличнойЧастиДокументов Значение)
		{
			switch (Значение)
			{
				case ВариантыУказанияЗаказовВТабличнойЧастиДокументов.НеИспользовать: return НеИспользовать;
				case ВариантыУказанияЗаказовВТабличнойЧастиДокументов.ДляДокументовПоступления: return ДляДокументовПоступления;
				case ВариантыУказанияЗаказовВТабличнойЧастиДокументов.ДляДокументовРеализации: return ДляДокументовРеализации;
				case ВариантыУказанияЗаказовВТабличнойЧастиДокументов.ДляДокументовПоступленияРеализации: return ДляДокументовПоступленияРеализации;
			}
			return Guid.Empty;
		}
	}
}