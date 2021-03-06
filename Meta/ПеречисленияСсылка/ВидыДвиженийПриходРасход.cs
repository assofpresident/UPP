﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ВидыДвиженийПриходРасход
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"2333413b-da50-41e1-a4a6-419b9191deb3\", \"Представление\":\"Приход\"}")]
		Приход = 0,
		[EnumMember(Value = "{\"Ссылка\":\"0a651848-e33f-42e1-9993-98a4094f534d\", \"Представление\":\"Расход\"}")]
		Расход = 1,
	}
	public static partial class ВидыДвиженийПриходРасход_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Приход = new Guid("9b41a6a4-9191-b3de-41e1-da502333413b");
		public static readonly Guid Расход = new Guid("a4989399-4f09-4d53-42e1-e33f0a651848");
		public static ВидыДвиженийПриходРасход Получить(this ВидыДвиженийПриходРасход Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыДвиженийПриходРасход Получить(this ВидыДвиженийПриходРасход Значение, Guid Ссылка)
		{
			if(Ссылка == Приход)
			{
				return ВидыДвиженийПриходРасход.Приход;
			}
			else if(Ссылка == Расход)
			{
				return ВидыДвиженийПриходРасход.Расход;
			}
			return ВидыДвиженийПриходРасход.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыДвиженийПриходРасход Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыДвиженийПриходРасход Значение)
		{
			switch (Значение)
			{
				case ВидыДвиженийПриходРасход.Приход: return Приход;
				case ВидыДвиженийПриходРасход.Расход: return Расход;
			}
			return Guid.Empty;
		}
	}
}