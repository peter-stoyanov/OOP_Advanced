using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
public class AxeTests
{
    [Test]
    public void TestMethod()
    {
        // TODO: Add your test code here
        Assert.Pass("Your first passing test");
    }

    [Category("category one")]
    [Author("P Stoyanov")]
    [TestCase(10)]
    [TestCase(20)]
    [TestCase(30)]
    public void AfterAttackLosesDurabilityPoints(int initialDurability)
    {
        // Arrange
        var dummy = new Dummy(10, 10);
        var axe = new Axe(1, initialDurability);

        // Act
        axe.Attack(dummy);

        // Assert
        Assert.AreEqual(initialDurability - 1, axe.DurabilityPoints);
    }

    [Test]
    [Author("P Stoyanov")]
    public void BrokenAxeCantAttack()
    {
        Axe axe = new Axe(1, 1);
        Dummy dummy = new Dummy(10, 10);

        axe.Attack(dummy);

        var ex = Assert.Throws<InvalidOperationException>
                                  (() => axe.Attack(dummy));
        Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
    }

}
