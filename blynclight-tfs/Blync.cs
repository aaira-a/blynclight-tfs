using Blynclight;

namespace blynclight_tfs
{
    public class BlyncUser
    {
        BlynclightController controller;

        public BlyncUser()
        {
            this.controller = ActualControllerFactory.Create();
        }
        
        public BlyncUser(BlynclightController injected_controller)
        {
            this.controller = injected_controller;
        }

        public int getConnectedBlyncDevices()
        {
            return controller.InitBlyncDevices();
        }

        public void TurnOnMagentaLight(int deviceIndex)
        {
            this.controller.TurnOnMagentaLight(deviceIndex);
        }

        public void ResetLight(int deviceIndex)
        {
            this.controller.ResetLight(deviceIndex);
        }

    }

    public class ActualControllerFactory
    {
        public static BlynclightController Create()
        {
            return new BlynclightController();
        }
    }
}
