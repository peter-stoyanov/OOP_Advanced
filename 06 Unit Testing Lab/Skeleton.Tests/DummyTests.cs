using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
public class DummyTests
{
    private const int AxeAttack = 10;
    private const int AxeDurability = 10;
    private const int DummyHp = 10;
    private const int DummyExp = 100;

    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void Testinit()
    {
        this.axe = new Axe(AxeAttack, AxeDurability);
        this.dummy = new Dummy(DummyHp, DummyExp);
    }

    [TestCase(10)]
    public void DummyLosesHealthWhenAttacked(int initialHealth)
    {
        // Arrange
        var dummy = new Dummy(initialHealth, 10);

        // Act
        this.axe.Attack(dummy);

        // assert
        Assert.AreEqual(initialHealth - axe.AttackPoints, dummy.Health,
            "Dummy lost wrong amount of health after attack from an axe.");
    }

    [Test]
    public void DeadDummyThrowsExceptionWhenAttacked()
    {
        // Arrange
        var dummy = new Dummy(0, 10);

        // Act
        TestDelegate attackDummy = () => axe.Attack(dummy);

        //Assert
        Assert.That(attackDummy, Throws.TypeOf<InvalidOperationException>(),
            "Dead dummy does not throw invalid operation exception when attacked.");
    }

    [Test]
    public void DeadDummyGivesExperience()
    {
        // Arrange
        var deadDummy = new Dummy(0, 10);

        // Act
        int xp = deadDummy.GiveExperience();

        // Assert
        Assert.AreEqual(10, xp,
            "Dead dummy should give experience (int).");
    }

    [Test]
    public void LiveDummyGivesExceptionWhenAskedToGiveExperience()
    {
        // Arrange

        // Act
        TestDelegate dummyGiveExp = () => this.dummy.GiveExperience();

        //Assert
        Assert.That(dummyGiveExp, Throws.TypeOf<InvalidOperationException>(),
            "Live dummy does not throw InvalidOperationException when asked to give experience.");
    }
}
