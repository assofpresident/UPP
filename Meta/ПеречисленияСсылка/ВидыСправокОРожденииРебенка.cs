
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыСправокОРожденииРебенка
	{
		ПустаяСсылка = - 1,
		ФормаНомер24 = 0,//форма № 24
		ФормаНомер25 = 1,//форма № 25
		ФормаНомер26 = 2,//форма № 26
	}
	public static partial class ВидыСправокОРожденииРебенка_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ФормаНомер24 = new Guid("565db8af-8d15-5454-4be7-df60be38aac3");//форма № 24
		public static readonly Guid ФормаНомер25 = new Guid("e4a6138f-8cc0-84e5-4ae1-25a724caa7f2");//форма № 25
		public static readonly Guid ФормаНомер26 = new Guid("6603d494-dc40-076b-418b-39bcd884eead");//форма № 26
		public static ВидыСправокОРожденииРебенка Получить(this ВидыСправокОРожденииРебенка Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыСправокОРожденииРебенка Получить(this ВидыСправокОРожденииРебенка Значение, Guid Ссылка)
		{
			if(Ссылка == ФормаНомер24)
			{
				return ВидыСправокОРожденииРебенка.ФормаНомер24;
			}
			else if(Ссылка == ФормаНомер25)
			{
				return ВидыСправокОРожденииРебенка.ФормаНомер25;
			}
			else if(Ссылка == ФормаНомер26)
			{
				return ВидыСправокОРожденииРебенка.ФормаНомер26;
			}
			return ВидыСправокОРожденииРебенка.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыСправокОРожденииРебенка Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыСправокОРожденииРебенка Значение)
		{
			switch (Значение)
			{
				case ВидыСправокОРожденииРебенка.ФормаНомер24: return ФормаНомер24;
				case ВидыСправокОРожденииРебенка.ФормаНомер25: return ФормаНомер25;
				case ВидыСправокОРожденииРебенка.ФормаНомер26: return ФормаНомер26;
			}
			return Guid.Empty;
		}
	}
}