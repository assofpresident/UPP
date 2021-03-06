﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class УправлениеЗапасамиПартионныйУчетФормированиеПроводокРегл
	{
		////////////////////////////////////////////////////////////////////////////////
		// ТЕХНОЛОГИЧЕСКИЕ

		public object ОтноситсяКДеятельностиЕНВДИзСтруктурыПараметров(/*СтруктураПараметров, Счет*/)
		{
			//Кэш = СтруктураПараметров.КэшОтноситсяКДеятельностиЕНВД;
			//Результат = Кэш[Счет];
			if(true/*Результат = Неопределено*/)
			{
				//Результат = НалоговыйУчетУСН.ОтноситсяКДеятельностиЕНВД(Счет);
				//Кэш.Вставить(Счет, Результат);
			}
			return null;
		}
		// Процедура считывает контрагента договора по ссылке без чтения всего объекта
		//

		public object ПолучитьКонтрагентаИзДоговора(/*ДоговорКонтрагента, СтруктураПараметров*/)
		{
			if(true/*ТипЗнч(ДоговорКонтрагента) = Тип("СправочникСсылка.ДоговорыКонтрагентов")
		И ЗначениеЗаполнено(ДоговорКонтрагента)*/)
			{
				//СтруктураПараметров.Вставить("КонтрагентИзДоговораКонтрагента",ДоговорКонтрагента.Владелец);
			}
			return null;
		}
		// Процедура считывает контрагента из документа по ссылке без чтения всего объекта
		//

		public object ПолучитьКонтрагентаИзДокументаОприходования(/*ДокументОприходования*/)
		{
			/*// Получаем контрагента из документа партии
*/
			if(true/*ЗначениеЗаполнено(ДокументОприходования)*/)
			{
				//МетаданныеДокумента = Метаданные.НайтиПоТипу(ТипЗнч(ДокументОприходования));
				if(true/*МетаданныеДокумента <> Неопределено*/)
				{
					if(true/*МетаданныеДокумента.Реквизиты.Найти("Контрагент")<>Неопределено*/)
					{
						//Запрос = Новый Запрос("Выбрать Контрагент Из Документ."+МетаданныеДокумента.Имя+" ГДЕ Ссылка = &Ссылка");
						//Запрос.УстановитьПараметр("Ссылка", ДокументОприходования);
						//Выборка = Запрос.Выполнить().Выбрать();
						if(true/*Выборка.Следующий()*/)
						{
						}
					}
				}
			}
			return null;
		}
		// Проверяет, что счет является субсчетом
		//
		// Параметры:
		//	Проверяемый счет, Счет-родитель, общая структура параметров.
		//
		// Возвращаемое значение:
		//
		//

		public object СчетВИерархии(/*ПроверяемыйСчет, СчетРодитель, СтруктураПараметров*/)
		{
			if(true/*НЕ ЗначениеЗаполнено(ПроверяемыйСчет)*/)
			{
			}
			/*// В свойстве СоотвИерархияСчетов кэшируются данные об иерархии счетов
*/
			if(true/*НЕ СтруктураПараметров.Свойство("СоотвИерархияСчетов", СоотвИерархияСчетов)*/)
			{
				//СоотвИерархияСчетов = Новый Соответствие;
				//СтруктураПараметров.Вставить("СоотвИерархияСчетов", СоотвИерархияСчетов);
			}
			/*// Иерархия для каждого отдельного счета
*/
			//СоотвИерархия = СоотвИерархияСчетов[СчетРодитель];
			if(true/*ТипЗнч(СоотвИерархия) <> Тип("Соответствие")*/)
			{
				//СоотвИерархия = Новый Соответствие;
				/*// Определим иерархию счетов
*/
				//ИмяПланаСчетов = ПроверяемыйСчет.Метаданные().Имя;
				/*ЗапросСчета = Новый Запрос(
		"ВЫБРАТЬ
		|	ПланСчетовРегистра.Ссылка КАК Ссылка
		|ИЗ
		|	ПланСчетов."+ИмяПланаСчетов+" КАК ПланСчетовРегистра
		|
		|ГДЕ
		|	ПланСчетовРегистра.Ссылка В ИЕРАРХИИ (&Ссылка)
		|");*/
				//ЗапросСчета.УстановитьПараметр("Ссылка", СчетРодитель);
				//ВыборкаСчета = ЗапросСчета.Выполнить().Выбрать(ОбходРезультатаЗапроса.Прямой);
				while(true/*ВыборкаСчета.Следующий()*/)
				{
					//СоотвИерархия.Вставить(ВыборкаСчета.Ссылка, ВыборкаСчета.Ссылка);
				}
				/*;
		
		СоотвИерархияСчетов.Вставить(СчетРодитель, СоотвИерархия);*/
			}
			/*// Собственно проверка
*/
			//Возврат НЕ (СоотвИерархия[ПроверяемыйСчет] = Неопределено);
			return null;
		}
		// СчетВИерархии()

		public object ВидСубконтоСодержитТип(/*СтруктураПараметров, ВидСубконто, ТипЗнчСубконто*/)
		{
			//Кэш = СтруктураПараметров.КэшПоВидамСубконто;
			//КэшПоВиду = Кэш[ВидСубконто];
			if(true/*КэшПоВиду = Неопределено*/)
			{
				//КэшПоВиду = Новый Соответствие;
				//Кэш.Вставить(ВидСубконто, КэшПоВиду);
			}
			//Результат = КэшПоВиду[ТипЗнчСубконто];
			if(true/*Результат = НЕопределено*/)
			{
				//Результат = ВидСубконто.ВидСубконто.ТипЗначения.СодержитТип(ТипЗнчСубконто);
				//КэшПоВиду.Вставить(ТипЗнчСубконто, Результат);
			}
			return null;
		}
		//ВидСубконтоСодержитТип

		public void ЗаполнитьСубконтоПоРеквизитам(/*ВидСубконто, Субконто, ЗначениеСубконто1, ЗначениеСубконто2=Неопределено, ЗначениеСубконто3=Неопределено, ЗаполнятьТолькоПустые = Ложь, СтруктураПараметров*/)
		{
			if(true/*ЗаполнятьТолькоПустые*/)
			{
				/*// в этом режиме заполняются только пустые
*/
				if(true/*ЗначениеЗаполнено(Субконто[ВидСубконто.Видсубконто])*/)
				{
				}
			}
			//ТипЗнчСубконто1 = ТипЗнч(ЗначениеСубконто1);
			//ТипЗнчСубконто2 = ТипЗнч(ЗначениеСубконто2);
			//ТипЗнчСубконто3 = ТипЗнч(ЗначениеСубконто3);
			if(true/*ЗначениеЗаполнено(ЗначениеСубконто1) И ВидСубконтоСодержитТип(СтруктураПараметров, ВидСубконто, ТипЗнчСубконто1)*/)
			{
				//Субконто.Вставить(ВидСубконто.ВидСубконто, ЗначениеСубконто1);
			}
		}
		//ЗаполнитьСубконтоПоРеквизитам

		public void ЗаполнитьСубконтоПоСписаниюТоваровРегл(/*Проводка, СтрокаДокумента, Движение, СтруктураПараметров, ВидУчета*/)
		{
			if(true/*СтрокаДокумента.ОтражатьВБухгалтерскомУчете*/)
			{
				//КорСубконто1 = СтрокаДокумента.КорСубконтоБУ1;
				//КорСубконто2 = СтрокаДокумента.КорСубконтоБУ2;
				//КорСубконто3 = СтрокаДокумента.КорСубконтоБУ3;
				//СчетТоварыПринятые    = ПланыСчетов.Хозрасчетный.ТоварыПринятыеНаКомиссию;
			}
			//ВидСубконтоНоменклатура = ПланыВидовХарактеристик.ВидыСубконтоХозрасчетные.Номенклатура;
			//ВидСубконтоНоменклатурныеГруппы = ПланыВидовХарактеристик.ВидыСубконтоХозрасчетные.НоменклатурныеГруппы;
			//ВидСубконтоСклады       = ПланыВидовХарактеристик.ВидыСубконтоХозрасчетные.Склады;
			//ВидСубконтоПодразделения= ПланыВидовХарактеристик.ВидыСубконтоХозрасчетные.Подразделения;
			//ВидСубконтоСтатьиЗатрат = ПланыВидовХарактеристик.ВидыСубконтоХозрасчетные.СтатьиЗатрат;
			//ВидСубконтоДоговоры     = ПланыВидовХарактеристик.ВидыСубконтоХозрасчетные.Договоры;
			//ВидСубконтоКонтрагенты  = ПланыВидовХарактеристик.ВидыСубконтоХозрасчетные.Контрагенты;
			//ВидСубконтоКомиссионеры = ПланыВидовХарактеристик.ВидыСубконтоХозрасчетные.Комиссионеры;
			//ВидСубконтоОбъектыСтроительства = ПланыВидовХарактеристик.ВидыСубконтоХозрасчетные.ОбъектыСтроительства;
			//ВидСубконтоОсновныеСредства = ПланыВидовХарактеристик.ВидыСубконтоХозрасчетные.ОсновныеСредства;
			/*// Заполняем дебет:
*/
			if(true/*ЗначениеЗаполнено(Проводка.СчетДт)*/)
			{
			}
			/*// Заполняем кредит
*/
			if(true/*ЗначениеЗаполнено(Проводка.СчетКт)*/)
			{
			}
		}
		//ЗаполнитьСубконтоПоСписаниюТоваровРегл
		/////////////////////////////////////////////////////////////////////////////////
		// ДВИЖЕНИЯ,ВЫПОЛНЯЕМЫЕ ПО РЕЗУЛЬТАТУ СПИСАНИЯ
		// Связанные со списанием движения по бух и нал учету
		//
		// Параметры:
		//	Нет.
		//

		public void ВыполнитьСвязанныеДвиженияРегл(/*СтрокаДокумента, СтруктураПараметров, Движение*/)
		{
			if(true/*СтруктураПараметров.Свойство("ИспользоватьРасширеннуюАналитику")
	  И СтруктураПараметров.ИспользоватьРасширеннуюАналитику
	  И УправлениеЗапасамиПартионныйУчет.ПолучитьПараметрУчетнойПолитикиПартионногоУчета("СистемаНалогообложения", "Бух", СтруктураПараметров) = Перечисления.СистемыНалогообложения.Упрощенная*/)
			{
			}
			if(true/*СтрокаДокумента.ОтражатьвБухгалтерскомУчете*/)
			{
				//КодыОпераций = Перечисления.КодыОперацийПартииТоваров;
				/*// 1. Начисление задолженности перед комитентом при реализации комиссионных товаров
*/
				if(true/*(СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.Реализация
			ИЛИ СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.РеализацияРозница
			ИЛИ СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.РеализацияКомиссия
			ИЛИ СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.СписаниеНаБрак
			ИЛИ СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.СписаниеПоИнвентаризации)
			И Движение.СчетУчета=СтрокаДокумента.ПринятыеСчетУчетаБУ*/)
				{
					//НачислитьЗадолженностьПередКомитентом(СтрокаДокумента, СтруктураПараметров, Движение);
				}
				/*// Начисление задолженности покупателя при реализации собственных товаров
*/
				if(true/*(СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.Реализация 
			ИЛИ СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.РеализацияРозница
			ИЛИ СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.РеализацияКомиссия)
			И Движение.СчетУчета=СтрокаДокумента.СчетУчетаБУ*/)
				{
					//НачислитьДоходОтРеализации(СтрокаДокумента, СтруктураПараметров, Движение);
				}
				/*// Сторно  задолженности покупателя 
*/
				if(true/*СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.ВозвратОтПокупателя  
		   И Движение.СчетУчета=СтрокаДокумента.СчетУчетаБУ*/)
				{
					//НачислитьДоходОтРеализации(СтрокаДокумента, СтруктураПараметров, Движение,"Сторно");
				}
				/*// Сторно задолженности перед комитентом
*/
				if(true/*СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.ВозвратОтПокупателя  
		   И Движение.СчетУчета=СтрокаДокумента.ПринятыеСчетУчетаБУ*/)
				{
					//НачислитьЗадолженностьПередКомитентом(СтрокаДокумента, СтруктураПараметров, Движение, "Сторно");
				}
				if(true/*СтрокаДокумента.НеСписывать И НЕ СтруктураПараметров.СписыватьПартииРасходнымОрдером 
		   И ( СтрокаДокумента.КодОперацииПартииТоваров = Перечисления.КодыОперацийПартииТоваров.Реализация Или
				СтрокаДокумента.КодОперацииПартииТоваров = Перечисления.КодыОперацийПартииТоваров.ПередачаТарыКонтрагенту)*/)
				{
					//ОприходоватьТоварПринятыйНаОтветственноеХранениеБух(СтрокаДокумента, СтруктураПараметров, Движение);
				}
			}
			if(true/*(СтрокаДокумента.ОтражатьВНалоговомУчете) И (ТипЗнч(СтрокаДокумента.СчетУчетаНУ) <> Тип("ПланСчетовСсылка.Хозрасчетный"))*/)
			{
				//КодыОпераций = Перечисления.КодыОперацийПартииТоваров;
				/*// Начисление задолженности покупателя при реализации собственных товаров
*/
				if(true/*(СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.Реализация 
			ИЛИ СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.РеализацияРозница
			ИЛИ СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.РеализацияКомиссия)
			И Движение.СчетУчета = СтрокаДокумента.СчетУчетаНУ*/)
				{
					//НачислитьДоходОтРеализации(СтрокаДокумента, СтруктураПараметров, Движение);
				}
				/*// Сторно  задолженности покупателя 
*/
				if(true/*СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.ВозвратОтПокупателя  
		   И Движение.СчетУчета=СтрокаДокумента.СчетУчетаНУ*/)
				{
					//НачислитьДоходОтРеализации(СтрокаДокумента, СтруктураПараметров, Движение,"Сторно");
				}
			}
		}
		// ВыполнитьСвязанныеДвиженияРегл()
		//Ответственное хранение

		public void ОприходоватьТоварПринятыйНаОтветственноеХранениеБух(/*СтрокаДокумента, СтруктураПараметров, Строка*/)
		{
			if(true/*СтрокаДокумента.ОтражатьВБухгалтерскомУчете*/)
			{
				//Учет = "Бух";
			}
			//Движение = УправлениеЗапасамиПартионныйУчет.ДобавитьДвижениеВСтруктуруПараметров("ПартииТоваровНаСкладах"+Учет, СтруктураПараметров);
			//ЗаполнитьЗначенияСвойств(Движение,Строка);
			//Движение.ВидДвижения = ВидДвиженияНакопления.Приход;
			//Движение.КодОперации = Перечисления.КодыОперацийПартииТоваров.ОтложеннаяОтгрузка;
			//Движение.СчетУчета = ПланыСчетов.Хозрасчетный.ТМЦпринятыеНаОтветственноеХранение;
			/*// В бухгалтерском учете партия принятая на ответственное 
*/
			/*//хранение учитывается по стоимости реализации
*/
			//Движение.Стоимость = Строка.СуммаВыручкиБУ;
			//Проводка = СтруктураПараметров.ДвиженияХозрасчетный.Добавить();
			//Проводка.Период        = СтруктураПараметров.Период;
			//Проводка.Регистратор   = СтруктураПараметров.Регистратор;
			//Проводка.Активность    = Истина;
			//Проводка.Организация   = СтрокаДокумента.Организация;
			//Проводка.Сумма  = Движение.СуммаВыручкиБУ;
			/*// Сумма выручки по бух. учету
*/
			//Проводка.СчетДт = Движение.СчетУчета;
			//Проводка.КоличествоДт = Движение.Количество;
			//Проводка.Содержание = Строка(Движение.КодОперации);
			//ЗаполнитьСубконтоПоСписаниюТоваровРегл(Проводка, СтрокаДокумента, Движение, СтруктураПараметров, Учет);
			//СтруктураПараметров.ИзмененыДвиженияХозрасчетный = Истина;
		}
		//ОприходоватьТоварПринятыйНаОтветственноеХранение
		////////////////////////////////////////////////////////////////////////////////
		// СПИСАНИЕ ПО СЧЕТАМ БУХ УЧЕТА
		// Регл
		// Содержание проводки для бухгалтерского и налогового учета

		public object ПолучитьСодержаниеПроводки(/*СтрокаДокумента, СтруктураПараметров, Актив = ""*/)
		{
			//КодыОпераций = СтруктураПараметров.КодыОпераций;
			//НазваниеАктива = ?(Актив = "" Или Актив = Неопределено, "", БухгалтерскийУчет.ПолучитьНазваниеОбъекта(Актив) + " ");
			if(true/*СтруктураПараметров.ТипЗначенияРегистратора =Тип("ДокументСсылка.РеализацияУслугПоПереработке")*/)
			{
				//СодержаниеПроводки = "Реализация услуг по переработке";
			}
			return null;
		}
		//ПолучитьСодержаниеПроводки
		// Формирование проводок по отклонению в стоимости тары для бухгалтерского и налогового учета

		public void СформироватьПроводкуОтклоненияВСтоимостиТары(/*СтрокаДокумента, Проводка, Движение, СтруктураПараметров, ИмяРегистра */)
		{
			/*// Проводка по передаче тары (при проведении документа реализации)
*/
			if(true/*СтрокаДокумента.КодОперацииПартииТоваров = Перечисления.КодыОперацийПартииТоваров.ПередачаТарыКонтрагенту 
		И Проводка.КоличествоКт>0
		И ((НЕ Проводка.СчетКт.Забалансовый И ИмяРегистра = "Хозрасчетный") Или ИмяРегистра = "Налоговый")*/)
			{
				//Себестоимость = Проводка.Сумма;
				//СтоимостьПередачи = Движение.СтоимостьПоступление;
				/*// Задолженность по новой (залоговой) стоимости
*/
				//Проводка.Сумма = СтоимостьПередачи;
				/*// Если стоимость передачи не равна себестоимости - добавим проводку по начислению разницы на прочие доходы/расходы
*/
				//ПерваяПроводка = Проводка;
				if(true/*СтоимостьПередачи <> Себестоимость*/)
				{
					//ВтораяПроводка = СтруктураПараметров["Движения"+ИмяРегистра].Добавить();
					//ВтораяПроводка.Период        = СтруктураПараметров.Период;
					//ВтораяПроводка.Регистратор   = СтруктураПараметров.Регистратор;
					//ВтораяПроводка.Активность    = Истина;
					if(true/*Себестоимость > СтоимостьПередачи*/)
					{
						if(true/*ИмяРегистра = "Хозрасчетный"*/)
						{
							//ВтораяПроводка.СчетДт    = СтрокаДокумента.СчетРасходовБУ;
						}
						//ВтораяПроводка.Сумма = Себестоимость - СтоимостьПередачи;
						//ВтораяПроводка.СчетКт = ПерваяПроводка.СчетКт;
					}
					if(true/*НЕ ЗначениеЗаполнено(ВтораяПроводка.СчетКт) Или НЕ ЗначениеЗаполнено(ВтораяПроводка.СчетДт)*/)
					{
						/*СтрокаСообщения = "Документ " + СтрокаДокумента.Регистратор + ". Не заполнены значения счетов учета доходов и расходов." + Символы.ПС
				+ "Проводка по отклонению в стоимости тары для номенклатуры " + СтрокаДокумента.Номенклатура 
				+ " не сформирована.";*/
						//ОбщегоНазначения.СообщитьОбОшибке(СтрокаСообщения);
						//СтруктураПараметров["Движения"+ИмяРегистра].Удалить(ВтораяПроводка);
					}
				}
			}
		}
		// Формирование проводок по списанию на счет по бухгалтерскому учету

		public void СписаниеНаСчетБух(/*СписаноИз, СтрокаДокумента, СтруктураПараметров, Движение, ТипЗаписи = "Прямая"*/)
		{
			if(true/*НЕ СтрокаДокумента.ОтражатьВБухгалтерскомУчете*/)
			{
			}
			//ИмяРегистра = "Хозрасчетный";
			//Проводка = СтруктураПараметров["Движения"+ИмяРегистра].Добавить();
			//Количество = Движение.Количество;
			//Сумма      = Движение.Стоимость;
			if(true/*СписаноИз = "Переданные" 
		И Движение.СтоимостьПоступление<>0*/)
			{
				//Сумма = Движение.СтоимостьПоступление;
			}
			if(true/*ТипЗаписи = "Сторно"*/)
			{
				//Количество = - Количество;
				//Сумма      = - Сумма;
			}
			//Проводка.Период        = СтруктураПараметров.Период;
			//Проводка.Регистратор   = СтруктураПараметров.Регистратор;
			//Проводка.Активность    = Истина;
			//Проводка.Организация   = СтрокаДокумента.Организация;
			//Проводка.СчетКт        = Движение.СчетУчета;
			if(true/*ЗначениеЗаполнено(СтрокаДокумента.КорСчетБУ)
		И Проводка.СчетКт.Забалансовый = СтрокаДокумента.КорСчетБУ.Забалансовый*/)
			{
				//Проводка.СчетДт    = СтрокаДокумента.КорСчетБУ;
			}
			/*// Перемещение комиссионных товаров
*/
			if(true/*НЕ СтрокаДокумента.КодОперацииПартииТоваров = Перечисления.КодыОперацийПартииТоваров.ВозвратОтПокупателя*/)
			{
				if(true/*Проводка.СчетКт.Забалансовый
			И (ЗначениеЗаполнено(СтрокаДокумента.ПринятыеКорСчетБУ))*/)
				{
					//Проводка.СчетДт    = СтрокаДокумента.ПринятыеКорСчетБУ;
				}
			}
			if(true/*Проводка.СчетДт.Валютный*/)
			{
				//Проводка.ВалютаДт		 = СтрокаДокумента.КорВалютаЗадолженностиБУ;
				//Проводка.ВалютнаяСуммаДт = Движение.ВалютнаяСуммаЗадолженностиБУ;
			}
			//ЗаполнитьСубконтоПоСписаниюТоваровРегл(Проводка, СтрокаДокумента, Движение, СтруктураПараметров, "Бух");
			/*// Сумма в перемещении должна быть только если ведется партионный учет по складам
*/
			/*// или если товар перемещается на другой счет
*/
			if(true/*СтрокаДокумента.КодОперацииПартииТоваров = Перечисления.КодыОперацийПартииТоваров.ПеремещениеМеждуСкладами 
	   И Не УправлениеЗапасамиПартионныйУчет.ПолучитьПараметрУчетнойПолитикиПартионногоУчета("ВестиПартионныйУчетПоСкладам", "Бух", СтруктураПараметров) 
	   И Проводка.СчетДт = Проводка.СчетКт*/)
			{
				//Проводка.Сумма = 0;
			}
			if(true/*Проводка.СчетКт.Количественный*/)
			{
				//Проводка.КоличествоКт  = Количество;
			}
			/*// Количество
*/
			if(true/*ЗначениеЗаполнено(Проводка.СчетДт)*/)
			{
				if(true/*Проводка.СчетДт.Количественный*/)
				{
					//Проводка.КоличествоДт  = Количество;
					/*// Новое количество-для комплектации
*/
					if(true/*Движение.КоличествоПоступление<>0*/)
					{
						//Проводка.КоличествоДт	= Движение.КоличествоПоступление;
					}
				}
			}
			//Проводка.Содержание = ПолучитьСодержаниеПроводки(СтрокаДокумента, СтруктураПараметров, Проводка.СчетКт);
			/*// Проверка добавленных проводок
*/
			//НеДобавлять = Ложь;
			/*// Проводки с одинаковыми субсчетами и субконто не добавляем:
*/
			if(true/*Проводка.СчетДт = Проводка.СчетКт*/)
			{
				//НеДобавлять = Проводка.КоличествоДт = Проводка.КоличествоКт;
			}
			/*// Проводки с нулевой суммой и количеством не добавляем
*/
			//НеДобавлять = НеДобавлять ИЛИ (Проводка.Сумма=0 И Проводка.КоличествоДт=0 И Проводка.КоличествоКт=0);
			/*// Незаконченные проводки с балансовыми счетами не добавляем
*/
			/*НеДобавлять = НеДобавлять ИЛИ 
	(   НЕ Проводка.СчетДт.Забалансовый И НЕ ЗначениеЗаполнено(Проводка.СчетКт)	
	ИЛИ НЕ Проводка.СчетКт.Забалансовый И НЕ ЗначениеЗаполнено(Проводка.СчетДт));*/
			/*// Проводки не добавляем к не регистрируемым в регистре документам
*/
			//НеДобавлять = НеДобавлять ИЛИ СтруктураПараметров["Движения"+ИмяРегистра].Отбор.Регистратор.Значение = Неопределено;
			/*// Проводка по передаче тары (при проведении документа реализации)
*/
			//СформироватьПроводкуОтклоненияВСтоимостиТары(СтрокаДокумента, Проводка, Движение, СтруктураПараметров, ИмяРегистра);
			/*// Забалансовые счета с разными суммами поступления и списания:
*/
			/*// две  проводки без корреспонденции
*/
			if(true/*СтрокаДокумента.КодОперацииПартииТоваров = Перечисления.КодыОперацийПартииТоваров.ПереоценкаПринятыхНаКомиссию
		И Проводка.СчетДт.Забалансовый И Проводка.СчетКт.Забалансовый
		И Движение.СтоимостьПоступление<>0*/)
			{
				//НеДобавлять = Ложь;
				//ПерваяПроводка = Проводка;
				//ВтораяПроводка = СтруктураПараметров["Движения"+ИмяРегистра].Добавить();
				//ВтораяПроводка.Период        = СтруктураПараметров.Период;
				//ВтораяПроводка.Регистратор   = СтруктураПараметров.Регистратор;
				//ВтораяПроводка.Активность    = Истина;
				//ВтораяПроводка.СчетДт        = ПерваяПроводка.СчетДт;
				//ВтораяПроводка.Сумма         = Движение.СтоимостьПоступление;
				if(true/*ВтораяПроводка.СчетДт.Количественный*/)
				{
					//ВтораяПроводка.КоличествоДт  = Количество;
				}
				//ВтораяПроводка.Организация   = СтрокаДокумента.Организация;
				/*// Перенос субконто
*/
				//ВтораяПроводка.Содержание    = ПерваяПроводка.Содержание;
				//ВтораяПроводка.НомерЖурнала  = ПерваяПроводка.НомерЖурнала;
				/*// Очистка первой проводки
*/
				//ПерваяПроводка.СчетДт = Неопределено;
				//ПерваяПроводка.СубконтоДт.Очистить();
				//ПерваяПроводка.КоличествоДт = 0;
				/*// Нужно устанавливать в зависимости от кода операции
*/
				//ПерваяПроводка.НомерЖурнала  = "";
				/*// Проводка для указания корреспонденции в регистре
*/
				//Проводка = ВтораяПроводка;
			}
			/*// В случае, если проводку добавлять не нужно, удаляем ее из движений
*/
			if(true/*НеДобавлять*/)
			{
				/*// Удаляем добавленную строку
*/
				//СтруктураПараметров["Движения"+ИмяРегистра].Удалить(Проводка);
				/*// Если проводки не добавляются, тогда выход без изменения
*/
			}
			//СтруктураПараметров["ИзмененыДвижения"+ИмяРегистра] = Истина;
			/*// В реквизиты движения регистра занесем счет списания
*/
			//Движение.КорСчет      = Проводка.СчетДт;
			//Сч = 0;
		}
		// СписаниеНаСчетБух()
		// Формирование проводок по списанию на счет по налоговому учету

		public void СписаниеНаСчетНал(/*СписаноИз, СтрокаДокумента, СтруктураПараметров, Движение, ТипЗаписи = "Прямая", ПриходоватьВ*/)
		{
			if(true/*(НЕ СтрокаДокумента.ОтражатьВНалоговомУчете) 
	   ИЛИ (ТипЗнч(Движение.СчетУчета) = Тип("ПланСчетовСсылка.Хозрасчетный"))*/)
			{
			}
			//ИмяРегистра = "Налоговый";
			//Количество = Движение.Количество;
			//Сумма      = Движение.Стоимость;
			//СуммаПР    = Движение.ПостояннаяРазница;
			//СуммаВР    = Движение.ВременнаяРазница;
			if(true/*СписаноИз = "Переданные" 
		И Движение.СтоимостьПоступление<>0*/)
			{
				//Сумма = Движение.СтоимостьПоступление;
			}
			if(true/*ТипЗаписи = "Сторно"*/)
			{
				//Количество = - Количество;
				//Сумма      = - Сумма;
				//СуммаПР    = - СуммаПР;
				//СуммаВР    = - СуммаВР;
			}
			if(true/*Движение.СчетУчета = СтрокаДокумента.СчетУчетаНУ*/)
			{
				//КорСчетНУ = СтрокаДокумента.КорСчетНУ;
			}
		}
		// СписаниеНаСчетНал()
		// Списание партии на счет бухгалтерского учета

		public void СписаниеНаСчет(/*СписаноИз, СтрокаДокумента, СтруктураПараметров, Движение, ТипЗаписи = "Прямая", ПриходоватьВ = Неопределено*/)
		{
			if(true/*СтруктураПараметров.Свойство("ИспользоватьРасширеннуюАналитику")
	  И СтруктураПараметров.ИспользоватьРасширеннуюАналитику
	  И УправлениеЗапасамиПартионныйУчет.ПолучитьПараметрУчетнойПолитикиПартионногоУчета("СистемаНалогообложения", "Бух", СтруктураПараметров) = Перечисления.СистемыНалогообложения.Упрощенная*/)
			{
			}
			if(true/*СтруктураПараметров.ФормироватьПроводкиПоСписаниюТМЦ*/)
			{
				//СписаниеНаСчетБух(СписаноИз, СтрокаДокумента, СтруктураПараметров, Движение, ТипЗаписи);
				//СписаниеНаСчетНал(СписаноИз, СтрокаДокумента, СтруктураПараметров, Движение, ТипЗаписи, ПриходоватьВ);
			}
		}
		//СписаниеНаСчет
		////////////////////////////////////////////////////////////////////////////////
		// ПРОВОДКИ ПО БУХ УЧЕТУ, ЗАВИСЯЩИЕ ОТ ТОГО, КАКИЕ ПАРТИИ СПИСАНЫ
		// Формирование проводок по начислению задолженности перед комитентом
		//

		public void НачислитьЗадолженностьПередКомитентом(/*СтрокаДокумента, СтруктураПараметров, Движение, ТипЗаписи = "Прямая"*/)
		{
			//КодыОпераций = Перечисления.КодыОперацийПартииТоваров;
			if(true/*ТипЗаписи = "Сторно"*/)
			{
				//КоэффициентСторно = -1;
			}
			/*Запрос = Новый Запрос(
	"ВЫБРАТЬ
	|	ПоступлениеТоваровУслуг.Контрагент,
	|	ПоступлениеТоваровУслуг.ДоговорКонтрагента,
	|	ПоступлениеТоваровУслуг.СчетУчетаРасчетовСКонтрагентом,
	|	ПоступлениеТоваровУслуг.ДоговорКонтрагента.ВалютаВзаиморасчетов КАК ВалютаРасчетовСКомитентом
	|ИЗ
	|	Документ.ПоступлениеТоваровУслуг КАК ПоступлениеТоваровУслуг
	|ГДЕ
	|	ПоступлениеТоваровУслуг.Ссылка = &Ссылка");*/
			//Запрос.УстановитьПараметр("Ссылка", Движение.ДокументОприходования);
			//ВыборкаПринятиеНаКомиссию = Запрос.Выполнить().Выбрать();
			if(true/*ВыборкаПринятиеНаКомиссию.Следующий()*/)
			{
				if(true/*ЗначениеЗаполнено(ВыборкаПринятиеНаКомиссию.СчетУчетаРасчетовСКонтрагентом)*/)
				{
					//Проводка = СтруктураПараметров["ДвиженияХозрасчетный"].Добавить();
					//Проводка.Период        = СтруктураПараметров.Период;
					//Проводка.Регистратор   = СтруктураПараметров.Регистратор;
					//Проводка.Активность    = Истина;
					//Проводка.Организация   = СтрокаДокумента.Организация;
					//Проводка.СчетКт        = ВыборкаПринятиеНаКомиссию.СчетУчетаРасчетовСКонтрагентом;
					//Проводка.СубконтоКт.Контрагенты = ВыборкаПринятиеНаКомиссию.Контрагент;
					//Проводка.СубконтоКт.Договоры    = ВыборкаПринятиеНаКомиссию.ДоговорКонтрагента;
					//Проводка.СчетДт        = СтрокаДокумента.КорСчетЗадолженностиБУ;
					if(true/*Проводка.СчетДт.Валютный*/)
					{
						//Проводка.ВалютаДт      = СтрокаДокумента.КорВалютаЗадолженностиБУ;
						//Проводка.ВалютнаяСуммаДт = КоэффициентСторно*Движение.ВалютнаяСуммаЗадолженностиБУ;
					}
					if(true/*Проводка.СчетКт.Валютный*/)
					{
						if(true/*СтрокаДокумента.КорВалютаЗадолженностиБУ = ВыборкаПринятиеНаКомиссию.ВалютаРасчетовСКомитентом*/)
						{
							/*//Если валюта расчетов с комитентом совпадает с валютой расчетов по договору, считаем что и курсы совпадают.
*/
							//Проводка.ВалютаКт        = СтрокаДокумента.КорВалютаЗадолженностиБУ;
							//Проводка.ВалютнаяСуммаКт = Проводка.ВалютнаяСуммаДт;
						}
					}
					//Проводка.Сумма = КоэффициентСторно*Движение.СуммаВыручкиБУ;
					/*// При списании по инвентаризации начисляется задолженность на сумму поступления
*/
					if(true/*СтрокаДокумента.КодОперацииПартииТоваров = КодыОпераций.СписаниеПоИнвентаризации*/)
					{
						//Проводка.Сумма         = КоэффициентСторно*Движение.Стоимость;
					}
					/*//Проводка.НомерЖурнала  = ПолучитьНомерЖурналаБУПоКоду(СтрокаДокумента);
*/
					//КорСубконто1 = СтрокаДокумента.КорСубконтоЗадолженностиБУ1;
					//КорСубконто2 = СтрокаДокумента.КорСубконтоЗадолженностиБУ2;
					//КорСубконто3 = СтрокаДокумента.КорСубконтоЗадолженностиБУ3;
					//ТипЗнчКорСубконто1 = ТипЗнч(КорСубконто1);
					//ТипЗнчКорСубконто2 = ТипЗнч(КорСубконто2);
					//ТипЗнчКорСубконто3 = ТипЗнч(КорСубконто3);
					//СтруктураПараметров["ИзмененыДвиженияХозрасчетный"] = Истина;
				}
			}
		}
		//НачислитьЗадолженностьПередКомитентом
		// Формирование проводок по начислению дохода от реализации товаров по бух и нал учету,
		// Используется в случаях, когда при реализации может быть списан как собственный, так и комиссионный товар
		//

		public void НачислитьДоходОтРеализации(/*СтрокаДокумента, СтруктураПараметров, Движение, ТипЗаписи = "Прямая"*/)
		{
			if(true/*СтрокаДокумента.ОтражатьВБухгалтерскомУчете*/)
			{
				//Учет="Бух";
			}
			if(true/*Учет = "Бух"*/)
			{
				//ИмяРегистра = "Хозрасчетный";
			}
			if(true/*ТипЗаписи = "Сторно"*/)
			{
				//КоэффициентСторно = -1;
			}
			/*// Для проверки добавленных проводок
*/
			//НеДобавлять = Ложь;
			//Проводка = СтруктураПараметров["Движения"+ИмяРегистра].Добавить();
			//Проводка.Период        = СтруктураПараметров.Период;
			//Проводка.Регистратор   = СтруктураПараметров.Регистратор;
			//Проводка.Активность    = Истина;
			//Проводка.Организация   = СтрокаДокумента.Организация;
			//Проводка.Содержание = ПолучитьСодержаниеПроводки(СтрокаДокумента, СтруктураПараметров, Проводка.СчетКт);
			if(true/*Учет="Бух"*/)
			{
				//Проводка.Сумма  = КоэффициентСторно*Движение.СуммаВыручкиБУ;
				/*// Сумма выручки по бух. учету
*/
				//Проводка.СчетДт = СтрокаДокумента.КорСчетЗадолженностиБУ;
				if(true/*Проводка.СчетДт.Валютный*/)
				{
					//Проводка.ВалютаДт        = СтрокаДокумента.КорВалютаЗадолженностиБУ;
					//Проводка.ВалютнаяСуммаДт = КоэффициентСторно*Движение.ВалютнаяСуммаЗадолженностиБУ;
				}
				//Проводка.СчетКт = СтрокаДокумента.СчетДоходовБУ;
				/*//Движения по НДС от реализации
*/
				if(true/*Не Движение.СчетУчета.Забалансовый*/)
				{
					/*// Начисление НДС с выручки
*/
					if(true/*(Не СтрокаДокумента.КодОперацииПартииТоваров = Перечисления.КодыОперацийПартииТоваров.ВозвратОтПокупателя)
			  И (Не СтрокаДокумента.КодОперацииПартииТоваров = Перечисления.КодыОперацийПартииТоваров.ВозвратОтПокупателяТекущийМесяц)*/)
					{
						//УчетНДС.НачислитьНДСРеализации(КоэффициентСторно*Движение.СуммаНДСВыручкиБУ, СтрокаДокумента, СтруктураПараметров);
					}
				}
			}
			/*// Проверка добавленных проводок
*/
			if(true/*Проводка.Сумма = 0*/)
			{
				//НеДобавлять = Истина;
			}
			/*// Незаконченные проводки с балансовыми счетами не добавляем
*/
			/*НеДобавлять = НеДобавлять ИЛИ 
	(   НЕ Проводка.СчетДт.Забалансовый И НЕ ЗначениеЗаполнено(Проводка.СчетКт)	
	ИЛИ НЕ Проводка.СчетКт.Забалансовый И НЕ ЗначениеЗаполнено(Проводка.СчетДт));*/
			/*// В случае, если проводку добавлять не нужно, удаляем ее из движений
*/
			if(true/*НеДобавлять*/)
			{
				/*// Удаляем добавленную строку
*/
				//СтруктураПараметров["Движения"+ИмяРегистра].Удалить(Проводка);
				/*// Если проводки не добавляются, тогда выход без изменения
*/
			}
			//СтруктураПараметров["ИзмененыДвижения"+ИмяРегистра] = Истина;
		}
		// НачислитьДоходОтРеализации()

		public void СформироватьПроводкиОтклоненийВСтоимостиПриВозвратеПоставщику(/*СтруктураПараметров*/)
		{
			if(true/*СтруктураПараметров.Свойство("ИспользоватьРасширеннуюАналитику")
	  И СтруктураПараметров.ИспользоватьРасширеннуюАналитику
	  И УправлениеЗапасамиПартионныйУчет.ПолучитьПараметрУчетнойПолитикиПартионногоУчета("СистемаНалогообложения", "Бух", СтруктураПараметров) = Перечисления.СистемыНалогообложения.Упрощенная*/)
			{
			}
			//СтоимостьСписания = 0;
			if(true/*СтруктураПараметров.ЕстьСтрокиОтражатьВБухгалтерскомУчете*/)
			{
				if(true/*НЕ СтруктураПараметров.Свойство("СтоимостьСписанияБУ",СтоимостьСписания)*/)
				{
				}
				//СформироватьПроводкиОтклоненийВСтоимостиПриВозвратеБух(СтруктураПараметров, СтоимостьСписания);
			}
			if(true/*СтруктураПараметров.ЕстьСтрокиОтражатьВНалоговомУчете*/)
			{
				if(true/*НЕ СтруктураПараметров.Свойство("СтоимостьСписанияНУ",СтоимостьСписания)*/)
				{
				}
				//СформироватьПроводкиОтклоненийВСтоимостиПриВозвратеНал(СтруктураПараметров, СтоимостьСписания);
			}
		}
		// СформироватьПроводкиОтклоненийВСтоимостиПриВозврате

		public void СформироватьПроводкиОтклоненийВСтоимостиПриВозвратеБух(/*СтруктураПараметров, СтоимостьСписания*/)
		{
			//ВозвратНДС = 0;
			if(true/*НЕ СтруктураПараметров.Свойство("ВозвратНДС",ВозвратНДС)*/)
			{
				//ВозвратНДС = 0;
			}
			//ВозвратНДСВал = 0;
			if(true/*НЕ СтруктураПараметров.Свойство("ВозвратНДСВал",ВозвратНДСВал)*/)
			{
				//ВозвратНДСВал = 0;
			}
			//СуммаОтклонения = СтруктураПараметров.СуммаЗадолженностиБУ - СтруктураПараметров.СтоимостьСписанияБУ - ВозвратНДС;
			//СтоимостьСписанияБУВал = СтруктураПараметров.ТаблицаДвиженийПартииТоваровНаСкладахБух.Итог("ВалютнаяСуммаЗадолженностиБУ");
			//СуммаОтклоненияВал = СтруктураПараметров.СуммаЗадолженностиБУВал - СтоимостьСписанияБУВал - ВозвратНДСВал;
			if(true/*СуммаОтклонения = 0*/)
			{
			}
			//СтруктураРеквизитов = УчетНДС.ПолучитьСтруктуруШапкиДокументаПоСсылке(СтруктураПараметров.Регистратор);
			if(true/*НЕ ЗначениеЗаполнено(СтруктураРеквизитов.СчетУчетаРасходовБУ) Или НЕ ЗначениеЗаполнено(СтруктураРеквизитов.СчетУчетаДоходовБУ)*/)
			{
				/*СтрокаСообщения = "Бухгалтерский учет. Документ " + СтруктураПараметров.Регистратор + ". Не заполнены значения счетов учета доходов и расходов." + Символы.ПС
		+ "Проводка по отклонению в стоимости не сформирована.";*/
				//ОбщегоНазначения.СообщитьОбОшибке(СтрокаСообщения);
			}
			if(true/*НЕ ЗначениеЗаполнено(СтруктураРеквизитов.СчетУчетаРасчетовПоПретензиям)*/)
			{
				//РасчетыПоПретензиям = СтруктураРеквизитов.СчетУчетаРасчетовСКонтрагентом;
			}
			//Проводка = СтруктураПараметров.ДвиженияХозрасчетный.Добавить();
			//Проводка.Период        = СтруктураПараметров.Период;
			//Проводка.Регистратор   = СтруктураПараметров.Регистратор;
			//Проводка.Активность    = Истина;
			//Проводка.Организация   = СтруктураРеквизитов.Организация;
			//Проводка.Содержание = "Отклонение в стоимости номенклатуры";
			/*// Если стоимость списанных партий меньше стоимости по документу
*/
			if(true/*СуммаОтклонения > 0*/)
			{
				//Проводка.СчетДт = РасчетыПоПретензиям;
				//Проводка.СчетКт = СтруктураРеквизитов.СчетУчетаДоходовБУ;
				//Проводка.Сумма  = СуммаОтклонения;
				if(true/*Проводка.СчетДт.Валютный*/)
				{
					//Проводка.ВалютаДт        = СтруктураРеквизитов.ВалютаВзаиморасчетов;
					//Проводка.ВалютнаяСуммаДт = СуммаОтклоненияВал;
				}
			}
			//СтруктураПараметров["ИзмененыДвиженияХозрасчетный"] = Истина;
		}
		// СформироватьПроводкиОтклоненийВСтоимостиПриВозврате

		public void СформироватьПроводкиОтклоненийВСтоимостиПриВозвратеНал(/*СтруктураПараметров, СтоимостьСписания*/)
		{
			//ВозвратНДС = 0;
			if(true/*НЕ СтруктураПараметров.Свойство("ВозвратНДС",ВозвратНДС)*/)
			{
				//ВозвратНДС = 0;
			}
			//СуммаОтклонения = СтруктураПараметров.СуммаЗадолженностиБУ - СтруктураПараметров.СтоимостьСписанияБУ - ВозвратНДС;
			if(true/*СуммаОтклонения = 0*/)
			{
			}
			//СтруктураРеквизитов = Новый Структура("СчетУчетаРасходовНУ, СчетУчетаДоходовНУ, Организация, СтатьяДоходовИРасходов, ДоговорКонтрагента, Контрагент");
			//УправлениеЗапасамиПартионныйУчет.ПолучитьРеквизитыОбъекта(СтруктураПараметров.Регистратор, СтруктураРеквизитов);
			if(true/*НЕ ЗначениеЗаполнено(СтруктураРеквизитов.СчетУчетаРасходовНУ) Или НЕ ЗначениеЗаполнено(СтруктураРеквизитов.СчетУчетаДоходовНУ)*/)
			{
				/*СтрокаСообщения = "Налоговый учет. Документ " + СтруктураПараметров.Регистратор + ". Не заполнены значения счетов учета доходов и расходов." + Символы.ПС
		+ "Проводка по отклонению в стоимости не сформирована.";*/
				//ОбщегоНазначения.СообщитьОбОшибке(СтрокаСообщения);
			}
			//ВидУчетаПВ = ?(СтруктураРеквизитов.СтатьяДоходовИРасходов.ПринятиеКналоговомуУчету, Перечисления.ВидыУчетаПоПБУ18.НУ, Перечисления.ВидыУчетаПоПБУ18.ПР);
			//Проводка = СтруктураПараметров.ДвиженияНалоговый.Добавить();
			//Проводка.Период        = СтруктураПараметров.Период;
			//Проводка.Регистратор   = СтруктураПараметров.Регистратор;
			//Проводка.Активность    = Истина;
			//Проводка.Организация   = СтруктураРеквизитов.Организация;
			//Проводка.Содержание = "Отклонение в стоимости номенклатуры";
			/*// Если стоимость списанных партий меньше стоимости по документу
*/
			if(true/*СуммаОтклонения > 0*/)
			{
				//Проводка.СчетДт = ПланыСчетов.Налоговый.ПоступлениеИВыбытиеИмуществаРаботУслугПрав;
				//Проводка.ВидУчетаДт = ВидУчетаПВ;
				//Проводка.СчетКт = СтруктураРеквизитов.СчетУчетаДоходовНУ;
				//Проводка.Сумма  = СуммаОтклонения;
			}
			//СтруктураПараметров["ИзмененыДвиженияНалоговый"] = Истина;
		}
		// СформироватьПроводкиОтклоненийВСтоимостиПриВозврате

		public void ДвижениеНДС(/*ТаблицаДокументов,ФормироватьПроводки = Истина*/)
		{
			//УчетНДС.ДвижениеНДСпоТаблицеДокументов(ТаблицаДокументов,ФормироватьПроводки);
		}
		////////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ, ФОРМИРУЮЩИЕ СТРУКТУРУ ДАННЫХ ДЛЯ ПЕРЕДАЧИ В РЕГЛ. УЧЕТ

		public void ОпределитьСоставКолонокТаблицаСписанныхПартийБух(/*СтруктураПараметров, СписокИспользуемыхОпераций, СтруктураКолонок*/)
		{
			//УправлениеЗапасамиПартионныйУчет.ОпределитьСоставКолонокТаблицаСписанныхПартийОбщихДляВсехВидовУчета(СтруктураПараметров, СписокИспользуемыхОпераций, СтруктураКолонок);
			//КодыОпераций = СтруктураПараметров.КодыОпераций;
			/*// Колонки базовые
*/
			//СтруктураКолонок.Вставить("СчетУчета");
			//СтруктураКолонок.Вставить("СчетДоходовБУ");
			//СтруктураКолонок.Вставить("СчетРасходовБУ");
			//СтруктураКолонок.Вставить("СчетУчетаБУ");
			//СтруктураКолонок.Вставить("ПринятыеСчетУчетаБУ");
			//СтруктураКолонок.Вставить("КорСчетБУ");
			//СтруктураКолонок.Вставить("ПринятыеКорСчетБУ");
			//СтруктураКолонок.Вставить("КорСубконтоБУ1");
			//СтруктураКолонок.Вставить("КорСубконтоБУ2");
			//СтруктураКолонок.Вставить("КорСубконтоБУ3");
			//СтруктураКолонок.Вставить("СтатьяДоходовИРасходов");
			/*//Колонки с распределенными суммами для НДС
*/
			//СтруктураКолонок.Вставить("СуммаВыручкиБУ");
			//СтруктураКолонок.Вставить("СуммаНДСВыручкиБУ");
			//СтруктураКолонок.Вставить("КоличествоПоступление");
			/*// Колонки по набору условий
*/
			if(true/*не СписокИспользуемыхОпераций.НайтиПоЗначению(КодыОпераций.Реализация ) = неопределено
		ИЛИ не СписокИспользуемыхОпераций.НайтиПоЗначению(КодыОпераций.РеализацияРозница) = неопределено
		ИЛИ не СписокИспользуемыхОпераций.НайтиПоЗначению(КодыОпераций.РеализацияКомиссия) = неопределено
		ИЛИ не СписокИспользуемыхОпераций.НайтиПоЗначению(КодыОпераций.ВозвратПоставщику) = неопределено
		ИЛИ не СписокИспользуемыхОпераций.НайтиПоЗначению(КодыОпераций.ПередачаТарыКонтрагенту) = неопределено
		ИЛИ не СписокИспользуемыхОпераций.НайтиПоЗначению(КодыОпераций.ОтложеннаяОтгрузка) = неопределено
		ИЛИ не СписокИспользуемыхОпераций.НайтиПоЗначению(КодыОпераций.ВозвратОтПокупателя) = неопределено
		ИЛИ не СписокИспользуемыхОпераций.НайтиПоЗначению(КодыОпераций.СписаниеПоИнвентаризации) = неопределено
		ИЛИ не СписокИспользуемыхОпераций.НайтиПоЗначению(КодыОпераций.СписаниеПоОрдеру) = неопределено*/)
			{
				//СтруктураКолонок.Вставить("КорСчетЗадолженностиБУ");
				//СтруктураКолонок.Вставить("КорСубконтоЗадолженностиБУ1");
				//СтруктураКолонок.Вставить("КорСубконтоЗадолженностиБУ2");
				//СтруктураКолонок.Вставить("КорСубконтоЗадолженностиБУ3");
				//СтруктураКолонок.Вставить("ВалютнаяСуммаЗадолженностиБУ");
				//СтруктураКолонок.Вставить("КорВалютаЗадолженностиБУ");
			}
		}

		public void ОпределитьСоставКолонокТаблицаСписанныхПартийНал(/*СтруктураПараметров, СписокИспользуемыхОпераций, СтруктураКолонок*/)
		{
			//УправлениеЗапасамиПартионныйУчет.ОпределитьСоставКолонокТаблицаСписанныхПартийОбщихДляВсехВидовУчета(СтруктураПараметров, СписокИспользуемыхОпераций, СтруктураКолонок);
			/*// Колонки базовые
*/
			//СтруктураКолонок.Вставить("ПринятыеСчетУчетаНУ");
			//СтруктураКолонок.Вставить("СчетДоходовНУ");
			//СтруктураКолонок.Вставить("СчетРасходовНУ");
			//СтруктураКолонок.Вставить("СчетУчетаНУ");
			//СтруктураКолонок.Вставить("КорСчетНУ");
			//СтруктураКолонок.Вставить("ПринятыеКорСчетНУ");
			//СтруктураКолонок.Вставить("КорСубконтоНУ1");
			//СтруктураКолонок.Вставить("КорСубконтоНУ2");
			//СтруктураКолонок.Вставить("КорСубконтоНУ3");
			//СтруктураКолонок.Вставить("КорСубконтоБУ1");
			//СтруктураКолонок.Вставить("КорСубконтоБУ2");
			//СтруктураКолонок.Вставить("КорСубконтоБУ3");
			//СтруктураКолонок.Вставить("ПостояннаяРазница", Новый ОписаниеТипов("Число", Новый КвалификаторыЧисла(15, 2)));
			//СтруктураКолонок.Вставить("ВременнаяРазница", Новый ОписаниеТипов("Число", Новый КвалификаторыЧисла(15, 2)));
			//СтруктураКолонок.Вставить("Период");
		}
	}
}
