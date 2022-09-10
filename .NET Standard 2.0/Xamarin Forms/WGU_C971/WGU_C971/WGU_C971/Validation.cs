/* 
     C971 Mobile Application Development Using C#
     Robert Calero
     Student ID# 000998416
*/

using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace WGU_C971
	{
		class Validation
			{
				public static bool NullCheck(string myEntry)
					{
						if (!String.IsNullOrEmpty(myEntry))
							{
								return true;
							}
						return false;
					}

				public static bool IsValidEmail(string myEmail)
					{
						if (string.IsNullOrWhiteSpace(myEmail))
							{
								return false;
							}

						try
							{
								myEmail = Regex.Replace(myEmail, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));
								string DomainMapper(Match match)
									{
										var idn = new IdnMapping();
										var domainName = idn.GetAscii(match.Groups[2].Value);
										return match.Groups[1].Value + domainName;
									}
							}
						catch (RegexMatchTimeoutException e)
							{
								return false;
							}
						catch (ArgumentException e)
							{
								return false;
							}

						try
							{
								return Regex.IsMatch(myEmail, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
							}
						catch (RegexMatchTimeoutException)
							{
								return false;
							}
					}

				public static bool EmailCheck(string myEntry)
					{
						if (!String.IsNullOrEmpty(myEntry) && IsValidEmail(myEntry))
							{
								return true;
							}
						return false;
					}
			}
	}
