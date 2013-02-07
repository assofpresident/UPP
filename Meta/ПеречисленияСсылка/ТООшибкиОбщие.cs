
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ТООшибкиОбщие
	{
		ПустаяСсылка = - 1,
	///<summary>
	///Необходимо проверить корректность установки драйвера.
	///</summary>
		ОшибкаЗагрузкиДрайвера = 0,//Не удалось загрузить драйвер торгового оборудования
	///<summary>
	///Проверьте корректность указания обработки обслуживания и ее версию.
	///</summary>
		ОшибкаЗагрузкиОбработкиОбслуживания = 1,//Ошибка загрузки обработки обслуживания
	///<summary>
	///Была обнаружена ошибка, обработка которой не предусмотрена.
	///</summary>
		ОшибкаНеизвестно = 2,//Неизвестная ошибка
	///<summary>
	///Необходимо обратиться к администратору информационной базы.
	///</summary>
		ОшибкаНетПрав = 3,//У текущего пользователя нет прав на использование торгового оборудования
	///<summary>
	///Для корректной работы устройства необходимо задать параметры его работы. Сделать это можно при помощи обработки "Настройка торгового оборудования".
	///</summary>
		ОшибкаПараметровНастройки = 4,//Подключаемое оборудование не было корректно настроено
	///<summary>
	///Необходимо убедиться, что устройство правильно настроено и соответствующий порт не занят другим приложением.
	///</summary>
		ОшибкаПриПодключении = 5,//Ошибка при подключении устройства
	///<summary>
	///Автоматический тест устройства не пройден.
	///</summary>
		ОшибкаТестНеПройден = 6,//Тест устройства не был пройден
	}
	public static partial class ТООшибкиОбщие_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///Необходимо проверить корректность установки драйвера.
		///</summary>
		public static readonly Guid ОшибкаЗагрузкиДрайвера = new Guid("b9adf7b4-0039-711a-4188-f22e807ff898");//Не удалось загрузить драйвер торгового оборудования
		///<summary>
		///Проверьте корректность указания обработки обслуживания и ее версию.
		///</summary>
		public static readonly Guid ОшибкаЗагрузкиОбработкиОбслуживания = new Guid("2950469e-e02b-6fa2-4a45-4fc1b167d6ea");//Ошибка загрузки обработки обслуживания
		///<summary>
		///Была обнаружена ошибка, обработка которой не предусмотрена.
		///</summary>
		public static readonly Guid ОшибкаНеизвестно = new Guid("05e3509f-d2e8-1521-4489-53cf04a04893");//Неизвестная ошибка
		///<summary>
		///Необходимо обратиться к администратору информационной базы.
		///</summary>
		public static readonly Guid ОшибкаНетПрав = new Guid("d9d8cc82-edda-4d73-4587-f3e3796eed86");//У текущего пользователя нет прав на использование торгового оборудования
		///<summary>
		///Для корректной работы устройства необходимо задать параметры его работы. Сделать это можно при помощи обработки "Настройка торгового оборудования".
		///</summary>
		public static readonly Guid ОшибкаПараметровНастройки = new Guid("fb549983-426d-3bec-46fd-9783b8446ab6");//Подключаемое оборудование не было корректно настроено
		///<summary>
		///Необходимо убедиться, что устройство правильно настроено и соответствующий порт не занят другим приложением.
		///</summary>
		public static readonly Guid ОшибкаПриПодключении = new Guid("30d502ba-f8db-46f5-4e06-f0f2e98c8e90");//Ошибка при подключении устройства
		///<summary>
		///Автоматический тест устройства не пройден.
		///</summary>
		public static readonly Guid ОшибкаТестНеПройден = new Guid("541586a6-5b86-6a35-46b5-66218015ebb0");//Тест устройства не был пройден
		public static ТООшибкиОбщие Получить(this ТООшибкиОбщие Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТООшибкиОбщие Получить(this ТООшибкиОбщие Значение, Guid Ссылка)
		{
			if(Ссылка == ОшибкаЗагрузкиДрайвера)
			{
				return ТООшибкиОбщие.ОшибкаЗагрузкиДрайвера;
			}
			else if(Ссылка == ОшибкаЗагрузкиОбработкиОбслуживания)
			{
				return ТООшибкиОбщие.ОшибкаЗагрузкиОбработкиОбслуживания;
			}
			else if(Ссылка == ОшибкаНеизвестно)
			{
				return ТООшибкиОбщие.ОшибкаНеизвестно;
			}
			else if(Ссылка == ОшибкаНетПрав)
			{
				return ТООшибкиОбщие.ОшибкаНетПрав;
			}
			else if(Ссылка == ОшибкаПараметровНастройки)
			{
				return ТООшибкиОбщие.ОшибкаПараметровНастройки;
			}
			else if(Ссылка == ОшибкаПриПодключении)
			{
				return ТООшибкиОбщие.ОшибкаПриПодключении;
			}
			else if(Ссылка == ОшибкаТестНеПройден)
			{
				return ТООшибкиОбщие.ОшибкаТестНеПройден;
			}
			return ТООшибкиОбщие.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТООшибкиОбщие Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТООшибкиОбщие Значение)
		{
			switch (Значение)
			{
				case ТООшибкиОбщие.ОшибкаЗагрузкиДрайвера: return ОшибкаЗагрузкиДрайвера;
				case ТООшибкиОбщие.ОшибкаЗагрузкиОбработкиОбслуживания: return ОшибкаЗагрузкиОбработкиОбслуживания;
				case ТООшибкиОбщие.ОшибкаНеизвестно: return ОшибкаНеизвестно;
				case ТООшибкиОбщие.ОшибкаНетПрав: return ОшибкаНетПрав;
				case ТООшибкиОбщие.ОшибкаПараметровНастройки: return ОшибкаПараметровНастройки;
				case ТООшибкиОбщие.ОшибкаПриПодключении: return ОшибкаПриПодключении;
				case ТООшибкиОбщие.ОшибкаТестНеПройден: return ОшибкаТестНеПройден;
			}
			return Guid.Empty;
		}
	}
}