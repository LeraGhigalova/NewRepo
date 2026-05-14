using NUnit.Framework;
using System;

namespace RealPowerLibrary.Tests
{
    [TestFixture]
    public class RealPowerTests
    {
        private const double Tolerance = 1e-13;

        [Test]
        public void ConstructorTest()
        {
            RealPower power = new RealPower(2, 3);
            Assert.That(power.Base, Is.EqualTo(2).Within(Tolerance));
            Assert.That(power.Exponent, Is.EqualTo(3).Within(Tolerance));
        }

        [Test]
        public void Base_NegativeValue_ThrowsArgumentException()
        {
            RealPower power = new RealPower(2, 3);
            bool exceptionCaught = false;
            try { power.Base = -5; }
            catch (ArgumentException) { exceptionCaught = true; }
            Assert.IsTrue(exceptionCaught);
        }

        [Test]
        public void Base_ZeroValue_ThrowsArgumentException()
        {
            RealPower power = new RealPower(2, 3);
            bool exceptionCaught = false;
            try { power.Base = 0; }
            catch (ArgumentException) { exceptionCaught = true; }
            Assert.IsTrue(exceptionCaught);
        }

        [Test]
        public void Value_ShouldReturnCorrectPower()
        {
            RealPower power = new RealPower(2, 3);
            Assert.That(power.Value, Is.EqualTo(8).Within(Tolerance));
        }

        [Test]
        public void Value_WithNegativeExponent_ShouldReturnCorrectPower()
        {
            RealPower power = new RealPower(2, -1);
            Assert.That(power.Value, Is.EqualTo(0.5).Within(Tolerance));
        }

        [Test]
        public void Value_WithZeroExponent_ShouldReturnOne()
        {
            RealPower power = new RealPower(5, 0);
            Assert.That(power.Value, Is.EqualTo(1).Within(Tolerance));
        }

        [Test]
        public void ToString_ShouldReturnCorrectFormat()
        {
            RealPower power = new RealPower(2.5, 3.5);
            Assert.That(power.ToString(), Is.EqualTo("2,5E3,5"));
        }

        [Test]
        public void ToString_WithNegativeExponent_ShouldReturnCorrectFormat()
        {
            RealPower power = new RealPower(2, -3.5);
            Assert.That(power.ToString(), Is.EqualTo("2E-3,5"));
        }

        [Test]
        public void Equals_SameValues_ShouldReturnTrue()
        {
            RealPower power1 = new RealPower(2, 3);
            RealPower power2 = new RealPower(2, 3);
            Assert.That(power1.Equals(power2), Is.True);
        }

        [Test]
        public void Equals_DifferentValues_ShouldReturnFalse()
        {
            RealPower power1 = new RealPower(2, 3);
            RealPower power2 = new RealPower(2, 4);
            Assert.That(power1.Equals(power2), Is.False);
        }

        [Test]
        public void Equals_DifferentBaseSameValue_ShouldReturnTrue()
        {
            RealPower power1 = new RealPower(4, 0.5);
            RealPower power2 = new RealPower(2, 1);
            Assert.That(power1.Equals(power2), Is.True);
        }

        [Test]
        public void Equals_WrongArgument_ShouldReturnFalse()
        {
            RealPower power = new RealPower(2, 3);
            object obj = new object();
            Assert.That(power.Equals(obj), Is.False);
        }

        [Test]
        public void GetHashCode_SameValues_ShouldBeEqual()
        {
            RealPower power1 = new RealPower(2, 3);
            RealPower power2 = new RealPower(2, 3);
            Assert.That(power1.GetHashCode(), Is.EqualTo(power2.GetHashCode()));
        }

        [Test]
        public void GetHashCode_DifferentValues_ShouldBeDifferent()
        {
            RealPower power1 = new RealPower(2, 3);
            RealPower power2 = new RealPower(2, 4);
            Assert.That(power1.GetHashCode(), Is.Not.EqualTo(power2.GetHashCode()));
        }

        [Test]
        public void EqualityOperator_SameValues_ShouldReturnTrue()
        {
            RealPower power1 = new RealPower(2, 3);
            RealPower power2 = new RealPower(2, 3);
            Assert.That(power1 == power2, Is.True);
        }

        [Test]
        public void InequalityOperator_DifferentValues_ShouldReturnTrue()
        {
            RealPower power1 = new RealPower(2, 3);
            RealPower power2 = new RealPower(2, 4);
            Assert.That(power1 != power2, Is.True);
        }

        [Test]
        public void Multiplication_SameBase_ShouldAddExponents()
        {
            RealPower power1 = new RealPower(2, 3);
            RealPower power2 = new RealPower(2, 4);
            RealPower result = power1 * power2;
            Assert.That(result.Base, Is.EqualTo(2).Within(Tolerance));
            Assert.That(result.Exponent, Is.EqualTo(7).Within(Tolerance));
        }

        [Test]
        public void Multiplication_DifferentBase_ShouldThrowException()
        {
            RealPower power1 = new RealPower(2, 3);
            RealPower power2 = new RealPower(3, 4);
            bool exceptionCaught = false;
            try { RealPower result = power1 * power2; }
            catch (InvalidOperationException) { exceptionCaught = true; }
            Assert.IsTrue(exceptionCaught);
        }

        [Test]
        public void Division_SameBase_ShouldSubtractExponents()
        {
            RealPower power1 = new RealPower(2, 7);
            RealPower power2 = new RealPower(2, 3);
            RealPower result = power1 / power2;
            Assert.That(result.Base, Is.EqualTo(2).Within(Tolerance));
            Assert.That(result.Exponent, Is.EqualTo(4).Within(Tolerance));
        }

        [Test]
        public void Division_DifferentBase_ShouldThrowException()
        {
            RealPower power1 = new RealPower(2, 7);
            RealPower power2 = new RealPower(3, 3);
            bool exceptionCaught = false;
            try { RealPower result = power1 / power2; }
            catch (InvalidOperationException) { exceptionCaught = true; }
            Assert.IsTrue(exceptionCaught);
        }
    }
}