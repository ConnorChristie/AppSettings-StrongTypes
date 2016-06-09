using System.Collections.Specialized;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppSettings_StrongTypes.Tests
{
	[TestClass]
	public class IntegerTests
	{
		[TestMethod]
		public void GetInt_ValidInt_ReturnsParsedInt()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "10" }
			};

			var result = settings.GetInt("TestKey");

			Assert.AreEqual(10, result);
		}

		[TestMethod]
		public void GetInt_InvalidInt_ReturnsDefaultOf0()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "NotAnInt" }
			};

			var result = settings.GetInt("TestKey");

			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void GetInt_InvalidKey_ReturnsDefaultOf0()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "10" }
			};

			var result = settings.GetInt("NotTheTestKey");

			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void GetInt_HasDefault_ReturnsParsedInt()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "10" }
			};

			var result = settings.GetInt("TestKey", 20);

			Assert.AreEqual(10, result);
		}

		[TestMethod]
		public void GetInt_InvalidIntHasDefault_ReturnsDefault()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "NotAnInt" }
			};

			var result = settings.GetInt("TestKey", 20);

			Assert.AreEqual(20, result);
		}

		[TestMethod]
		public void GetInt_InvalidKeyHasDefault_ReturnsDefault()
		{
			var settings = new NameValueCollection
			{
				{ "TestKey", "10" }
			};

			var result = settings.GetInt("NotTheTestKey", 20);

			Assert.AreEqual(20, result);
		}
	}
}
