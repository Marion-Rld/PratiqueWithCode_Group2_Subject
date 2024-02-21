namespace EvaluationSampleCode.UnitTest;

[TestClass]
public class HtmlFormatHelperTest
{
    [TestMethod]
    public void GetStrongFormat_WithCorrectTags_ReturnsStrongFormat()
    {
        var htmlFormatHelper = new HtmlFormatHelper();

        var result = htmlFormatHelper.GetStrongFormat("test");

        Assert.AreEqual("<strong>test</strong>", result);
    }
    [TestMethod]
    public void GetStrongFormat_MissingClosingTag_ReturnsIncorrectFormat()
    {
        var htmlFormatHelper = new HtmlFormatHelper();

        var result = htmlFormatHelper.GetStrongFormat("test");

        Assert.AreNotEqual("<strong>test", result);
    }

    [TestMethod]
    public void GetItalicFormat_WithCorrectTags_ReturnsItalicFormat()
    {
        var htmlFormatHelper = new HtmlFormatHelper();

        var result = htmlFormatHelper.GetItalicFormat("test");

        Assert.AreEqual("<i>test</i>", result);
    }

    [TestMethod]
    public void GetItalicFormat_MissingClosingTag_ReturnsIncorrectFormat()
    {
        var htmlFormatHelper = new HtmlFormatHelper();

        var result = htmlFormatHelper.GetItalicFormat("test");

        Assert.AreNotEqual("<i>test", result);
    }

    [TestMethod]
    public void GetFormattedListElements_WithCorrectTags_ReturnsFormattedListElements()
    {
        var htmlFormatHelper = new HtmlFormatHelper();

        var result = htmlFormatHelper.GetFormattedListElements(new List<string> { "test1", "test2" });

        Assert.AreEqual("<ul><li>test1</li><li>test2</li></ul>", result);
    }

    [TestMethod]
    public void GetFormattedListElements_MissingClosingTag_ReturnsIncorrectFormat()
    {
        var htmlFormatHelper = new HtmlFormatHelper();

        var result = htmlFormatHelper.GetFormattedListElements(new List<string> { "test1", "test2" });

        Assert.AreNotEqual("<ul><li>test1</li><li>test2</li>", result);
    }

}
