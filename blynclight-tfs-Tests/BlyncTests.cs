using Microsoft.QualityTools.Testing.Fakes;
using NUnit.Framework;

using blynclight_tfs;

namespace blynclight_tfs_Tests
{
    [TestFixture]
    public class BlyncWrapperTests
    {
        [Test]
        public void getConnectedBlyncDevices_calls_dlls_InitBlyncDevices()
        {
            using (ShimsContext.Create())
            {
                var fakeController = new Blynclight.Fakes.ShimBlynclightController();
                var called = false;

                fakeController.InitBlyncDevices = () => 
                { 
                    called = true;
                    return 1;
                };

                var oBlync = new BlyncWrapper(fakeController);
                var result = oBlync.getConnectedBlyncDevices();

                Assert.AreEqual(1, result);
                Assert.IsTrue(called);
            }
        }

        
        [Test]
        public void TurnOnMagentaLight_calls_dlls_TurnOnMagentaLight()
        {
            using (ShimsContext.Create())
            {
                var fakeController = new Blynclight.Fakes.ShimBlynclightController();
                var called = false;

                fakeController.TurnOnMagentaLightInt32 = (int index) =>
                {
                    called = true;
                    return true;
                };

                var oBlync = new BlyncWrapper(fakeController);
                oBlync.TurnOnMagentaLight(3);

                Assert.IsTrue(called);
            }
        }
        
        [Test]
        public void ResetLight_calls_dlls_ResetLight()
        {
            using (ShimsContext.Create())
            {
                var fakeController = new Blynclight.Fakes.ShimBlynclightController();
                var called = false;

                fakeController.ResetLightInt32 = (int index) =>
                {
                    called = true;
                    return true;
                };

                var oBlync = new BlyncWrapper(fakeController);
                oBlync.ResetLight(5);

                Assert.IsTrue(called);
            }
        }
        
         
    }
}
