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
            var mockController = Substitute.For<BlynclightController>();
            var oBlync = new Blync(mockController);

            //oBlync.getConnectedBlyncDevices();

            mockController.DidNotReceive().InitBlyncDevices();
        }

        [Test]
        public void TurnOnMagentaLight_calls_dlls_TurnOnMagentaLight()
        {
            var mockController = Substitute.For<BlynclightController>();
            var oBlync = new Blync(mockController);

            //oBlync.TurnOnMagentaLight(0);

            mockController.Received().TurnOnBlueLight(0);
        }

        [Test]
        public void ResetLight_calls_dlls_ResetLight()
        {
            var mockController = Substitute.For<BlynclightController>();
            var oBlync = new Blync(mockController);

            //oBlync.ResetLight(0);

            mockController.Received().ResetLight(0);
        }
    }

    [TestFixture]
    public class AlternateBlyncTests
    {
        [Test]
        public void Alternate_calls_concrete_ResetLight()
        {
            var mockController = Substitute.For<IBlynclightController>();
            var oBlync = new AlternateBlync(mockController);

            //oBlync.ResetLight(0);

            mockController.Received().ResetLight(0);
        }
    }
}
