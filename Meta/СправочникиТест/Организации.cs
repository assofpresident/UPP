
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиТест
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class Организации: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника Организации. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.Организации.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,9);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,50);//"Наименование " + НомерЭлемента;

				Объект.Префикс = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3);
				Объект.ИНН = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,12);
				Объект.КПП = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,9);
				Объект.РегистрационныйНомерПФР = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,14);
				Объект.ГоловнаяОрганизация = V82.Справочники/*Менеджер*/.Организации.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Организации();
				Объект.НаименованиеПолное = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.КодПоОКПО = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,10);
				Объект.КодПоОКАТО = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,11);
				Объект.КодИМНС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,4);
				Объект.РайонныйКоэффициент = ГенераторСлучайныхЧисел.Следующий(999);
				Объект.ЮрФизЛицо = (V82.Перечисления/*Ссылка*/.ЮрФизЛицо)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ЮрФизЛицо));
				Объект.ТерриториальныеУсловияПФР = V82.Справочники/*Менеджер*/.ТерриториальныеУсловия.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ТерриториальныеУсловия();
				Объект.ОсновнойБанковскийСчет = V82.Справочники/*Менеджер*/.БанковскиеСчета.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.БанковскиеСчета();
				Объект.ВидСтавокЕСНиПФР = (V82.Перечисления/*Ссылка*/.ВидыСтавокЕСНиПФР)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыСтавокЕСНиПФР));
				Объект.НаименованиеПлательщикаПриПеречисленииНалогов = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,150);
				Объект.ИностраннаяОрганизация = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ДатаРегистрации = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.КодОКОПФ = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,2);
				Объект.НаименованиеОКОПФ = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,254);
				Объект.КодОКФС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,2);
				Объект.НаименованиеОКФС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,254);
				Объект.СвидетельствоСерияНомер = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,25);
				Объект.СвидетельствоДатаВыдачи = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.СвидетельствоНаименованиеОргана = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,254);
				Объект.СвидетельствоКодОргана = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,4);
				Объект.СтранаРегистрации = V82.Справочники/*Менеджер*/.КлассификаторСтранМира.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.КлассификаторСтранМира();
				Объект.СтранаПостоянногоМестонахождения = V82.Справочники/*Менеджер*/.КлассификаторСтранМира.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.КлассификаторСтранМира();
				Объект.КодВСтранеРегистрации = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,50);
				Объект.ОГРН = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,15);
				Объект.НаименованиеИнострОрганизации = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,254);
				Объект.РегистрационныйНомерФСС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,14);
				Объект.НаименованиеИМНС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,254);
				Объект.КодОКВЭД = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,8);
				Объект.НаименованиеОКВЭД = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,254);
				Объект.КодОКОНХ = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,5);
				Объект.ИндивидуальныйПредприниматель = V82.Справочники/*Менеджер*/.ФизическиеЛица.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ФизическиеЛица();
				Объект.УдалитьОбменЗадействован = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОбменКодАбонента = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,7);
				Объект.ОбменКаталогОтправкиДанныхОтчетности = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.ОбменКаталогПрограммыЭлектроннойПочты = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,255);
				Объект.РайонныйКоэффициентРФ = ГенераторСлучайныхЧисел.Следующий(999);
				Объект.ОтражатьВРегламентированномУчете = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.КодИФНСПолучателя = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,4);
				Объект.НаименованиеТерриториальногоОрганаПФР = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,100);
				Объект.НаименованиеСокращенное = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,160);
				Объект.ВидОбменаСКонтролирующимиОрганами = (V82.Перечисления/*Ссылка*/.ВидыОбменаСКонтролирующимиОрганами)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыОбменаСКонтролирующимиОрганами));
				Объект.УчетнаяЗаписьОбмена = V82.Справочники/*Менеджер*/.УчетныеЗаписиДокументооборота.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.УчетныеЗаписиДокументооборота();
				Объект.КодОрганаПФР = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,7);
				Объект.КодОрганаФСГС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,5);
				Объект.ДополнительныйКодФСС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,14);
				Объект.КодПодчиненностиФСС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,5);
				Объект.ЦифровойИндексОбособленногоПодразделения = ГенераторСлучайныхЧисел.Следующий(99999);
				Объект.РегистрационныйНомерТФОМС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,15);
				Объект.ИПРегистрационныйНомерПФР = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,14);
				Объект.ИПРегистрационныйНомерФСС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,10);
				Объект.ИПКодПодчиненностиФСС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,5);
				Объект.ИПРегистрационныйНомерТФОМС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,15);
				Объект.НаименованиеТерриториальногоОрганаФСС = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,135);

				Объект.Записать();
				Console.Write("Выполнено: " + НомерЭлемента*.1 + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void Удалить1000()
		{
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.Организации.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника Организации. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.Организации.Выбрать())
				{
					НомерЭлемента++;
					Ссылка.СериализацияProtoBuf(Поток);
					Console.Write("Выполнено: " + НомерЭлемента*.1 + "%.");
					Console.CursorLeft = 0;
				}
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void СериализацияJson1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияJson 1000 элементов справочника Организации. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.Организации.Выбрать())
			{
				НомерЭлемента++;
				Ссылка.СериализацияJson();
				Console.Write("Выполнено: " + НомерЭлемента*.1 + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}
	}
}