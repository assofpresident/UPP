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
	public enum ВариантыВыпускаПродукции
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"0d09b5b6-5043-4ff2-b70d-9e6d8235af38\", \"Представление\":\"СобственнаяПродукция\"}")]
		СобственнаяПродукция = 0,//Собственная продукция
		[EnumMember(Value = "{\"Ссылка\":\"ed603b29-de95-4cec-a1dd-31b14a89a782\", \"Представление\":\"ПродукцияИзДавальческогоСырья\"}")]
		ПродукцияИзДавальческогоСырья = 1,//Продукция из давальческого сырья
		[EnumMember(Value = "{\"Ссылка\":\"8d074aa5-9fc1-41c2-926c-85be43510fc8\", \"Представление\":\"ПродукцияСтороннегоПереработчика\"}")]
		ПродукцияСтороннегоПереработчика = 2,//Продукция стороннего переработчика
	}
	public static partial class ВариантыВыпускаПродукции_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid СобственнаяПродукция = new Guid("6d9e0db7-3582-38af-4ff2-50430d09b5b6");//Собственная продукция
		public static readonly Guid ПродукцияИзДавальческогоСырья = new Guid("b131dda1-894a-82a7-4cec-de95ed603b29");//Продукция из давальческого сырья
		public static readonly Guid ПродукцияСтороннегоПереработчика = new Guid("be856c92-5143-c80f-41c2-9fc18d074aa5");//Продукция стороннего переработчика
		public static ВариантыВыпускаПродукции Получить(this ВариантыВыпускаПродукции Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВариантыВыпускаПродукции Получить(this ВариантыВыпускаПродукции Значение, Guid Ссылка)
		{
			if(Ссылка == СобственнаяПродукция)
			{
				return ВариантыВыпускаПродукции.СобственнаяПродукция;
			}
			else if(Ссылка == ПродукцияИзДавальческогоСырья)
			{
				return ВариантыВыпускаПродукции.ПродукцияИзДавальческогоСырья;
			}
			else if(Ссылка == ПродукцияСтороннегоПереработчика)
			{
				return ВариантыВыпускаПродукции.ПродукцияСтороннегоПереработчика;
			}
			return ВариантыВыпускаПродукции.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВариантыВыпускаПродукции Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВариантыВыпускаПродукции Значение)
		{
			switch (Значение)
			{
				case ВариантыВыпускаПродукции.СобственнаяПродукция: return СобственнаяПродукция;
				case ВариантыВыпускаПродукции.ПродукцияИзДавальческогоСырья: return ПродукцияИзДавальческогоСырья;
				case ВариантыВыпускаПродукции.ПродукцияСтороннегоПереработчика: return ПродукцияСтороннегоПереработчика;
			}
			return Guid.Empty;
		}
	}
}