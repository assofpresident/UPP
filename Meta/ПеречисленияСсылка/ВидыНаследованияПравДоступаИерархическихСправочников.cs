
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыНаследованияПравДоступаИерархическихСправочников
	{
		ПустаяСсылка = - 1,
		НаследуетсяОтРодителя = 0,//Наследуется от родителя
		РаспространитьНаПодчиненных = 1,//Распространить на подчиненных
		ТолькоДляТекущегоПрава = 2,//Только для текущего права
		УнаследованоОтДочернего = 3,//Унаследовано от дочернего
	}
	public static partial class ВидыНаследованияПравДоступаИерархическихСправочников_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НаследуетсяОтРодителя = new Guid("480cbd81-110b-6da5-474d-1ca56aad266f");//Наследуется от родителя
		public static readonly Guid РаспространитьНаПодчиненных = new Guid("7d101da8-d52c-4627-4b0b-52dd00fd3053");//Распространить на подчиненных
		public static readonly Guid ТолькоДляТекущегоПрава = new Guid("f14b959a-bd7d-cbb8-4efc-891a7cfa0a17");//Только для текущего права
		public static readonly Guid УнаследованоОтДочернего = new Guid("56653699-77b3-97d4-4a45-5665a10e3b42");//Унаследовано от дочернего
		public static ВидыНаследованияПравДоступаИерархическихСправочников Получить(this ВидыНаследованияПравДоступаИерархическихСправочников Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыНаследованияПравДоступаИерархическихСправочников Получить(this ВидыНаследованияПравДоступаИерархическихСправочников Значение, Guid Ссылка)
		{
			if(Ссылка == НаследуетсяОтРодителя)
			{
				return ВидыНаследованияПравДоступаИерархическихСправочников.НаследуетсяОтРодителя;
			}
			else if(Ссылка == РаспространитьНаПодчиненных)
			{
				return ВидыНаследованияПравДоступаИерархическихСправочников.РаспространитьНаПодчиненных;
			}
			else if(Ссылка == ТолькоДляТекущегоПрава)
			{
				return ВидыНаследованияПравДоступаИерархическихСправочников.ТолькоДляТекущегоПрава;
			}
			else if(Ссылка == УнаследованоОтДочернего)
			{
				return ВидыНаследованияПравДоступаИерархическихСправочников.УнаследованоОтДочернего;
			}
			return ВидыНаследованияПравДоступаИерархическихСправочников.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыНаследованияПравДоступаИерархическихСправочников Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыНаследованияПравДоступаИерархическихСправочников Значение)
		{
			switch (Значение)
			{
				case ВидыНаследованияПравДоступаИерархическихСправочников.НаследуетсяОтРодителя: return НаследуетсяОтРодителя;
				case ВидыНаследованияПравДоступаИерархическихСправочников.РаспространитьНаПодчиненных: return РаспространитьНаПодчиненных;
				case ВидыНаследованияПравДоступаИерархическихСправочников.ТолькоДляТекущегоПрава: return ТолькоДляТекущегоПрава;
				case ВидыНаследованияПравДоступаИерархическихСправочников.УнаследованоОтДочернего: return УнаследованоОтДочернего;
			}
			return Guid.Empty;
		}
	}
}