namespace EvaluationSampleCode.UnitTest;

[TestClass]
public class PhoneNumberTest
{
    [TestMethod]
    public void Parse_WithCorrectPhoneNumber_ReturnsPhoneNumber()
    {
        var phoneNumber = PhoneNumber.Parse("0123456789"); 

        Assert.AreEqual("012", phoneNumber.Area);
        Assert.AreEqual("345", phoneNumber.Major);
        Assert.AreEqual("6789", phoneNumber.Minor);
    }

    [TestMethod]
    public void Parse_WithBlankPhoneNumber_ThrowsArgumentException()
    {
        Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(""));
    }

    [TestMethod]
    public void Parse_WithInvalidPhoneNumberLength_ThrowsArgumentException()
    {
        Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse("01543687"));
    }

    [TestMethod]
    public void ToString_WithCorrectPhoneNumber_ReturnsFormattedPhoneNumber()
    {
        var phoneNumber = PhoneNumber.Parse("0123456789");

        var result = phoneNumber.ToString();

        Assert.AreEqual("(012)345-6789", result);
    }

    [TestMethod]
    public void ToString_WithIncorrectPhoneNumber_ReturnsIncorrectFormattedPhoneNumber()
    {
        var phoneNumber = PhoneNumber.Parse("0123456789");

        var result = phoneNumber.ToString();

        Assert.AreNotEqual("(012)345-678", result);
    }
}
