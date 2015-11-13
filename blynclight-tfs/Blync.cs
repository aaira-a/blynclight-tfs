using Blynclight;

namespace blynclight_tfs
{
    // wrapper for controller from sdk/assembly
    public class Blync
    {
        public static int getConnectedBlyncDevices()
        {
            BlynclightController oBlynclightController = new BlynclightController();
            return oBlynclightController.InitBlyncDevices();
        }
    }
}
