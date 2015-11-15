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

        [Test]
        public void TurnOnMagentaLight_calls_dlls_TurnOnMagentaLight()
        {
            var controller = new FakeController();
            var oBlync = new Blync(controller);

            oBlync.TurnOnMagentaLight(0);

            Assert.IsTrue(controller.isTurnOnMagentaLightCalled);
        }

        [Test]
        public void ResetLight_calls_dlls_ResetLight()
        {
            var controller = new FakeController();
            var oBlync = new Blync(controller);

            oBlync.ResetLight(0);

            Assert.IsTrue(controller.isResetLightCalled);
        }

    }

    public class FakeController: IBlynclightController
    {
        public bool isInitBlyncDevicesCalled = false;
        public bool isTurnOnMagentaLightCalled = false;
        public bool isResetLightCalled = false;

        public int InitBlyncDevices()
        {
            this.isInitBlyncDevicesCalled = true;
            return 1;
        }

        public void TurnOnMagentaLight(int deviceIndex)
        {
            this.isTurnOnMagentaLightCalled = true;
        }

        public void ResetLight(int deviceIndex)
        {
            this.isResetLightCalled = true;
        } 

    }
}
