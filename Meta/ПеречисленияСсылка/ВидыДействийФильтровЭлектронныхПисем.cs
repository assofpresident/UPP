
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыДействийФильтровЭлектронныхПисем
	{
		ПустаяСсылка = - 1,
		ПоместитьПисьмоВПапку = 0,//Поместить письмо в папку ...
		ПродолжитьДальнейшуюОбработкуПравил = 1,//Продолжить дальнейшую обработку правил
		УстановитьПисьмуФлагРассмотрено = 2,//Установить письму флаг "Рассмотрено"
		УстановитьПисьмуОформление = 3,//Установить письму оформление...
	}
	public static partial class ВидыДействийФильтровЭлектронныхПисем_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоместитьПисьмоВПапку = new Guid("abd838a1-c860-5c6a-40b6-e101abd447c9");//Поместить письмо в папку ...
		public static readonly Guid ПродолжитьДальнейшуюОбработкуПравил = new Guid("1e1480a6-f353-de6c-48ca-333eb4b73e10");//Продолжить дальнейшую обработку правил
		public static readonly Guid УстановитьПисьмуФлагРассмотрено = new Guid("e21515b2-fd14-68fd-410a-4c7fe5e9a131");//Установить письму флаг "Рассмотрено"
		public static readonly Guid УстановитьПисьмуОформление = new Guid("d9c38b81-5660-f77a-4774-5d54132ab214");//Установить письму оформление...
		public static ВидыДействийФильтровЭлектронныхПисем Получить(this ВидыДействийФильтровЭлектронныхПисем Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыДействийФильтровЭлектронныхПисем Получить(this ВидыДействийФильтровЭлектронныхПисем Значение, Guid Ссылка)
		{
			if(Ссылка == ПоместитьПисьмоВПапку)
			{
				return ВидыДействийФильтровЭлектронныхПисем.ПоместитьПисьмоВПапку;
			}
			else if(Ссылка == ПродолжитьДальнейшуюОбработкуПравил)
			{
				return ВидыДействийФильтровЭлектронныхПисем.ПродолжитьДальнейшуюОбработкуПравил;
			}
			else if(Ссылка == УстановитьПисьмуФлагРассмотрено)
			{
				return ВидыДействийФильтровЭлектронныхПисем.УстановитьПисьмуФлагРассмотрено;
			}
			else if(Ссылка == УстановитьПисьмуОформление)
			{
				return ВидыДействийФильтровЭлектронныхПисем.УстановитьПисьмуОформление;
			}
			return ВидыДействийФильтровЭлектронныхПисем.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыДействийФильтровЭлектронныхПисем Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыДействийФильтровЭлектронныхПисем Значение)
		{
			switch (Значение)
			{
				case ВидыДействийФильтровЭлектронныхПисем.ПоместитьПисьмоВПапку: return ПоместитьПисьмоВПапку;
				case ВидыДействийФильтровЭлектронныхПисем.ПродолжитьДальнейшуюОбработкуПравил: return ПродолжитьДальнейшуюОбработкуПравил;
				case ВидыДействийФильтровЭлектронныхПисем.УстановитьПисьмуФлагРассмотрено: return УстановитьПисьмуФлагРассмотрено;
				case ВидыДействийФильтровЭлектронныхПисем.УстановитьПисьмуОформление: return УстановитьПисьмуОформление;
			}
			return Guid.Empty;
		}
	}
}