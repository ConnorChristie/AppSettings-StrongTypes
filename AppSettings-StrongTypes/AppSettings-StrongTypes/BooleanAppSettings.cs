using System.Collections.Specialized;

namespace AppSettings_StrongTypes
{
	/// <summary>
	/// Helper extensions to get parsed boolean values from the app settings file
	/// </summary>
	public static partial class AppSettingsExtensions
	{
		/// <summary>
		/// Gets a boolean from the app settings
		/// </summary>
		/// <param name="appSettings">The app settings</param>
		/// <param name="key">The key of the value to get</param>
		/// <returns>A parsed bool value from the app settings</returns>
		public static bool GetBool(this NameValueCollection appSettings, string key)
		{
			return GetBool(appSettings, key, false);
		}

		/// <summary>
		/// Gets a boolean from the app settings
		/// </summary>
		/// <param name="appSettings">The app settings</param>
		/// <param name="key">The key of the value to get</param>
		/// <param name="defaultValue">A default value if the app setting does not contain a value or is not parseable</param>
		/// <returns>A parsed bool value from the app settings</returns>
		public static bool GetBool(this NameValueCollection appSettings, string key, bool defaultValue)
		{
			bool parsedValue;

			var success = bool.TryParse(appSettings[key], out parsedValue);

			return success ? parsedValue : defaultValue;
		}
	}
}
