
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыРасходовУСН
	{
		ПустаяСсылка = - 1,
		Номенклатура = 0,
		Услуги = 1,
		РБП = 2,
		ДопРасходы = 3,//Доп. расходы
		ОС = 4,
		НМА = 5,
		Зарплата = 6,
		Налоги = 7,//Налоги (взносы)
	///<summary>
	///НДС по приобретенным ценностям
	///</summary>
		НДС = 8,//НДС по приобретенным ценностям
	}
	public static partial class ВидыРасходовУСН_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Номенклатура = new Guid("86c94ab3-8f2e-3420-495f-59ff7162cf3e");
		public static readonly Guid Услуги = new Guid("50a44794-e8c4-b270-426f-857784855056");
		public static readonly Guid РБП = new Guid("f379708e-10fe-7c58-4f30-3a1a49bc1dc8");
		public static readonly Guid ДопРасходы = new Guid("2943ffab-6023-262a-4888-af92bd039973");//Доп. расходы
		public static readonly Guid ОС = new Guid("44c992b3-1a6a-e335-4049-f355f4ea3485");
		public static readonly Guid НМА = new Guid("31c107b9-3042-96d2-40c7-9d5c14eca1e3");
		public static readonly Guid Зарплата = new Guid("4e19bf84-1ade-a5f2-4b66-9b74322c70b2");
		public static readonly Guid Налоги = new Guid("5775849d-f812-fb1a-4b01-65b0adf993b0");//Налоги (взносы)
		///<summary>
		///НДС по приобретенным ценностям
		///</summary>
		public static readonly Guid НДС = new Guid("078034af-53f3-36ef-4cff-9a6024e0ed2d");//НДС по приобретенным ценностям
		public static ВидыРасходовУСН Получить(this ВидыРасходовУСН Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыРасходовУСН Получить(this ВидыРасходовУСН Значение, Guid Ссылка)
		{
			if(Ссылка == Номенклатура)
			{
				return ВидыРасходовУСН.Номенклатура;
			}
			else if(Ссылка == Услуги)
			{
				return ВидыРасходовУСН.Услуги;
			}
			else if(Ссылка == РБП)
			{
				return ВидыРасходовУСН.РБП;
			}
			else if(Ссылка == ДопРасходы)
			{
				return ВидыРасходовУСН.ДопРасходы;
			}
			else if(Ссылка == ОС)
			{
				return ВидыРасходовУСН.ОС;
			}
			else if(Ссылка == НМА)
			{
				return ВидыРасходовУСН.НМА;
			}
			else if(Ссылка == Зарплата)
			{
				return ВидыРасходовУСН.Зарплата;
			}
			else if(Ссылка == Налоги)
			{
				return ВидыРасходовУСН.Налоги;
			}
			else if(Ссылка == НДС)
			{
				return ВидыРасходовУСН.НДС;
			}
			return ВидыРасходовУСН.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыРасходовУСН Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыРасходовУСН Значение)
		{
			switch (Значение)
			{
				case ВидыРасходовУСН.Номенклатура: return Номенклатура;
				case ВидыРасходовУСН.Услуги: return Услуги;
				case ВидыРасходовУСН.РБП: return РБП;
				case ВидыРасходовУСН.ДопРасходы: return ДопРасходы;
				case ВидыРасходовУСН.ОС: return ОС;
				case ВидыРасходовУСН.НМА: return НМА;
				case ВидыРасходовУСН.Зарплата: return Зарплата;
				case ВидыРасходовУСН.Налоги: return Налоги;
				case ВидыРасходовУСН.НДС: return НДС;
			}
			return Guid.Empty;
		}
	}
}