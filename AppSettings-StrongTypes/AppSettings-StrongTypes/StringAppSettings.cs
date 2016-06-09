using System.Collections.Specialized;

namespace AppSettings_StrongTypes
{
	/// <summary>
	/// Helper extensions to get parsed string values from the app settings file
	/// </summary>
	public static partial class AppSettingsExtensions
	{
		/// <summary>
		/// Gets a string from the app settings, returns default value if value is null or empty
		/// </summary>
		/// <param name="appSettings">The app settings</param>
		/// <param name="key">The key of the value to get</param>
		/// <returns>A parsed string value from the app settings</returns>
		public static string GetString(this NameValueCollection appSettings, string key)
		{
			return GetString(appSettings, key, null);
		}

		/// <summary>
		/// Gets a string from the app settings, returns default value if value is null or empty
		/// </summary>
		/// <param name="appSettings">The app settings</param>
		/// <param name="key">The key of the value to get</param>
		/// <param name="defaultValue">A default value if the app setting does not contain a value or is not parseable</param>
		/// <returns>A parsed string value from the app settings</returns>
		public static string GetString(this NameValueCollection appSettings, string key, string defaultValue)
		{
			var value = appSettings[key];

			var success = value != null;

			return success ? value.ToString(Culture) : defaultValue;
		}
	}
}
