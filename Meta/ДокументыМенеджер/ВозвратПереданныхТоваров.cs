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
	///<summary>
	///(Общ)
	///</summary>
	public partial class ВозвратПереданныхТоваров:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ВозвратПереданныхТоваров НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld3609RRef [ВалютаДокумента]
					,_Fld3610RRef [ВидОперации]
					,_Fld3611RRef [ВидПоступления]
					,_Fld3612RRef [ДоговорКонтрагента]
					,_Fld3613_TYPE [Заказ_Тип],_Fld3613_RRRef [Заказ],_Fld3613_RTRef [Заказ_Вид]
					,_Fld3614 [Комментарий]
					,_Fld3615RRef [Контрагент]
					,_Fld3616 [КратностьВзаиморасчетов]
					,_Fld3617 [КурсВзаиморасчетов]
					,_Fld3619RRef [Организация]
					,_Fld3620RRef [Ответственный]
					,_Fld3621 [ОтражатьВБухгалтерскомУчете]
					,_Fld3622 [ОтражатьВНалоговомУчете]
					,_Fld3623 [ОтражатьВУправленческомУчете]
					,_Fld3624_TYPE [СкладОрдер_Тип],_Fld3624_RRRef [СкладОрдер],_Fld3624_RTRef [СкладОрдер_Вид]
					,_Fld3626 [СуммаДокумента]
					,_Fld3627RRef [СчетУчетаРасчетовПоТаре]
					,_Fld3628RRef [ТипЦен]
					From _Document235(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВозвратПереданныхТоваров();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийВозвратТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.ВидПоступления = V82.Перечисления/*Ссылка*/.ВидыПоступленияТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.Комментарий = Читалка.GetString(10);
							Ссылка.КратностьВзаиморасчетов = Читалка.GetDecimal(12);
							Ссылка.КурсВзаиморасчетов = Читалка.GetDecimal(13);
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(22);
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
		
		public static ДокументыСсылка.ВозвратПереданныхТоваров НайтиПоНомеру(string Номер)
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
					,_Fld3609RRef [ВалютаДокумента]
					,_Fld3610RRef [ВидОперации]
					,_Fld3611RRef [ВидПоступления]
					,_Fld3612RRef [ДоговорКонтрагента]
					,_Fld3613_TYPE [Заказ_Тип],_Fld3613_RRRef [Заказ],_Fld3613_RTRef [Заказ_Вид]
					,_Fld3614 [Комментарий]
					,_Fld3615RRef [Контрагент]
					,_Fld3616 [КратностьВзаиморасчетов]
					,_Fld3617 [КурсВзаиморасчетов]
					,_Fld3619RRef [Организация]
					,_Fld3620RRef [Ответственный]
					,_Fld3621 [ОтражатьВБухгалтерскомУчете]
					,_Fld3622 [ОтражатьВНалоговомУчете]
					,_Fld3623 [ОтражатьВУправленческомУчете]
					,_Fld3624_TYPE [СкладОрдер_Тип],_Fld3624_RRRef [СкладОрдер],_Fld3624_RTRef [СкладОрдер_Вид]
					,_Fld3626 [СуммаДокумента]
					,_Fld3627RRef [СчетУчетаРасчетовПоТаре]
					,_Fld3628RRef [ТипЦен]
					From _Document235(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВозвратПереданныхТоваров();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийВозвратТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.ВидПоступления = V82.Перечисления/*Ссылка*/.ВидыПоступленияТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.Комментарий = Читалка.GetString(10);
							Ссылка.КратностьВзаиморасчетов = Читалка.GetDecimal(12);
							Ссылка.КурсВзаиморасчетов = Читалка.GetDecimal(13);
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(22);
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
		
		public static ДокументыВыборка.ВозвратПереданныхТоваров Выбрать()
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
					,_Fld3609RRef [ВалютаДокумента]
					,_Fld3610RRef [ВидОперации]
					,_Fld3611RRef [ВидПоступления]
					,_Fld3612RRef [ДоговорКонтрагента]
					,_Fld3613_TYPE [Заказ_Тип],_Fld3613_RRRef [Заказ],_Fld3613_RTRef [Заказ_Вид]
					,_Fld3614 [Комментарий]
					,_Fld3615RRef [Контрагент]
					,_Fld3616 [КратностьВзаиморасчетов]
					,_Fld3617 [КурсВзаиморасчетов]
					,_Fld3619RRef [Организация]
					,_Fld3620RRef [Ответственный]
					,_Fld3621 [ОтражатьВБухгалтерскомУчете]
					,_Fld3622 [ОтражатьВНалоговомУчете]
					,_Fld3623 [ОтражатьВУправленческомУчете]
					,_Fld3624_TYPE [СкладОрдер_Тип],_Fld3624_RRRef [СкладОрдер],_Fld3624_RTRef [СкладОрдер_Вид]
					,_Fld3626 [СуммаДокумента]
					,_Fld3627RRef [СчетУчетаРасчетовПоТаре]
					,_Fld3628RRef [ТипЦен]
					From _Document235(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ВозвратПереданныхТоваров();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВозвратПереданныхТоваров();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийВозвратТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.ВидПоступления = V82.Перечисления/*Ссылка*/.ВидыПоступленияТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.Комментарий = Читалка.GetString(10);
							Ссылка.КратностьВзаиморасчетов = Читалка.GetDecimal(12);
							Ссылка.КурсВзаиморасчетов = Читалка.GetDecimal(13);
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(22);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ВозвратПереданныхТоваров ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld3609RRef [ВалютаДокумента]
					,_Fld3610RRef [ВидОперации]
					,_Fld3611RRef [ВидПоступления]
					,_Fld3612RRef [ДоговорКонтрагента]
					,_Fld3613_TYPE [Заказ_Тип],_Fld3613_RRRef [Заказ],_Fld3613_RTRef [Заказ_Вид]
					,_Fld3614 [Комментарий]
					,_Fld3615RRef [Контрагент]
					,_Fld3616 [КратностьВзаиморасчетов]
					,_Fld3617 [КурсВзаиморасчетов]
					,_Fld3619RRef [Организация]
					,_Fld3620RRef [Ответственный]
					,_Fld3621 [ОтражатьВБухгалтерскомУчете]
					,_Fld3622 [ОтражатьВНалоговомУчете]
					,_Fld3623 [ОтражатьВУправленческомУчете]
					,_Fld3624_TYPE [СкладОрдер_Тип],_Fld3624_RRRef [СкладОрдер],_Fld3624_RTRef [СкладОрдер_Вид]
					,_Fld3626 [СуммаДокумента]
					,_Fld3627RRef [СчетУчетаРасчетовПоТаре]
					,_Fld3628RRef [ТипЦен]
					From _Document235(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ВозвратПереданныхТоваров();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВозвратПереданныхТоваров();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийВозвратТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.ВидПоступления = V82.Перечисления/*Ссылка*/.ВидыПоступленияТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.Комментарий = Читалка.GetString(10);
							Ссылка.КратностьВзаиморасчетов = Читалка.GetDecimal(12);
							Ссылка.КурсВзаиморасчетов = Читалка.GetDecimal(13);
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(22);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ВозвратПереданныхТоваров ВыбратьПоНомеру(int Первые,string Мин,string Макс)
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
					,_Fld3609RRef [ВалютаДокумента]
					,_Fld3610RRef [ВидОперации]
					,_Fld3611RRef [ВидПоступления]
					,_Fld3612RRef [ДоговорКонтрагента]
					,_Fld3613_TYPE [Заказ_Тип],_Fld3613_RRRef [Заказ],_Fld3613_RTRef [Заказ_Вид]
					,_Fld3614 [Комментарий]
					,_Fld3615RRef [Контрагент]
					,_Fld3616 [КратностьВзаиморасчетов]
					,_Fld3617 [КурсВзаиморасчетов]
					,_Fld3619RRef [Организация]
					,_Fld3620RRef [Ответственный]
					,_Fld3621 [ОтражатьВБухгалтерскомУчете]
					,_Fld3622 [ОтражатьВНалоговомУчете]
					,_Fld3623 [ОтражатьВУправленческомУчете]
					,_Fld3624_TYPE [СкладОрдер_Тип],_Fld3624_RRRef [СкладОрдер],_Fld3624_RTRef [СкладОрдер_Вид]
					,_Fld3626 [СуммаДокумента]
					,_Fld3627RRef [СчетУчетаРасчетовПоТаре]
					,_Fld3628RRef [ТипЦен]
					From _Document235(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ВозвратПереданныхТоваров();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВозвратПереданныхТоваров();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийВозвратТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.ВидПоступления = V82.Перечисления/*Ссылка*/.ВидыПоступленияТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.Комментарий = Читалка.GetString(10);
							Ссылка.КратностьВзаиморасчетов = Читалка.GetDecimal(12);
							Ссылка.КурсВзаиморасчетов = Читалка.GetDecimal(13);
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(22);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ВозвратПереданныхТоваров СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld3609RRef [ВалютаДокумента]
					,_Fld3610RRef [ВидОперации]
					,_Fld3611RRef [ВидПоступления]
					,_Fld3612RRef [ДоговорКонтрагента]
					,_Fld3613_TYPE [Заказ_Тип],_Fld3613_RRRef [Заказ],_Fld3613_RTRef [Заказ_Вид]
					,_Fld3614 [Комментарий]
					,_Fld3615RRef [Контрагент]
					,_Fld3616 [КратностьВзаиморасчетов]
					,_Fld3617 [КурсВзаиморасчетов]
					,_Fld3619RRef [Организация]
					,_Fld3620RRef [Ответственный]
					,_Fld3621 [ОтражатьВБухгалтерскомУчете]
					,_Fld3622 [ОтражатьВНалоговомУчете]
					,_Fld3623 [ОтражатьВУправленческомУчете]
					,_Fld3624_TYPE [СкладОрдер_Тип],_Fld3624_RRRef [СкладОрдер],_Fld3624_RTRef [СкладОрдер_Вид]
					,_Fld3626 [СуммаДокумента]
					,_Fld3627RRef [СчетУчетаРасчетовПоТаре]
					,_Fld3628RRef [ТипЦен]
					From _Document235(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ВозвратПереданныхТоваров();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВозвратПереданныхТоваров();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийВозвратТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.ВидПоступления = V82.Перечисления/*Ссылка*/.ВидыПоступленияТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.Комментарий = Читалка.GetString(10);
							Ссылка.КратностьВзаиморасчетов = Читалка.GetDecimal(12);
							Ссылка.КурсВзаиморасчетов = Читалка.GetDecimal(13);
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(22);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ВозвратПереданныхТоваров СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld3609RRef [ВалютаДокумента]
					,_Fld3610RRef [ВидОперации]
					,_Fld3611RRef [ВидПоступления]
					,_Fld3612RRef [ДоговорКонтрагента]
					,_Fld3613_TYPE [Заказ_Тип],_Fld3613_RRRef [Заказ],_Fld3613_RTRef [Заказ_Вид]
					,_Fld3614 [Комментарий]
					,_Fld3615RRef [Контрагент]
					,_Fld3616 [КратностьВзаиморасчетов]
					,_Fld3617 [КурсВзаиморасчетов]
					,_Fld3619RRef [Организация]
					,_Fld3620RRef [Ответственный]
					,_Fld3621 [ОтражатьВБухгалтерскомУчете]
					,_Fld3622 [ОтражатьВНалоговомУчете]
					,_Fld3623 [ОтражатьВУправленческомУчете]
					,_Fld3624_TYPE [СкладОрдер_Тип],_Fld3624_RRRef [СкладОрдер],_Fld3624_RTRef [СкладОрдер_Вид]
					,_Fld3626 [СуммаДокумента]
					,_Fld3627RRef [СчетУчетаРасчетовПоТаре]
					,_Fld3628RRef [ТипЦен]
					From _Document235(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ВозвратПереданныхТоваров();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВозвратПереданныхТоваров();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийВозвратТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(4));
							Ссылка.ВидПоступления = V82.Перечисления/*Ссылка*/.ВидыПоступленияТоваров.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.Комментарий = Читалка.GetString(10);
							Ссылка.КратностьВзаиморасчетов = Читалка.GetDecimal(12);
							Ссылка.КурсВзаиморасчетов = Читалка.GetDecimal(13);
							Ссылка.ОтражатьВБухгалтерскомУчете = ((byte[])Читалка.GetValue(16))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(17))[0]==1;
							Ссылка.ОтражатьВУправленческомУчете = ((byte[])Читалка.GetValue(18))[0]==1;
							Ссылка.СуммаДокумента = Читалка.GetDecimal(22);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ВозвратПереданныхТоваров СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ВозвратПереданныхТоваров();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			Объект.ВидОперации = V82.Перечисления/*Ссылка*/.ВидыОперацийВозвратТоваров.ПустаяСсылка;
			Объект.ВидПоступления = V82.Перечисления/*Ссылка*/.ВидыПоступленияТоваров.ПустаяСсылка;
			return Объект;
		}
	}
}