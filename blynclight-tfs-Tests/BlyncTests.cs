using NUnit.Framework;
using NSubstitute;

using Blynclight;
using blynclight_tfs;

namespace blynclight_tfs_Tests
{
    [TestFixture]
    public class BlyncUserTests
    {
        [Test]
        public void getConnectedBlyncDevices_calls_InitBlyncDevices()
        {
            var mockController = Substitute.For<IBlynclightController>();
            var oBlync = new BlyncUser(mockController);

            oBlync.getConnectedBlyncDevices();

            mockController.Received().InitBlyncDevices();
        }

        [Test]
        public void TurnOnMagentaLight_calls_dlls_TurnOnMagentaLight()
        {
            var mockController = Substitute.For<IBlynclightController>();
            var oBlync = new BlyncUser(mockController);

            oBlync.TurnOnMagentaLight(0);

            mockController.Received().TurnOnMagentaLight(0);
        }

        [Test]
        public void BlyncUser_calls_Actual_ResetLight()
        {
            var mockController = Substitute.For<IBlynclightController>();
            var oBlync = new BlyncUser(mockController);

            oBlync.ResetLight(0);

            mockController.Received().ResetLight(0);
        }
    }
}
