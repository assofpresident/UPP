
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Регл)
		///</summary>
	public enum ПорядокВключенияСтоимостиОСВСоставРасходовНУ
	{
		ПустаяСсылка = - 1,
		НачислениеАмортизации = 0,//Начисление амортизации
		ВключениеВРасходыПриПринятииКУчету = 1,//Включение в расходы при принятии к учету
		СтоимостьНеВключаетсяВРасходы = 2,//Стоимость не включается в расходы
	}
	public static partial class ПорядокВключенияСтоимостиОСВСоставРасходовНУ_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НачислениеАмортизации = new Guid("57371198-d5ad-c204-4d4e-d1b29ecfe83c");//Начисление амортизации
		public static readonly Guid ВключениеВРасходыПриПринятииКУчету = new Guid("ce52d48b-6c03-63fe-4d27-f91970fd01ec");//Включение в расходы при принятии к учету
		public static readonly Guid СтоимостьНеВключаетсяВРасходы = new Guid("33eaf0ad-7eeb-c14d-4cc8-563f609269fe");//Стоимость не включается в расходы
		public static ПорядокВключенияСтоимостиОСВСоставРасходовНУ Получить(this ПорядокВключенияСтоимостиОСВСоставРасходовНУ Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ПорядокВключенияСтоимостиОСВСоставРасходовНУ Получить(this ПорядокВключенияСтоимостиОСВСоставРасходовНУ Значение, Guid Ссылка)
		{
			if(Ссылка == НачислениеАмортизации)
			{
				return ПорядокВключенияСтоимостиОСВСоставРасходовНУ.НачислениеАмортизации;
			}
			else if(Ссылка == ВключениеВРасходыПриПринятииКУчету)
			{
				return ПорядокВключенияСтоимостиОСВСоставРасходовНУ.ВключениеВРасходыПриПринятииКУчету;
			}
			else if(Ссылка == СтоимостьНеВключаетсяВРасходы)
			{
				return ПорядокВключенияСтоимостиОСВСоставРасходовНУ.СтоимостьНеВключаетсяВРасходы;
			}
			return ПорядокВключенияСтоимостиОСВСоставРасходовНУ.ПустаяСсылка;
		}
		public static byte[] Ключ(this ПорядокВключенияСтоимостиОСВСоставРасходовНУ Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ПорядокВключенияСтоимостиОСВСоставРасходовНУ Значение)
		{
			switch (Значение)
			{
				case ПорядокВключенияСтоимостиОСВСоставРасходовНУ.НачислениеАмортизации: return НачислениеАмортизации;
				case ПорядокВключенияСтоимостиОСВСоставРасходовНУ.ВключениеВРасходыПриПринятииКУчету: return ВключениеВРасходыПриПринятииКУчету;
				case ПорядокВключенияСтоимостиОСВСоставРасходовНУ.СтоимостьНеВключаетсяВРасходы: return СтоимостьНеВключаетсяВРасходы;
			}
			return Guid.Empty;
		}
	}
}