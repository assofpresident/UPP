
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum СпособыРасчетаСебестоимостиПродукции
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		ПоПеределам = 0,//По переделам
	///<summary>
	///(Общ)
	///</summary>
		ПоПодразделениям = 1,//По подразделениям
	}
	public static partial class СпособыРасчетаСебестоимостиПродукции_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПоПеределам = new Guid("8aac9d8d-1083-c054-4c19-65b44e6052bb");//По переделам
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПоПодразделениям = new Guid("1d9516bb-f0d8-700d-46fb-7985b7c057c6");//По подразделениям
		public static СпособыРасчетаСебестоимостиПродукции Получить(this СпособыРасчетаСебестоимостиПродукции Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыРасчетаСебестоимостиПродукции Получить(this СпособыРасчетаСебестоимостиПродукции Значение, Guid Ссылка)
		{
			if(Ссылка == ПоПеределам)
			{
				return СпособыРасчетаСебестоимостиПродукции.ПоПеределам;
			}
			else if(Ссылка == ПоПодразделениям)
			{
				return СпособыРасчетаСебестоимостиПродукции.ПоПодразделениям;
			}
			return СпособыРасчетаСебестоимостиПродукции.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыРасчетаСебестоимостиПродукции Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыРасчетаСебестоимостиПродукции Значение)
		{
			switch (Значение)
			{
				case СпособыРасчетаСебестоимостиПродукции.ПоПеределам: return ПоПеределам;
				case СпособыРасчетаСебестоимостиПродукции.ПоПодразделениям: return ПоПодразделениям;
			}
			return Guid.Empty;
		}
	}
}