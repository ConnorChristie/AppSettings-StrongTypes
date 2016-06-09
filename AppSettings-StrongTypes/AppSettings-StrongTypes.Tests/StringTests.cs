using System.Collections.Specialized;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppSettings_StrongTypes.Tests
{
	[TestClass]
	public class StringTests
	{
		[TestMethod]
		public void GetString_ValidString_ReturnsParsedString()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "this is some text" }
			};

			var result = settings.GetString("TestKey");

			Assert.AreEqual("this is some text", result);
		}

		[TestMethod]
		public void GetString_InvalidKey_ReturnsDefaultOfNull()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "this is some text" }
			};

			var result = settings.GetString("NotTheTestKey");

			Assert.IsNull(result);
		}

		[TestMethod]
		public void GetString_HasDefault_ReturnsParsedString()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "this is some text" }
			};

			var result = settings.GetString("TestKey", "default text");

			Assert.AreEqual("this is some text", result);
		}

		[TestMethod]
		public void GetString_InvalidKeyHasDefault_ReturnsDefault()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "this is some text" }
			};

			var result = settings.GetString("NotTheTestKey", "default text");

			Assert.AreEqual("default text", result);
		}
	}
}
