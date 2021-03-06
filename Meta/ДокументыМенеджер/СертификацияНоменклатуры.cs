﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.ДокументыСсылка;
using V82.Документы;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Документы//Менеджер
{
	public partial class СертификацияНоменклатуры:ДокументМенеджер
	{
		
		public static ДокументыСсылка.СертификацияНоменклатуры НайтиПоСсылке(Guid _Ссылка)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld11477RRef [ВидОперации]
					,_Fld11478 [ДатаНачалаИспытаний]
					,_Fld11479 [ДатаОкончанияИспытаний]
					,_Fld11480 [ДатаСертификата]
					,_Fld11481_TYPE [ДокументОснование_Тип],_Fld11481_RRRef [ДокументОснование],_Fld11481_RTRef [ДокументОснование_Вид]
					,_Fld11482 [Заключение]
					,_Fld11483 [Комментарий]
					,_Fld11484RRef [Номенклатура]
					,_Fld11485 [НомерСертификата]
					,_Fld11486RRef [НормативныйДокумент]
					,_Fld11487RRef [Организация]
					,_Fld11488RRef [ОрганПоСертификации]
					,_Fld11489RRef [Ответственный]
					,_Fld11490RRef [Подразделение]
					,_Fld11491RRef [РезультатСертификации]
					,_Fld11492RRef [СерияНоменклатуры]
					,_Fld11493 [СрокГодностиСертификата]
					From _Document451(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СертификацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийСертификацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаНачалаИспытаний = Читалка.GetDateTime(4);
							Ссылка.ДатаОкончанияИспытаний = Читалка.GetDateTime(5);
							Ссылка.ДатаСертификата = Читалка.GetDateTime(6);
							Ссылка.Заключение = Читалка.GetString(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерСертификата = Читалка.GetString(13);
							Ссылка.РезультатСертификации = V82.Перечисления/*Ссылка*/.РезультатыСертификацииНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.СрокГодностиСертификата = Читалка.GetDateTime(21);
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static ДокументыСсылка.СертификацияНоменклатуры НайтиПоНомеру(string Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld11477RRef [ВидОперации]
					,_Fld11478 [ДатаНачалаИспытаний]
					,_Fld11479 [ДатаОкончанияИспытаний]
					,_Fld11480 [ДатаСертификата]
					,_Fld11481_TYPE [ДокументОснование_Тип],_Fld11481_RRRef [ДокументОснование],_Fld11481_RTRef [ДокументОснование_Вид]
					,_Fld11482 [Заключение]
					,_Fld11483 [Комментарий]
					,_Fld11484RRef [Номенклатура]
					,_Fld11485 [НомерСертификата]
					,_Fld11486RRef [НормативныйДокумент]
					,_Fld11487RRef [Организация]
					,_Fld11488RRef [ОрганПоСертификации]
					,_Fld11489RRef [Ответственный]
					,_Fld11490RRef [Подразделение]
					,_Fld11491RRef [РезультатСертификации]
					,_Fld11492RRef [СерияНоменклатуры]
					,_Fld11493 [СрокГодностиСертификата]
					From _Document451(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СертификацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийСертификацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаНачалаИспытаний = Читалка.GetDateTime(4);
							Ссылка.ДатаОкончанияИспытаний = Читалка.GetDateTime(5);
							Ссылка.ДатаСертификата = Читалка.GetDateTime(6);
							Ссылка.Заключение = Читалка.GetString(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерСертификата = Читалка.GetString(13);
							Ссылка.РезультатСертификации = V82.Перечисления/*Ссылка*/.РезультатыСертификацииНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.СрокГодностиСертификата = Читалка.GetDateTime(21);
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static ДокументыВыборка.СертификацияНоменклатуры Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld11477RRef [ВидОперации]
					,_Fld11478 [ДатаНачалаИспытаний]
					,_Fld11479 [ДатаОкончанияИспытаний]
					,_Fld11480 [ДатаСертификата]
					,_Fld11481_TYPE [ДокументОснование_Тип],_Fld11481_RRRef [ДокументОснование],_Fld11481_RTRef [ДокументОснование_Вид]
					,_Fld11482 [Заключение]
					,_Fld11483 [Комментарий]
					,_Fld11484RRef [Номенклатура]
					,_Fld11485 [НомерСертификата]
					,_Fld11486RRef [НормативныйДокумент]
					,_Fld11487RRef [Организация]
					,_Fld11488RRef [ОрганПоСертификации]
					,_Fld11489RRef [Ответственный]
					,_Fld11490RRef [Подразделение]
					,_Fld11491RRef [РезультатСертификации]
					,_Fld11492RRef [СерияНоменклатуры]
					,_Fld11493 [СрокГодностиСертификата]
					From _Document451(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.СертификацияНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СертификацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийСертификацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаНачалаИспытаний = Читалка.GetDateTime(4);
							Ссылка.ДатаОкончанияИспытаний = Читалка.GetDateTime(5);
							Ссылка.ДатаСертификата = Читалка.GetDateTime(6);
							Ссылка.Заключение = Читалка.GetString(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерСертификата = Читалка.GetString(13);
							Ссылка.РезультатСертификации = V82.Перечисления/*Ссылка*/.РезультатыСертификацииНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.СрокГодностиСертификата = Читалка.GetDateTime(21);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.СертификацияНоменклатуры ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld11477RRef [ВидОперации]
					,_Fld11478 [ДатаНачалаИспытаний]
					,_Fld11479 [ДатаОкончанияИспытаний]
					,_Fld11480 [ДатаСертификата]
					,_Fld11481_TYPE [ДокументОснование_Тип],_Fld11481_RRRef [ДокументОснование],_Fld11481_RTRef [ДокументОснование_Вид]
					,_Fld11482 [Заключение]
					,_Fld11483 [Комментарий]
					,_Fld11484RRef [Номенклатура]
					,_Fld11485 [НомерСертификата]
					,_Fld11486RRef [НормативныйДокумент]
					,_Fld11487RRef [Организация]
					,_Fld11488RRef [ОрганПоСертификации]
					,_Fld11489RRef [Ответственный]
					,_Fld11490RRef [Подразделение]
					,_Fld11491RRef [РезультатСертификации]
					,_Fld11492RRef [СерияНоменклатуры]
					,_Fld11493 [СрокГодностиСертификата]
					From _Document451(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.СертификацияНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СертификацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийСертификацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаНачалаИспытаний = Читалка.GetDateTime(4);
							Ссылка.ДатаОкончанияИспытаний = Читалка.GetDateTime(5);
							Ссылка.ДатаСертификата = Читалка.GetDateTime(6);
							Ссылка.Заключение = Читалка.GetString(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерСертификата = Читалка.GetString(13);
							Ссылка.РезультатСертификации = V82.Перечисления/*Ссылка*/.РезультатыСертификацииНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.СрокГодностиСертификата = Читалка.GetDateTime(21);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.СертификацияНоменклатуры ВыбратьПоНомеру(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld11477RRef [ВидОперации]
					,_Fld11478 [ДатаНачалаИспытаний]
					,_Fld11479 [ДатаОкончанияИспытаний]
					,_Fld11480 [ДатаСертификата]
					,_Fld11481_TYPE [ДокументОснование_Тип],_Fld11481_RRRef [ДокументОснование],_Fld11481_RTRef [ДокументОснование_Вид]
					,_Fld11482 [Заключение]
					,_Fld11483 [Комментарий]
					,_Fld11484RRef [Номенклатура]
					,_Fld11485 [НомерСертификата]
					,_Fld11486RRef [НормативныйДокумент]
					,_Fld11487RRef [Организация]
					,_Fld11488RRef [ОрганПоСертификации]
					,_Fld11489RRef [Ответственный]
					,_Fld11490RRef [Подразделение]
					,_Fld11491RRef [РезультатСертификации]
					,_Fld11492RRef [СерияНоменклатуры]
					,_Fld11493 [СрокГодностиСертификата]
					From _Document451(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.СертификацияНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СертификацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийСертификацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаНачалаИспытаний = Читалка.GetDateTime(4);
							Ссылка.ДатаОкончанияИспытаний = Читалка.GetDateTime(5);
							Ссылка.ДатаСертификата = Читалка.GetDateTime(6);
							Ссылка.Заключение = Читалка.GetString(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерСертификата = Читалка.GetString(13);
							Ссылка.РезультатСертификации = V82.Перечисления/*Ссылка*/.РезультатыСертификацииНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.СрокГодностиСертификата = Читалка.GetDateTime(21);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.СертификацияНоменклатуры СтраницаПоСсылке(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld11477RRef [ВидОперации]
					,_Fld11478 [ДатаНачалаИспытаний]
					,_Fld11479 [ДатаОкончанияИспытаний]
					,_Fld11480 [ДатаСертификата]
					,_Fld11481_TYPE [ДокументОснование_Тип],_Fld11481_RRRef [ДокументОснование],_Fld11481_RTRef [ДокументОснование_Вид]
					,_Fld11482 [Заключение]
					,_Fld11483 [Комментарий]
					,_Fld11484RRef [Номенклатура]
					,_Fld11485 [НомерСертификата]
					,_Fld11486RRef [НормативныйДокумент]
					,_Fld11487RRef [Организация]
					,_Fld11488RRef [ОрганПоСертификации]
					,_Fld11489RRef [Ответственный]
					,_Fld11490RRef [Подразделение]
					,_Fld11491RRef [РезультатСертификации]
					,_Fld11492RRef [СерияНоменклатуры]
					,_Fld11493 [СрокГодностиСертификата]
					From _Document451(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.СертификацияНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СертификацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийСертификацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаНачалаИспытаний = Читалка.GetDateTime(4);
							Ссылка.ДатаОкончанияИспытаний = Читалка.GetDateTime(5);
							Ссылка.ДатаСертификата = Читалка.GetDateTime(6);
							Ссылка.Заключение = Читалка.GetString(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерСертификата = Читалка.GetString(13);
							Ссылка.РезультатСертификации = V82.Перечисления/*Ссылка*/.РезультатыСертификацииНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.СрокГодностиСертификата = Читалка.GetDateTime(21);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.СертификацияНоменклатуры СтраницаПоНомеру(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld11477RRef [ВидОперации]
					,_Fld11478 [ДатаНачалаИспытаний]
					,_Fld11479 [ДатаОкончанияИспытаний]
					,_Fld11480 [ДатаСертификата]
					,_Fld11481_TYPE [ДокументОснование_Тип],_Fld11481_RRRef [ДокументОснование],_Fld11481_RTRef [ДокументОснование_Вид]
					,_Fld11482 [Заключение]
					,_Fld11483 [Комментарий]
					,_Fld11484RRef [Номенклатура]
					,_Fld11485 [НомерСертификата]
					,_Fld11486RRef [НормативныйДокумент]
					,_Fld11487RRef [Организация]
					,_Fld11488RRef [ОрганПоСертификации]
					,_Fld11489RRef [Ответственный]
					,_Fld11490RRef [Подразделение]
					,_Fld11491RRef [РезультатСертификации]
					,_Fld11492RRef [СерияНоменклатуры]
					,_Fld11493 [СрокГодностиСертификата]
					From _Document451(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.СертификацияНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.СертификацияНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийСертификацияНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(3));
							Ссылка.ДатаНачалаИспытаний = Читалка.GetDateTime(4);
							Ссылка.ДатаОкончанияИспытаний = Читалка.GetDateTime(5);
							Ссылка.ДатаСертификата = Читалка.GetDateTime(6);
							Ссылка.Заключение = Читалка.GetString(10);
							Ссылка.Комментарий = Читалка.GetString(11);
							Ссылка.НомерСертификата = Читалка.GetString(13);
							Ссылка.РезультатСертификации = V82.Перечисления/*Ссылка*/.РезультатыСертификацииНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Ссылка.СрокГодностиСертификата = Читалка.GetDateTime(21);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.СертификацияНоменклатуры СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.СертификацияНоменклатуры();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Заключение = "";
			Объект.Комментарий = "";
			Объект.НомерСертификата = "";
			Объект.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийСертификацияНоменклатуры.ПустаяСсылка;
			Объект.РезультатСертификации = V82.Перечисления/*Ссылка*/.РезультатыСертификацииНоменклатуры.ПустаяСсылка;
			return Объект;
		}
	}
}