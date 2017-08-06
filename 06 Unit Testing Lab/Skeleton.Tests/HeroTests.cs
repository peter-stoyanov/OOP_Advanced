using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
public class HeroTests
{
    [Test]
    public void HeroGetsExperienceWhenTargetDies()
    {
        // Arrange
        var fakeWeapon = new Mock<IWeapon>();
        var fakeTarget = new Mock<ITarget>();

        fakeTarget.Setup(t => t.IsDead()).Returns(true);
        fakeTarget.Setup(t => t.GiveExperience()).Returns(10);

        var hero = new Hero("Pesho", fakeWeapon.Object);
        int initialExperience = hero.Experience;

        // Act
        hero.Attack(fakeTarget.Object);

        // Assert
        Assert.AreEqual(10, hero.Experience - initialExperience,
            "Hero's experience has not been increased with the dead target experience points.");

    }
}
