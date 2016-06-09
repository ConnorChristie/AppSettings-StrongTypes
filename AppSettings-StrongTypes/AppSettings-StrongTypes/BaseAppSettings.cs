using System;
using System.Globalization;

namespace AppSettings_StrongTypes
{
	/// <summary>
	/// Helper extensions to get parsed values from the app settings file
	/// </summary>
	public static partial class AppSettingsExtensions
	{
		internal static readonly IFormatProvider Culture = CultureInfo.InvariantCulture;
	}
}
