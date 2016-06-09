using System.Collections.Specialized;
using System.Globalization;

namespace AppSettings_StrongTypes
{
	/// <summary>
	/// Helper extensions to get parsed integer values from the app settings file
	/// </summary>
	public static partial class AppSettingsExtensions
	{
		/// <summary>
		/// Gets an integer from the app settings
		/// </summary>
		/// <param name="appSettings">The app settings</param>
		/// <param name="key">The key of the value to get</param>
		/// <returns>A parsed int value from the app settings</returns>
		public static int GetInt(this NameValueCollection appSettings, string key)
		{
			return GetInt(appSettings, key, 0);
		}

		/// <summary>
		/// Gets an integer from the app settings
		/// </summary>
		/// <param name="appSettings">The app settings</param>
		/// <param name="key">The key of the value to get</param>
		/// <param name="defaultValue">A default value if the app setting does not contain a value or is not parseable</param>
		/// <returns>A parsed int value from the app settings</returns>
		public static int GetInt(this NameValueCollection appSettings, string key, int defaultValue)
		{
			int parsedValue;

			var success = int.TryParse(appSettings[key], NumberStyles.Integer, Culture, out parsedValue);

			return success ? parsedValue : defaultValue;
		}
	}
}
