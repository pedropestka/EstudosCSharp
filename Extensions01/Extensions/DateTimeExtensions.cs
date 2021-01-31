using System.Globalization;

namespace System
{
	static class DateTimeExtensions
	{
		public static string ElapsedTime(this DateTime thisObj)
		{
			TimeSpan duracao = DateTime.Now.Subtract(thisObj);
			if (duracao.TotalHours < 24)
			{
				return duracao.TotalHours.ToString("F1", CultureInfo.InvariantCulture);
			}
			else
			{
				return duracao.TotalDays.ToString("F1", CultureInfo.InvariantCulture);
			}
		}
	}
}