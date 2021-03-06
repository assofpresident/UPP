﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Общ)
	///</summary>
	[DataContract]
	public enum ВидыПоказателейБазыРаспределения
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"5557cace-f629-4720-b9d4-c44a9f4778d1\", \"Представление\":\"НатуральныеЕдиницыИзмерения\"}")]
		НатуральныеЕдиницыИзмерения = 0,//Натуральные ед. изм.
		[EnumMember(Value = "{\"Ссылка\":\"2decbe9b-1a6d-48c3-a43e-e9ce458d8d0a\", \"Представление\":\"ЦеныНоменклатуры\"}")]
		ЦеныНоменклатуры = 1,//Цены номенклатуры
		[EnumMember(Value = "{\"Ссылка\":\"a54fd063-b541-46ed-9ec0-ff1caaba280a\", \"Представление\":\"ФактическаяЦенаРеализации\"}")]
		ФактическаяЦенаРеализации = 2,//Фактическая цена реализации
	}
	public static partial class ВидыПоказателейБазыРаспределения_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НатуральныеЕдиницыИзмерения = new Guid("4ac4d4b9-479f-d178-4720-f6295557cace");//Натуральные ед. изм.
		public static readonly Guid ЦеныНоменклатуры = new Guid("cee93ea4-8d45-0a8d-48c3-1a6d2decbe9b");//Цены номенклатуры
		public static readonly Guid ФактическаяЦенаРеализации = new Guid("1cffc09e-baaa-0a28-46ed-b541a54fd063");//Фактическая цена реализации
		public static ВидыПоказателейБазыРаспределения Получить(this ВидыПоказателейБазыРаспределения Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыПоказателейБазыРаспределения Получить(this ВидыПоказателейБазыРаспределения Значение, Guid Ссылка)
		{
			if(Ссылка == НатуральныеЕдиницыИзмерения)
			{
				return ВидыПоказателейБазыРаспределения.НатуральныеЕдиницыИзмерения;
			}
			else if(Ссылка == ЦеныНоменклатуры)
			{
				return ВидыПоказателейБазыРаспределения.ЦеныНоменклатуры;
			}
			else if(Ссылка == ФактическаяЦенаРеализации)
			{
				return ВидыПоказателейБазыРаспределения.ФактическаяЦенаРеализации;
			}
			return ВидыПоказателейБазыРаспределения.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыПоказателейБазыРаспределения Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыПоказателейБазыРаспределения Значение)
		{
			switch (Значение)
			{
				case ВидыПоказателейБазыРаспределения.НатуральныеЕдиницыИзмерения: return НатуральныеЕдиницыИзмерения;
				case ВидыПоказателейБазыРаспределения.ЦеныНоменклатуры: return ЦеныНоменклатуры;
				case ВидыПоказателейБазыРаспределения.ФактическаяЦенаРеализации: return ФактическаяЦенаРеализации;
			}
			return Guid.Empty;
		}
	}
}