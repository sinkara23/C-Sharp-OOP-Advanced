﻿using System;
using System.Globalization;

namespace Solid_Exercise.Models.Factories
{
	public class ErrorFactory
	{
		const string DateFormat = "M/d/yyyy h:mm:ss tt";

		public IError CreateError(string dateTimeString, string errorLevelString, string message)
		{
			DateTime dateTime = DateTime.ParseExact(dateTimeString, DateFormat, CultureInfo.InvariantCulture);
			ErrorLevel errorLevel = ParseErrorLevel(errorLevelString);
			IError error = new Error(dateTime, errorLevel, message);

			return error;
		}

		private ErrorLevel ParseErrorLevel(string levelString)
		{
			try
			{
				object levelObjs = Enum.Parse(typeof(ErrorLevel), levelString);
				ErrorLevel levelObj = (ErrorLevel)levelObjs;
				return levelObj;
			}
			catch (ArgumentException e)
			{
				throw new ArgumentException("Invalid ErrorLevel Type!", e);
			}
		}
	}
}
