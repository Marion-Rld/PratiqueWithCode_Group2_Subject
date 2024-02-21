namespace EvaluationSampleCode.UnitTest;

[TestClass]
public class BaptizmTest
{
    [TestMethod]
    public void CanBeBaptizedBy_Priest_ReturnsTrue()
    {
        var clergyMember = new ClergyMember { IsPriest = true };
        var baptizm = new Baptizm(new ClergyMember());

        var result = baptizm.CanBeBaptizedBy(clergyMember);

        Assert.IsTrue(result);
    }
    [TestMethod]
    public void CanBeBaptizedBy_Pope_ReturnsTrue()
    {
        var clergyMember = new ClergyMember { IsPope = true };
        var baptizm = new Baptizm(new ClergyMember());

        var result = baptizm.CanBeBaptizedBy(clergyMember);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeBaptizedBy_NeitherPriestNorPope_ReturnsFalse()
    {
        var clergyMember = new ClergyMember();
        var baptizm = new Baptizm(new ClergyMember());

        var result = baptizm.CanBeBaptizedBy(clergyMember);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void CanBeTeachedBy_CreatedClergyMember_ReturnsTrue()
    {
        var clergyMember = new ClergyMember();
        var baptizm = new Baptizm(clergyMember);

        var result = baptizm.CanBeTeachedBy(clergyMember);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeTeachedBy_NotCreatedClergyMember_ReturnsFalse()
    {
        var clergyMember = new ClergyMember();
        var baptizm = new Baptizm(new ClergyMember());

        var result = baptizm.CanBeTeachedBy(clergyMember);

        Assert.IsFalse(result);
    }
}
