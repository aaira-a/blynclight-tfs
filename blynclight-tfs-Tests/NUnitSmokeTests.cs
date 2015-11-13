using NUnit.Framework;

namespace blynclight_tfs_Tests
{
    [TestFixture]
    public class NUnitSmokeTests
    {
        [Test]
        public void TestAdd2by3()
        {
            int result = NUnitSmoke.Calculator.Add(2, 3);
        }
    }
}
