using Blynclight;

namespace blynclight_tfs
{
    public class Explorer
    {
        public static int getConnectedBlyncDevices()
        {
            BlynclightController oBlynclightController = new BlynclightController();
            return oBlynclightController.InitBlyncDevices();
        }
    }
}
