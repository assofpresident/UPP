﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Упр)
	///</summary>
	[DataContract]
	public enum ВидыОперацийУстановкаСкидокНоменклатуры
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"958432fd-45b7-4955-83ed-9e6d74232073\", \"Представление\":\"ПоНоменклатуре\"}")]
		ПоНоменклатуре = 0,//по номенклатуре
		[EnumMember(Value = "{\"Ссылка\":\"d8470b92-9a95-4b3a-b37a-abfb4ad9ffe7\", \"Представление\":\"ПоЦеновымГруппам\"}")]
		ПоЦеновымГруппам = 1,//по ценовым группам
		[EnumMember(Value = "{\"Ссылка\":\"37738fed-f217-484a-a925-39ab4ccbeb10\", \"Представление\":\"НатуральныеСкидки\"}")]
		НатуральныеСкидки = 2,//натуральные скидки
	}
	public static partial class ВидыОперацийУстановкаСкидокНоменклатуры_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоНоменклатуре = new Guid("6d9eed83-2374-7320-4955-45b7958432fd");//по номенклатуре
		public static readonly Guid ПоЦеновымГруппам = new Guid("fbab7ab3-d94a-e7ff-4b3a-9a95d8470b92");//по ценовым группам
		public static readonly Guid НатуральныеСкидки = new Guid("ab3925a9-cb4c-10eb-484a-f21737738fed");//натуральные скидки
		public static ВидыОперацийУстановкаСкидокНоменклатуры Получить(this ВидыОперацийУстановкаСкидокНоменклатуры Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийУстановкаСкидокНоменклатуры Получить(this ВидыОперацийУстановкаСкидокНоменклатуры Значение, Guid Ссылка)
		{
			if(Ссылка == ПоНоменклатуре)
			{
				return ВидыОперацийУстановкаСкидокНоменклатуры.ПоНоменклатуре;
			}
			else if(Ссылка == ПоЦеновымГруппам)
			{
				return ВидыОперацийУстановкаСкидокНоменклатуры.ПоЦеновымГруппам;
			}
			else if(Ссылка == НатуральныеСкидки)
			{
				return ВидыОперацийУстановкаСкидокНоменклатуры.НатуральныеСкидки;
			}
			return ВидыОперацийУстановкаСкидокНоменклатуры.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийУстановкаСкидокНоменклатуры Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийУстановкаСкидокНоменклатуры Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийУстановкаСкидокНоменклатуры.ПоНоменклатуре: return ПоНоменклатуре;
				case ВидыОперацийУстановкаСкидокНоменклатуры.ПоЦеновымГруппам: return ПоЦеновымГруппам;
				case ВидыОперацийУстановкаСкидокНоменклатуры.НатуральныеСкидки: return НатуральныеСкидки;
			}
			return Guid.Empty;
		}
	}
}