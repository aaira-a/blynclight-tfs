using NUnit.Framework;
using NSubstitute;

using Blynclight;
using blynclight_tfs;

namespace blynclight_tfs_Tests
{
    [TestFixture]
    public class ExplorerTests
    {
        [Test]
        public void getConnectedBlyncDevices_calls_InitBlyncDevices()
        {
            BlynclightController mockController = Substitute.For<BlynclightController>();

            Explorer.getConnectedBlyncDevices();

            mockController.Received().InitBlyncDevices();
        }
    }
}
