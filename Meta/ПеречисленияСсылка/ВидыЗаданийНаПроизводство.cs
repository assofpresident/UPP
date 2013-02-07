
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыЗаданийНаПроизводство
	{
		ПустаяСсылка = - 1,
		НаВыпуск = 0,//На выпуск
		НаТехПроцесс = 1,//На тех. процесс
	}
	public static partial class ВидыЗаданийНаПроизводство_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НаВыпуск = new Guid("1ae4b1a9-58e2-12c2-460a-5b2ba2050e6d");//На выпуск
		public static readonly Guid НаТехПроцесс = new Guid("8b66e085-7b4a-1288-48d5-92dc49cfdda4");//На тех. процесс
		public static ВидыЗаданийНаПроизводство Получить(this ВидыЗаданийНаПроизводство Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыЗаданийНаПроизводство Получить(this ВидыЗаданийНаПроизводство Значение, Guid Ссылка)
		{
			if(Ссылка == НаВыпуск)
			{
				return ВидыЗаданийНаПроизводство.НаВыпуск;
			}
			else if(Ссылка == НаТехПроцесс)
			{
				return ВидыЗаданийНаПроизводство.НаТехПроцесс;
			}
			return ВидыЗаданийНаПроизводство.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыЗаданийНаПроизводство Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыЗаданийНаПроизводство Значение)
		{
			switch (Значение)
			{
				case ВидыЗаданийНаПроизводство.НаВыпуск: return НаВыпуск;
				case ВидыЗаданийНаПроизводство.НаТехПроцесс: return НаТехПроцесс;
			}
			return Guid.Empty;
		}
	}
}