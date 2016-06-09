using System.Collections.Specialized;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppSettings_StrongTypes.Tests
{
	[TestClass]
	public class BooleanTests
	{
		[TestMethod]
		public void GetBool_ValidInt_ReturnsParsedBool()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "true" }
			};

			var result = settings.GetBool("TestKey");

			Assert.AreEqual(true, result);
		}

		[TestMethod]
		public void GetBool_InvalidBool_ReturnsDefaultOfFalse()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "NotAnInt" }
			};

			var result = settings.GetBool("TestKey");

			Assert.AreEqual(false, result);
		}

		[TestMethod]
		public void GetBool_InvalidKey_ReturnsDefaultOfFalse()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "true" }
			};

			var result = settings.GetBool("NotTheTestKey");

			Assert.AreEqual(false, result);
		}

		[TestMethod]
		public void GetBool_HasDefault_ReturnsParsedBool()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "true" }
			};

			var result = settings.GetBool("TestKey", false);

			Assert.AreEqual(true, result);
		}

		[TestMethod]
		public void GetBool_InvalidBoolHasDefault_ReturnsDefault()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "NotAnInt" }
			};

			var result = settings.GetBool("TestKey", false);

			Assert.AreEqual(false, result);
		}

		[TestMethod]
		public void GetBool_InvalidKeyHasDefault_ReturnsDefault()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "true" }
			};

			var result = settings.GetBool("NotTheTestKey", false);

			Assert.AreEqual(false, result);
		}
	}
}
