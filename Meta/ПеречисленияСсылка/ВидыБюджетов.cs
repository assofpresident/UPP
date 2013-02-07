
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum ВидыБюджетов
	{
		ПустаяСсылка = - 1,
	///<summary>
	///Бюджет доходов и расходов
	///</summary>
		БДР = 0,//Бюджет доходов и расходов
		БДДС = 1,//Бюджет движения денежных средств
		Прочие = 2,//Прочие оборотные бюджеты
	}
	public static partial class ВидыБюджетов_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///Бюджет доходов и расходов
		///</summary>
		public static readonly Guid БДР = new Guid("ec4caf8c-4b04-6b48-4f0b-d0224b525b58");//Бюджет доходов и расходов
		public static readonly Guid БДДС = new Guid("99981abf-2780-33b5-4230-fbd7a0bf2e21");//Бюджет движения денежных средств
		public static readonly Guid Прочие = new Guid("a9301398-3214-22fe-4719-c5fc601c1b8b");//Прочие оборотные бюджеты
		public static ВидыБюджетов Получить(this ВидыБюджетов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыБюджетов Получить(this ВидыБюджетов Значение, Guid Ссылка)
		{
			if(Ссылка == БДР)
			{
				return ВидыБюджетов.БДР;
			}
			else if(Ссылка == БДДС)
			{
				return ВидыБюджетов.БДДС;
			}
			else if(Ссылка == Прочие)
			{
				return ВидыБюджетов.Прочие;
			}
			return ВидыБюджетов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыБюджетов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыБюджетов Значение)
		{
			switch (Значение)
			{
				case ВидыБюджетов.БДР: return БДР;
				case ВидыБюджетов.БДДС: return БДДС;
				case ВидыБюджетов.Прочие: return Прочие;
			}
			return Guid.Empty;
		}
	}
}