using NUnit.Framework;
using NSubstitute;

using Blynclight;
using blynclight_tfs;

namespace blynclight_tfs_Tests
{
    [TestFixture]
    public class BlyncTests
    {
        [Test]
        public void getConnectedBlyncDevices_calls_InitBlyncDevices()
        {
            BlynclightController mockController = Substitute.For<BlynclightController>();

            Blync.getConnectedBlyncDevices();

            mockController.Received().InitBlyncDevices();
        }
    }
}
