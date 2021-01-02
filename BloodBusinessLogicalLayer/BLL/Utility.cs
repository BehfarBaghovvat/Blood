using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class Utility
	{
		#region Properties
		//================
		private static string[] formatEmail1 = new string[4];
		public static string RegisterDate { get; set; }
		public static string RegisterTime { get; set; }
		private static bool Status { get; set; }
		private static bool TrueStatus { get; set; }
		//====================
		#endregion /Properties

		//-----Beginig of the code.

		#region ADCalendar
		/// <summary>
		/// AD calendar with month names...
		/// </summary>
		/// <returns></returns>
		public static string ADCalendar()
		{
			string adCalendar;
			string nameMonth = string.Empty;

			System.Globalization.GregorianCalendar gregorianCalendar =
				new System.Globalization.GregorianCalendar();

			int years = gregorianCalendar.GetYear(System.DateTime.Now);
			int months = gregorianCalendar.GetMonth(System.DateTime.Now);
			int day = gregorianCalendar.GetDayOfMonth(System.DateTime.Now);

			switch (months)
			{
				case 1:
					nameMonth = "January";
					break;
				case 2:
					nameMonth = "February";
					break;
				case 3:
					nameMonth = "March";
					break;
				case 4:
					nameMonth = "April";
					break;
				case 5:
					nameMonth = "May";
					break;
				case 6:
					nameMonth = "June";
					break;
				case 7:
					nameMonth = "Julay";
					break;
				case 8:
					nameMonth = "August";
					break;
				case 9:
					nameMonth = "September";
					break;
				case 10:
					nameMonth = "October";
					break;
				case 11:
					nameMonth = "November";
					break;
				case 12:
					nameMonth = "Decemder";
					break;

				default:
					break;
			}

			adCalendar =
				nameMonth + " / " +
				day.ToString().PadLeft(2, '0') + " / " +
				years.ToString();

			return adCalendar;

		}

		#endregion /ADCalendar

		#region ADCalendar
		/// <summary>
		/// This function has an input value that is the date of your device's system.
		/// So try to keep your system up to date.
		/// </summary>
		/// <param name="dateTime"></param>
		/// <returns>Gregorian date</returns>
		public static string ADCalendar(System.DateTime dateTime)
		{
			string adCalendar;

			System.Globalization.GregorianCalendar gregorianCalendar =
				new System.Globalization.GregorianCalendar();

			int years = gregorianCalendar.GetYear(dateTime);
			int months = gregorianCalendar.GetMonth(dateTime);
			int day = gregorianCalendar.GetDayOfMonth(dateTime);

			adCalendar =
				months.ToString().PadLeft(2, '0') + " / " +
				day.ToString().PadLeft(2, '0') + " / " +
				years.ToString();

			return adCalendar;

		}
		#endregion /ADCalendar			

		#region EmailChecker1
		/// <summary>
		/// Check incoming emails.
		/// According to the defined templates, if the input email is not correct,
		/// the appropriate message will be displayed
		/// </summary>
		/// <param name="email"></param>
		/// <returns>A Bool value is returned to confirm the email</returns>
		//public static bool EmailChecker1(string email)
		//{
		//	formatEmail1[0] = ".com";
		//	formatEmail1[1] = ".org";
		//	formatEmail1[2] = ".ir";
		//	formatEmail1[3] = ".net";

		//	if ((email).Contains("@") == true)
		//	{
		//		for (int i = 0; i < formatEmail1.Length; i++)
		//		{
		//			Status = email.EndsWith(formatEmail1[i]);

		//			if (Status == true)
		//			{
		//				TrueStatus = Status;
		//				break;
		//			}
		//			else if (Status == false)
		//			{
		//				Mbb.Windows.Forms.MessageBox.Show
		//			(text: "عدم همخوانی قالب ایمیل!",
		//			caption: "خطای ورودی",
		//			icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
		//			button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
		//				TrueStatus = Status;
		//				break;
		//			}
		//		}
		//	}
		//	else
		//	{
		//		Mbb.Windows.Forms.MessageBox.Show
		//			(text: "عدم همخوانی قالب ایمیل!",
		//			caption: "خطای ورودی",
		//			icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
		//			button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

		//		TrueStatus = false;
		//	}

		//	return TrueStatus;
		//}
		#endregion /EmailChecker1

		#region EmailChecker
		/// <summary>
		/// Check incoming emails.
		/// According to the defined templates, if the input email is not correct,
		/// the appropriate message will be displayed
		/// </summary>
		/// <param name="email"></param>
		/// <returns>A Bool value is returned to confirm the email</returns>
		public static bool EmailChecker(string email)
		{
			formatEmail1[0] = ".com";
			formatEmail1[1] = ".org";
			formatEmail1[2] = ".ir";
			formatEmail1[3] = ".net";

			if ((email).Contains("@") == true)
			{
				for (int i = 0; i < formatEmail1.Length; i++)
				{
					Status = email.EndsWith(formatEmail1[i]);

					if (Status == true)
					{
						TrueStatus = Status;
						break;
					}
					else if (Status == false)
					{
						TrueStatus = Status;
						break;
					}
				}
			}
			else
			{
				TrueStatus = false;
			}

			return TrueStatus;
		}
		#endregion /EmailChecker		

		#region EnglishAndNumberTyping
		/// <summary>
		/// It is a function that allows only English and numeric characters to be typed while typing.
		/// </summary>
		/// <param name="e"></param>
		public static void EnglishAndNumberTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'آ' && e.KeyChar <= 'ی'))
			{
				e.Handled = true;
			}
		}
		#endregion EnglishAndNumberTyping

		#region EnglishLanguage
		/// <summary>
		/// Function to change Persian to English
		/// </summary>
		public static void EnglishLanguage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture =
				new System.Globalization.CultureInfo("en-us");

			System.Threading.Thread.CurrentThread.CurrentUICulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			System.Windows.Forms.InputLanguage.CurrentInputLanguage =
				System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-us"));
		}
		#endregion /EnglishLanguage

		#region EnglishTyping
		/// <summary>
		/// A function used to type English
		/// </summary>
		/// <param name="e"></param>
		public static void EnglishTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'آ' && e.KeyChar <= 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
			{
				e.Handled = true;
			}
		}
		#endregion /EnglishTyping

		#region EventLog
		/// <summary>
		/// ---- تمام فعالیتهایی که توسط متصدی صورت گرفته است ثبت میگردد!
		/// </summary>
		/// <param name="username"></param>
		/// <param name="fullName"></param>
		/// <param name="eventRegisterDate"></param>
		/// <param name="eventTitle"></param>
		//public static void EventLog(string username, string fullName, string eventDate, string eventTime, string eventTitle)
		//{
		//	if (string.Compare(username, "administrator") == 0)//-----اگر شناسه کاربری برابر با administrator باشد یعنی در حال حاضر حساب مدیریت وارد سیستم شده
		//	{
		//		return;
		//	}
		//	else //----- در غیر این صورت سایر حسابها وارد سیستم شده اند.
		//	{
		//		Models.DataBaseContext dataBaseContext = null;
		//		try
		//		{
		//			dataBaseContext =
		//				new Models.DataBaseContext();

		//			Models.EventLog eventLog =
		//				dataBaseContext.EventLogs
		//				.OrderByDescending(current => current.Event_Date)
		//				.OrderByDescending(current => current.Event_Time)
		//				.FirstOrDefault();

		//			eventLog =
		//			   new Models.EventLog()
		//			   {
		//				   Username = username,
		//				   Full_Name = fullName,
		//				   Event_Date = eventDate,
		//				   Event_Time = eventTime,
		//				   Event_Title = eventTitle,

		//			   };
		//			dataBaseContext.EventLogs.Add(eventLog);
		//			dataBaseContext.SaveChanges();
		//		}
		//		catch (System.Exception ex)
		//		{
		//			Infrastructure.Utility.ExceptionShow(ex);
		//		}
		//		finally
		//		{
		//			if (dataBaseContext != null)
		//			{
		//				dataBaseContext.Dispose();
		//				dataBaseContext = null;
		//			}
		//		}
		//	}
		//}
		#endregion /EventLog	

		#region GeneratInvoiceSerialNumber
		/// <summary>
		/// تابعی که به تعداد 7 کاراکتر حروف و عدد به صورت تصادوفی
		///  و ترکیبی ایجاد کرده و به ما بر میگرداند.
		/// </summary>
		/// <returns>ممبر letter که حاصل دریافت ترکیبی عدد و حرف میباشد نتیجه این تابع میباشد. </returns>
		public static string GeneratInvoiceSerialNumber()
		{
			int count, number1, number2;

			string[] text = new string[3];
			string letter = string.Empty;

			System.Random randomCount = new System.Random();
			System.Random randomNumber = new System.Random();
			System.Random random = new System.Random();

			for (int i = 1; i <= 20; i++)
			{
				count = randomCount.Next(0, 2);

				if (count == 0)
				{
					number1 = randomNumber.Next(0, 10);
					letter += number1.ToString();
				}
				else if (count == 1)
				{
					for (int k = 0; k < 1; k++)
					{
						number2 = random.Next(65, 91);
						text[k] = System.Convert.ToChar(number2).ToString();
						letter += text[k];
					}
				}
			}

			for (int i = 1; i < 21; i++)
			{
				if (i % 6 == 0)
				{
					letter = letter.Insert(i - 1, "-");
				}
			}
			return letter;
		}
		#endregion /GeneratInvoiceSerialNumber

		#region GeneratInvoiceIDNumber
		/// <summary>
		/// تابعی که 4 عدد تصادفی تولید و در قالب یک رشته بر میگرداند
		/// این تابع جهت تولید سریال فاکتور می باشد. 
		/// </summary>
		/// <returns><returns>
		public static string GeneratInvoiceIDNumber()
		{
			System.Random generator = new System.Random();
			string letter = string.Empty;

			//Generate 10 random numbers

			letter = generator.Next(1000, 9999).ToString();

			return letter;
		}
		#endregion /GeneratInvoiceIDNumber	

		#region InsertDcimalNumbers
		/// <summary>
		/// Function for inserting decimal numbers
		/// </summary>
		/// <param name="e"></param>
		/// <param name="text"></param>
		public static void InsertDcimalNumbers(System.Windows.Forms.KeyPressEventArgs e, string text)
		{
			char ch = e.KeyChar;

			if (ch == 47 && text.IndexOf('/') != -1)
			{
				e.Handled = true;
				return;
			}

			if (!char.IsDigit(ch) && ch != 8 && ch != 47)
			{
				e.Handled = true;
			}
		}
		#endregion /InsertDcimalNumbers

		#region InsertOnlyNumber
		/// <summary>
		/// A function used to type a Number
		/// </summary>
		/// <param name="e"></param>
		public static void InsertOnlyNumber(System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}
		#endregion /InsertOnlyNumber

		#region PasswordSet
		/// <summary>
		/// This function will be used when you want to make sure that the two passwords are correct.
		/// </summary>
		/// <param name="password"></param>
		/// <param name="passwordConfirm"></param>
		/// <returns>The return value is a boolean value</returns>
		public static bool PasswordSet(string password, string passwordConfirm)
		{
			bool statusPawword;
			if (string.Compare(password, passwordConfirm, true) == 0)
			{
				statusPawword = true;
			}
			else
			{
				statusPawword = false;
			}
			return statusPawword;
		}
		#endregion /PasswordSet	

		#region PersianAndNumberTyping
		/// <summary>
		/// A function used to type Farsi
		/// </summary>
		/// <param name="e"></param>
		public static void PersianAndNumberTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'a' && e.KeyChar <= 'z') || (e.KeyChar > 'A' && e.KeyChar <= 'Z'))
			{
				e.Handled = true;
			}
		}
		#endregion /PersianAndNumberTyping

		#region PersianCalendar
		/// <summary>
		/// View Persian calendar with month names.
		/// </summary>
		/// <returns></returns>
		public static string PersianCalendar()
		{
			string farsiCalendar;
			string nameMonth = string.Empty;

			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int years = persianCalendar.GetYear(System.DateTime.Now);
			int month = persianCalendar.GetMonth(System.DateTime.Now);
			int day = persianCalendar.GetDayOfMonth(System.DateTime.Now);

			switch (month)
			{
				case 1:
					nameMonth = "فروردین";
					break;
				case 2:
					nameMonth = "اردیبهشت";
					break;
				case 3:
					nameMonth = "خرداد";
					break;
				case 4:
					nameMonth = "تیر";
					break;
				case 5:
					nameMonth = "مرداد";
					break;
				case 6:
					nameMonth = "شهریور";
					break;
				case 7:
					nameMonth = "مهر";
					break;
				case 8:
					nameMonth = "آبان";
					break;
				case 9:
					nameMonth = "آذر";
					break;
				case 10:
					nameMonth = "دی";
					break;
				case 11:
					nameMonth = "بهمن";
					break;
				case 12:
					nameMonth = "اسفند";
					break;

				default:
					break;
			}

			farsiCalendar =
				day.ToString().PadLeft(2, '0') + " / " + nameMonth + " / " + years.ToString();

			return farsiCalendar;
		}
		#endregion /PersianCalendar

		#region PersianCalendar
		/// <summary>
		/// View Persian Calendar.
		/// </summary>
		/// <param name="dateTime">Calendar entry</param>
		/// <returns></returns>
		public static string PersianCalendar(System.DateTime dateTime)
		{
			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(dateTime);
			int month = persianCalendar.GetMonth(dateTime);
			int day = persianCalendar.GetDayOfMonth(dateTime);

			string showCalendar =
				year.ToString() + "/" +
				month.ToString().PadLeft(2, '0') + "/" +
				day.ToString().PadLeft(2, '0');

			return showCalendar;
		}
		#endregion / PersianCalendar

		#region PersianLanguage
		/// <summary>
		/// زبان جاری ویندوز به فارسی تبدیل میشود!
		/// </summary>
		public static void PersianLanguage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture =
				new System.Globalization.CultureInfo("fa-ir");

			System.Threading.Thread.CurrentThread.CurrentUICulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			System.Windows.Forms.InputLanguage.CurrentInputLanguage =
				System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("fa-ir"));
		}
		#endregion /PersianLanguage

		#region PersianTyping
		/// <summary>
		/// فقط تایپ فارسی
		/// </summary>
		/// <param name="e"></param>
		public static void PersianTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'a' && e.KeyChar <= 'z') || (e.KeyChar > 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
			{
				e.Handled = true;
			}
		}
		#endregion /PersianTyping				

		#region TextFixed
		/// <summary>
		/// A function that removes the excess distance of a text from both sides.
		/// </summary>
		/// <param name="text"></param>
		/// <returns>The output is a spaceless text.</returns>
		public static string TextFixed(string text)
		{
			if (text == null)
			{
				return string.Empty;
			}

			text.Trim();

			if (text == string.Empty)
			{
				return string.Empty;
			}

			while (text == "  ")
			{
				text =
					text.Replace("  ", " ");
			}
			return text;
		}
		#endregion

		#region UserCheck1
		/// <summary>
		/// This function can be used to create a username with a specific form.
		/// This function allows you to have two digits of your username.
		/// </summary>
		/// <param name="text"></param>
		/// <returns>The output value is a boolean value.</returns>
		public static bool UserCheck1(string username)
		{
			int length = username.Length;
			int num = 0;
			string[] textAray = new string[length];
			string firstValue;

			bool statusCheck;

			for (int i = 0; i <= length - 1; i++)
			{
				textAray[i] = username.Substring(i, 1);
			}

			for (int i = 0; i <= length - 1; i++)
			{
				firstValue = textAray[i];

				for (int y = 0; y <= 9; y++)
				{
					if (string.Compare(firstValue, y.ToString(), false) == 0)
					{
						num++;
					}
				}
			}

			if (num < 2)
			{
				ShafaCommon.Common.MessageManager.ShowMessageBox
					(text: "نام کاربری باید دارای حداقل 2 عدد باشد!",
					caption: "خطای ورودی",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Error);

				statusCheck = false;
			}
			else
			{
				statusCheck = true;
			}

			return statusCheck;
		}
		#endregion /UserCheck1

		#region UserCheck2
		/// <summary>
		/// This function can be used to create a username with a specific form.
		/// This function allows you to have two digits of your username.
		/// </summary>
		/// <param name="text"></param>
		/// <returns>The output value is a boolean value.</returns>
		public static bool UserCheck2(string username)
		{
			int length = username.Length;
			int num = 0;
			string[] textAray = new string[length];
			string firstValue;

			bool statusCheck;

			for (int i = 0; i <= length - 1; i++)
			{
				textAray[i] = username.Substring(i, 1);
			}

			for (int i = 0; i <= length - 1; i++)
			{
				firstValue = textAray[i];

				for (int y = 0; y <= 9; y++)
				{
					if (string.Compare(firstValue, y.ToString(), false) == 0)
					{
						num++;
					}
				}
			}

			if (num < 2)
			{
				statusCheck = false;
			}
			else
			{
				statusCheck = true;
			}

			return statusCheck;
		}
		#endregion /UserCheck2

		#region SaveLogOutTime
		//public static void SaveLogOutTime(Models.LogHistory log)
		//{
		//	string logOutTime = null;
		//	Models.DataBaseContext dataBaseContext = null;
		//	try
		//	{
		//		dataBaseContext =
		//			new Models.DataBaseContext();

		//		Models.LogHistory logHistory =
		//			dataBaseContext.LogHistories
		//			.Where(current => string.Compare(current.Username, log.Username) == 0)
		//			.OrderByDescending(current => current.Login_Time)
		//			.SingleOrDefault(current => current.Id == log.Id);

		//		if (logHistory != null)
		//		{
		//			logOutTime = $"{Infrastructure.Utility.ShowTime()}" +
		//				$"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} ";

		//			logHistory.Logout_Time = logOutTime;

		//			dataBaseContext.SaveChanges();
		//		}
		//		else
		//		{
		//			return;
		//		}
		//	}
		//	catch (System.Exception ex)
		//	{
		//		Infrastructure.Utility.ExceptionShow(ex);
		//	}
		//	finally
		//	{
		//		if (dataBaseContext != null)
		//		{
		//			dataBaseContext.Dispose();
		//			dataBaseContext = null;
		//		}
		//	}
		//}
		#endregion /SaveLogOutTime

		#region ShowTime
		/// <summary>
		/// A function that displays the clock.
		/// </summary>
		/// <returns>The device's system clock output</returns>
		public static string ShowTime()
		{
			string timeNow =
				System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8);

			return timeNow;
		}
		#endregion /ShowTime

		#region ShowTime
		/// <summary>
		/// Function for displaying time with display format.
		/// </summary>
		/// <returns>The device's system clock output</returns>
		public static string ShowTime(string format)
		{
			string timeNow =
				System.DateTime.Now.ToString(format);

			return timeNow;
		}
		#endregion /ShowTime							

		//-----Enf of the codes.
	}
}
