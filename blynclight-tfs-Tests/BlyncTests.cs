using NUnit.Framework;

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
            var controller = new FakeController();
            var oBlync = new Blync(controller);

            oBlync.getConnectedBlyncDevices();

            Assert.IsTrue(controller.isInitBlyncDevicesCalled);
        }
    }

    public class FakeController: IBlynclightController
    {
        public bool isInitBlyncDevicesCalled = false;

        public int InitBlyncDevices()
        {
            this.isInitBlyncDevicesCalled = true;
            return 1;
        } 
    }
}
