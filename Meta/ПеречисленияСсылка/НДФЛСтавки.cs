
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Регл)
		///</summary>
	public enum НДФЛСтавки
	{
		ПустаяСсылка = - 1,
		Ставка13 = 0,//13%
		Ставка30 = 1,//30%
		Ставка09 = 2,//9%
		Ставка35 = 3,//35%
		Ставка15 = 4,//15%
	}
	public static partial class НДФЛСтавки_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Ставка13 = new Guid("6e5577bb-0435-4843-49d1-ebbcfc3ba933");//13%
		public static readonly Guid Ставка30 = new Guid("b3d708ac-17e9-52d1-4942-a94c0037441b");//30%
		public static readonly Guid Ставка09 = new Guid("e2ff3da9-9c2a-48e2-4dc5-795f642697ea");//9%
		public static readonly Guid Ставка35 = new Guid("81aa5d81-ba8a-7037-410d-d4f78caef17d");//35%
		public static readonly Guid Ставка15 = new Guid("f74068a7-72a7-7c16-44f4-0eaf740a980b");//15%
		public static НДФЛСтавки Получить(this НДФЛСтавки Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static НДФЛСтавки Получить(this НДФЛСтавки Значение, Guid Ссылка)
		{
			if(Ссылка == Ставка13)
			{
				return НДФЛСтавки.Ставка13;
			}
			else if(Ссылка == Ставка30)
			{
				return НДФЛСтавки.Ставка30;
			}
			else if(Ссылка == Ставка09)
			{
				return НДФЛСтавки.Ставка09;
			}
			else if(Ссылка == Ставка35)
			{
				return НДФЛСтавки.Ставка35;
			}
			else if(Ссылка == Ставка15)
			{
				return НДФЛСтавки.Ставка15;
			}
			return НДФЛСтавки.ПустаяСсылка;
		}
		public static byte[] Ключ(this НДФЛСтавки Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this НДФЛСтавки Значение)
		{
			switch (Значение)
			{
				case НДФЛСтавки.Ставка13: return Ставка13;
				case НДФЛСтавки.Ставка30: return Ставка30;
				case НДФЛСтавки.Ставка09: return Ставка09;
				case НДФЛСтавки.Ставка35: return Ставка35;
				case НДФЛСтавки.Ставка15: return Ставка15;
			}
			return Guid.Empty;
		}
	}
}